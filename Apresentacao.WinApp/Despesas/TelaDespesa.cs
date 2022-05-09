using System;
using Dominio;
using Dominio.Compartilhado;
using System.Windows.Forms;

namespace Apresentacao.WinApp.Despesas
{
    public partial class TelaDespesa : Form
    {
        Repositorio<Despesa> despesaRepositorio;
        int totalDespesas;
        public TelaDespesa(Repositorio<Despesa> despesaRepositorio)
        {
            InitializeComponent();
            this.despesaRepositorio = despesaRepositorio;
        }
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            Inserir inserir = new(despesaRepositorio);
            Hide();
            if (inserir.ShowDialog() == DialogResult.Cancel)
            {
                Show();
                AdicionarLinha(false);
            }
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }
        private void buttonExcluir_Click(object sender, EventArgs e)
        {

        }

        private void buttonGastoPorMes_Click(object sender, EventArgs e)
        {

        }

        private void buttonGastoPorCategoria_Click(object sender, EventArgs e)
        {

        }
        private void AdicionarLinha(bool adicionarListaCompleta)
        {
            if (despesaRepositorio.Count == 0)
                return;
            int i = adicionarListaCompleta ? 0 : totalDespesas;

            while (i < despesaRepositorio.Count)
            {
                ListViewItem coluna = new("" + i);

                coluna.SubItems.Add(despesaRepositorio.Get(i).Descricao);
                coluna.SubItems.Add(despesaRepositorio.Get(i).Data.ToString());
                coluna.SubItems.Add(despesaRepositorio.Get(i).Categoria);
                coluna.SubItems.Add(despesaRepositorio.Get(i).Valor.ToString());
                coluna.SubItems.Add(despesaRepositorio.Get(i).FormaPagamento.ToString());

                listView1.Items.Add(coluna);
                i++;
            }
            totalDespesas = despesaRepositorio.Count;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
