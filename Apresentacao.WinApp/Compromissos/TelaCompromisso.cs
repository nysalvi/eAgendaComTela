using System;
using System.Windows.Forms;
using Dominio;
using Dominio.Compartilhado;

namespace Apresentacao.WinApp.Compromissos
{
    public partial class TelaCompromisso : Form
    {
        Repositorio<Compromisso> compromissoRepositorio;
        readonly Repositorio<Dominio.Contato> contatoRepositorio;
        public int totalCompromissos;
        public TelaCompromisso(Repositorio<Compromisso> compromissoRepositorio, 
            Repositorio<Dominio.Contato> contatoRepositorio)
        {
            InitializeComponent();
            this.compromissoRepositorio = compromissoRepositorio;
            this.contatoRepositorio = contatoRepositorio;
            totalCompromissos = compromissoRepositorio.EntidadeList.Count;
            AdicionarLinha(true);
        }
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            Inserir inserir = new(compromissoRepositorio, contatoRepositorio);
            Hide();
            if (inserir.ShowDialog() == DialogResult.Cancel)
            {
                Show();
                AdicionarLinha(false);
            }
        }
        private void buttonEditar_Click(object sender, EventArgs e)
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
            Editar editar = new(compromissoRepositorio, posicao, contatoRepositorio);
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

            ListViewItem coluna = listView1.SelectedItems[0];
            listView1.Items.Remove(coluna);
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void editarLinha(int posicao)
        {
            ListViewItem coluna = listView1.SelectedItems[0];
            Compromisso compromisso = compromissoRepositorio.EntidadeList[posicao];
            coluna.SubItems[1].Text = compromisso.Assunto;
            coluna.SubItems[2].Text = compromisso.Local;
            coluna.SubItems[3].Text = compromisso.Data.ToString();
            coluna.SubItems[4].Text = compromisso.HoraInicio.ToString();
            coluna.SubItems[5].Text = compromisso.HoraTermino.ToString();
            coluna.SubItems[6].Text = compromisso.Contato.ToString();
        }
        private void AdicionarLinha(bool adicionarListaCompleta)
        {
            if (compromissoRepositorio.EntidadeList.Count == 0)
                return;
            int i = adicionarListaCompleta ? 0 : compromissoRepositorio.EntidadeList.Count - 1;
            string contatoNull = compromissoRepositorio.EntidadeList[i].Contato == null ?
                "Sem Contato Associado" : compromissoRepositorio.EntidadeList[i].Contato.ToString();
            while (i < compromissoRepositorio.EntidadeList.Count)
            {
                ListViewItem coluna = new("" + i);

                coluna.SubItems.Add(compromissoRepositorio.EntidadeList[i].Assunto);
                coluna.SubItems.Add(compromissoRepositorio.EntidadeList[i].Local);
                coluna.SubItems.Add(compromissoRepositorio.EntidadeList[i].Data.ToString());
                coluna.SubItems.Add(compromissoRepositorio.EntidadeList[i].HoraInicio.ToString());
                coluna.SubItems.Add(compromissoRepositorio.EntidadeList[i].HoraTermino.ToString());
                coluna.SubItems.Add(contatoNull);

                listView1.Items.Add(coluna);
                i++;
            }
            totalCompromissos = compromissoRepositorio.EntidadeList.Count;
        }
    }
}
