using System.Windows.Forms;
using Dominio;
using Dominio.Compartilhado;
using System.Collections.Generic;
using System;
using System.Linq;
namespace Apresentacao.WinApp.Contatos
{
    public partial class TelaContato : Form
    {
        Repositorio<Dominio.Contato> contatoRepositorio;
        readonly Repositorio<Compromisso> compromissoRepositorio;
        public int totalContatos;
        public TelaContato(Repositorio<Dominio.Contato> contatoRepositorio, Repositorio<Compromisso> compromissoRepositorio)
        {
            InitializeComponent();
            this.contatoRepositorio = contatoRepositorio;
            this.compromissoRepositorio = compromissoRepositorio;
            totalContatos = contatoRepositorio.EntidadeList.Count;
            AdicionarLinha(true);
        }
        private void buttonInserir_Click(object sender, System.EventArgs e)
        {
            Inserir inserir = new(contatoRepositorio);
            Hide();
            if (inserir.ShowDialog() == DialogResult.Cancel)
            {
                Show();
                AdicionarLinha(false);                
            }
        }
        private void buttonEditar_Click(object sender, System.EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lista Vazia", "ATENÇÃO", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(listView1.SelectedItems[0].Text, out int posicao))
            {
                MessageBox.Show("Seleção Inválida", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Hide();
            Editar editar = new(contatoRepositorio, posicao);
            if (editar.ShowDialog() == DialogResult.Cancel)
            {
                editarLinha(posicao);
                Show();
            }
        }
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nenhum Item Selecionado", "ATENÇÃO", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(listView1.SelectedItems[0].Text, out int posicao))
            {
                MessageBox.Show("Seleção Inválida", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Dominio.Contato contato = contatoRepositorio.EntidadeList.Find(x => x.Numero == posicao);
            if (compromissoRepositorio.EntidadeList.Find(x => x.Contato == contato) == null)
            {
                MessageBox.Show("O Contato Está Atrelado a um Compromisso", "ERRO", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }
            ListViewItem coluna = listView1.SelectedItems[0];
            listView1.Items.Remove(coluna);
            contatoRepositorio.Excluir(contato);
        }
        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        private void editarLinha(int posicao)
        {
            ListViewItem coluna = listView1.SelectedItems[0];
            Dominio.Contato contato = contatoRepositorio.EntidadeList[posicao];
            coluna.SubItems[1].Text = contato.Nome;
            coluna.SubItems[2].Text = contato.Email;
            coluna.SubItems[3].Text = contato.Telefone;
            coluna.SubItems[4].Text = contato.Empresa;
            coluna.SubItems[5].Text = contato.Cargo;
        }
        private void AdicionarLinha(bool adicionarListaCompleta)
        {
            if (contatoRepositorio.EntidadeList.Count == 0)
                return;
            int i = adicionarListaCompleta ? 0 : totalContatos;

            while (i < contatoRepositorio.EntidadeList.Count)
            {
                ListViewItem coluna = new("" + i);


                coluna.SubItems.Add(contatoRepositorio.EntidadeList[i].Nome);
                coluna.SubItems.Add(contatoRepositorio.EntidadeList[i].Email);
                coluna.SubItems.Add(contatoRepositorio.EntidadeList[i].Telefone);
                coluna.SubItems.Add(contatoRepositorio.EntidadeList[i].Empresa);
                coluna.SubItems.Add(contatoRepositorio.EntidadeList[i].Cargo);

                listView1.Items.Add(coluna);
                i++;
            }
            totalContatos = contatoRepositorio.EntidadeList.Count;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {                       
            if (comboBox1.SelectedIndex == 0)
            {
                listView1.Items.Clear();

                foreach (Dominio.Contato c in contatoRepositorio.EntidadeList)
                {
                    ListViewItem coluna = new("" + c.Numero);

                    coluna.SubItems.Add(c.Nome);
                    coluna.SubItems.Add(c.Email);
                    coluna.SubItems.Add(c.Telefone);
                    coluna.SubItems.Add(c.Empresa);
                    coluna.SubItems.Add(c.Cargo);

                    listView1.Items.Add(coluna);

                }
                return;
            }
            AgruparCargo();
        }

        private  void AgruparCargo()
        {
            listView1.Items.Clear();
            List<Dominio.Contato> copia = new(contatoRepositorio.EntidadeList.OrderBy(x=> x.Cargo));

            foreach (Dominio.Contato c in copia)
            {
                ListViewItem coluna = new("" + c.Numero);

                coluna.SubItems.Add(c.Nome);
                coluna.SubItems.Add(c.Email);
                coluna.SubItems.Add(c.Telefone);
                coluna.SubItems.Add(c.Empresa);
                coluna.SubItems.Add(c.Cargo);

                listView1.Items.Add(coluna);                
            }
        }
    }
}
