using System.Windows.Forms;
using Dominio.Compartilhado;
using Dominio;
using System.ComponentModel;
using System.Collections.Generic;
using System;
using Apresentacao.WinApp.Contatos;

namespace Apresentacao.WinApp.Contato
{
    public partial class TelaContato : Form
    {
        Repositorio<Dominio.Contato> contatoRepositorio;
        public int totalContatos;
        public TelaContato(Repositorio<Dominio.Contato> contatoRepositorio)
        {
            InitializeComponent();
            this.contatoRepositorio = contatoRepositorio;
            totalContatos = contatoRepositorio.EntidadeList.Count;
            AdicionarLinha(true);
            //dataGridView.DataSource = contatoRepositorio.EntidadeList;
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
        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        private void buttonEditar_Click(object sender, System.EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lista Vazia", "ATENÇÃO", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            
            int posicao = Convert.ToInt32(listView1.SelectedItems[0].Text);
            //MessageBox.Show(contato, "SUCESSO", MessageBoxButtons.OK,
            //    MessageBoxIcon.Asterisk);

            Hide();
            Editar editar = new(contatoRepositorio, posicao);
            if (editar.ShowDialog() == DialogResult.Cancel)
            {
                editarLinha(posicao);
                Show();
            }
        }
        private void AdicionarLinha(bool adicionarListaCompleta)
        {
            //cont.Numero = ++totalContatos;


            //ListViewItem.ListViewSubItem nome = new(coluna, cont.Nome);
            //ListViewItem.ListViewSubItem email = new(coluna, cont.Email);
            //ListViewItem.ListViewSubItem telefone = new(coluna, cont.Telefone);
            //ListViewItem.ListViewSubItem empresa = new(coluna, cont.Empresa);
            //ListViewItem.ListViewSubItem cargo = new(coluna, cont.Cargo);
            int i = adicionarListaCompleta ? 0 : contatoRepositorio.EntidadeList.Count;

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
    }
}
