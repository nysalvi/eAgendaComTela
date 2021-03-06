using System.Windows.Forms;
using Dominio;
using Dominio.Compartilhado;
using System;

namespace Apresentacao.WinApp.Tarefas
{
    public partial class Editar : Form
    {
        Repositorio<Tarefa> tarefaRepositorio;
        Tarefa tarefaAntiga;
        int posicaoTarefa;
        public Editar(Repositorio<Tarefa> tarefaRepositorio, int posicaoTarefa)
        {
            InitializeComponent();
            this.tarefaRepositorio = tarefaRepositorio;
            this.posicaoTarefa = posicaoTarefa;

            this.comboBox1.Items.Add(Tarefa.PRIORIDADE.Alta);
            this.comboBox1.Items.Add(Tarefa.PRIORIDADE.Media);
            this.comboBox1.Items.Add(Tarefa.PRIORIDADE.Baixa);

            this.tarefaAntiga = tarefaRepositorio.Get(posicaoTarefa);

            this.comboBox1.SelectedItem = Tarefa.PRIORIDADE.Baixa;
        }

        private void buttonVoltar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void buttonEditar_Click(object sender, System.EventArgs e)
        {
            string titulo = textBoxTitulo.Text == "" ? tarefaAntiga.Titulo : textBoxTitulo.Text;

            Tarefa.PRIORIDADE prioridade = (Tarefa.PRIORIDADE)comboBox1.SelectedItem;

            if (campoVazio())
            {
                MessageBox.Show("Pelo Menos Um Campo precisa Ser Editado!!!", "ATENÇÃO", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            Tarefa tarefa = new Tarefa(titulo, tarefaAntiga.Criacao, prioridade);
            string resultado = tarefa.Validar();
            Tarefa? tarefaConflitante = tarefaRepositorio.Find(x => x.Numero != tarefaAntiga.Numero
                && x.Titulo == tarefa.Titulo);
            if (tarefaConflitante != null)
            {
                MessageBox.Show("Título da Tarefa já existe em outra Tarefa!!!",
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (resultado == "sucesso")
            {
                tarefaRepositorio.Editar(tarefa, posicaoTarefa);
                MessageBox.Show("Tarefa Editada Com Sucesso!!!", "SUCESSO", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                Close();
                return;
            }
            MessageBox.Show(resultado, "ERRO", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        private bool campoVazio()
        {
            if (textBoxTitulo.Text == "" && (Tarefa.PRIORIDADE)comboBox1.SelectedItem == tarefaAntiga.Prioridade)
                return true;
            return false;
        }
    }
}
