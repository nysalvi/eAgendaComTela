using Dominio.Compartilhado;
using Dominio;
using System.Windows.Forms;

namespace Apresentacao.WinApp.Tarefas
{
    public partial class TelaTarefa : Form
    {
        Repositorio<Tarefa> tarefaRepositorio;
        int totalTarefas;
        public TelaTarefa(Repositorio<Tarefa> tarefaRepositorio)
        {
            InitializeComponent();
            this.tarefaRepositorio = tarefaRepositorio;
        }

        private void buttonCriar_Click(object sender, System.EventArgs e)
        {
            Inserir inserir = new(tarefaRepositorio);
            Hide();
            if (inserir.ShowDialog() == DialogResult.Cancel)
            {
                Show();
                AdicionarLinha(false);
            }
        }
        private void AdicionarLinha(bool adicionarListaCompleta)
        {
            if (tarefaRepositorio.EntidadeList.Count == 0)
                return;
            int i = adicionarListaCompleta ? 0 : totalTarefas;

            while (i < tarefaRepositorio.EntidadeList.Count)
            {
                ListViewItem coluna = new("" + i);


                coluna.SubItems.Add(tarefaRepositorio.EntidadeList[i].Titulo);
                coluna.SubItems.Add(tarefaRepositorio.EntidadeList[i].Prioridade);
                coluna.SubItems.Add(tarefaRepositorio.EntidadeList[i].Criacao.ToString());
                coluna.SubItems.Add(tarefaRepositorio.EntidadeList[i].Devolucao.ToString());
                coluna.SubItems.Add(tarefaRepositorio.EntidadeList[i].Percentual.ToString());

                listView1.Items.Add(coluna);
                i++;
            }
            totalTarefas = tarefaRepositorio.EntidadeList.Count;
        }
    }
}
