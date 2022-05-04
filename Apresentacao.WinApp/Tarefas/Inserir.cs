using System;
using Dominio;
using Dominio.Compartilhado;
using System.Windows.Forms;

namespace Apresentacao.WinApp.Tarefas
{
    public partial class Inserir : Form
    {
        Repositorio<Tarefa> tarefaRepositorio;
        public Inserir(Repositorio<Tarefa> tarefaRepositorio)
        {
            InitializeComponent();
            this.tarefaRepositorio = tarefaRepositorio;
            comboBoxPrioridade.SelectedIndex = 2;
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            string titulo = textBoxTitulo.Text;

            Tarefa.PRIORIDADE prioridade = comboBoxPrioridade.SelectedIndex == 0 ? Tarefa.PRIORIDADE.Alta 
                : comboBoxPrioridade.SelectedIndex == 1 ? Tarefa.PRIORIDADE.Media : Tarefa.PRIORIDADE.Baixa;

            DateTime criacao = DateTime.Parse(maskedTextBoxCriacao.Text);

            Tarefa t = new Tarefa(titulo, criacao, prioridade);
            string resultado = t.Validar();

            if (resultado != "sucesso")
            {
                MessageBox.Show(resultado, "ERRO", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
                return;
            }

            if (tarefaRepositorio.EntidadeList.Count > 0)
            {
                Tarefa? tarefaConflitante = tarefaRepositorio.EntidadeList.Find(x => x.Titulo == t.Titulo);
                if (tarefaConflitante != null)
                {
                    MessageBox.Show("Título da Tarefa já existe em outra Tarefa!!!",
                        "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Tarefa Adicionada Com Sucesso!!!", "SUCESSO", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
            tarefaRepositorio.Inserir(t);
            textBoxTitulo.Clear();
            comboBoxPrioridade.SelectedIndex = 2;
            maskedTextBoxCriacao.Clear();
        }
    }
}
