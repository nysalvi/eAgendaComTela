using System.Windows.Forms;
using System.Collections;
using System;

using Dominio.Compartilhado;
using Dominio;
using Infra;

using Apresentacao.WinApp.Contatos;
using Apresentacao.WinApp.Compromissos;
using Apresentacao.WinApp.Tarefas;

using System.IO;

namespace eAgendaComTela.WinApp
{
    public partial class Main : Form
    {
        GerenciadorArquivos gerenciador;

        Repositorio<Contato> contatoRepositorio;
        Repositorio<Compromisso> compromissoRepositorio;
        Repositorio<Tarefa> tarefaRepositorio;
        public Main()
        {
            InitializeComponent();
            gerenciador = new GerenciadorArquivos(Directory.GetCurrentDirectory() + "\\save.json");
            CarregarGerenciador();           
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

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            PopularGerenciador();
            gerenciador.SalvarRepositorio();
        }

        private void PopularGerenciador()
        {
            gerenciador.AdicionarList(contatoRepositorio.GetAll);
            gerenciador.AdicionarList(compromissoRepositorio.GetAll);
            gerenciador.AdicionarList(tarefaRepositorio.GetAll);
        }
        private void CarregarGerenciador()
        {
            contatoRepositorio = new Repositorio<Contato>(gerenciador.PegarList<Contato>());
            compromissoRepositorio = new Repositorio<Compromisso>(gerenciador.PegarList<Compromisso>());
            tarefaRepositorio = new(gerenciador.PegarList<Tarefa>());
        }
    }
}
