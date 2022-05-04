using System;
using System.Windows.Forms;
using Dominio.Compartilhado;
using Dominio;
using Apresentacao.WinApp.Contatos;
using Apresentacao.WinApp.Compromissos;
using Apresentacao.WinApp.Tarefas;

namespace eAgendaComTela.WinApp
{
    public partial class Main : Form
    {
        Repositorio<Contato> contatoRepositorio;
        Repositorio<Compromisso> compromissoRepositorio;
        Repositorio<Tarefa> tarefaRepositorio;
        public Main()
        {
            contatoRepositorio = new Repositorio<Contato>();
            compromissoRepositorio = new Repositorio<Compromisso>();
            tarefaRepositorio = new();
            InitializeComponent();
        }

        private void buttonTarefa_Click(object sender, EventArgs e)
        {
            TelaTarefa tarefa = new TelaTarefa(tarefaRepositorio);
            Hide();
            if (tarefa.ShowDialog() == DialogResult.Cancel)
                Show();

        }
        private void buttonContato_Click(object sender, EventArgs e)
        {
            TelaContato contato = new (contatoRepositorio, compromissoRepositorio);
            Hide();
            if (contato.ShowDialog() == DialogResult.Cancel)
                Show();

        }
        private void buttonCompromisso_Click(object sender, EventArgs e)
        {
            TelaCompromisso compromisso = new TelaCompromisso(compromissoRepositorio, contatoRepositorio);
            Hide();
            if (compromisso.ShowDialog() == DialogResult.Cancel)
                Show();
        }
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
