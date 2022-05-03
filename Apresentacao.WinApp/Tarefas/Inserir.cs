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
            tarefaRepositorio = tarefaRepositorio;
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {

        }
    }
}
