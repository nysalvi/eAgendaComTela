using System.Windows.Forms;
using System.Collections;
using System;

using Dominio.Compartilhado;
using Dominio;
using Infra;

using Apresentacao.WinApp.Contatos;
using Apresentacao.WinApp.Compromissos;
using Apresentacao.WinApp.Tarefas;

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
            contatoRepositorio = new Repositorio<Contato>();
            compromissoRepositorio = new Repositorio<Compromisso>();
            tarefaRepositorio = new();
            gerenciador = new GerenciadorArquivos(System.IO.Path.GetDirectoryName("\\save.xml"));
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
            gerenciador.AdicionarRepositorio(contatoRepositorio);
            gerenciador.AdicionarRepositorio(compromissoRepositorio);
            gerenciador.AdicionarRepositorio(tarefaRepositorio);
        }
        private void CarregarGerenciador()
        {
            ArrayList array = gerenciador.CarregarRepositorio();

            for (int i = 0; i < array.Count; i++)
            {
                if (array[i].GetType() == typeof(Repositorio<Tarefa>))
                    tarefaRepositorio = (Repositorio<Tarefa>)array[i];
                else if (array[i].GetType() == typeof(Repositorio<Contato>))
                    contatoRepositorio = (Repositorio<Contato>)array[i];
                else if (array.GetType() == typeof(Repositorio<Compromisso>))
                    compromissoRepositorio = (Repositorio<Compromisso>)array[i];
            }
        }
    }
}
