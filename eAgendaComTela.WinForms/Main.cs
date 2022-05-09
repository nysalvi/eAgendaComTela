using System.Windows.Forms;
using System.Collections;
using System;

using Dominio.Compartilhado;
using Dominio;
using Infra;

using Apresentacao.WinApp.Contatos;
using Apresentacao.WinApp.Compromissos;
using Apresentacao.WinApp.Tarefas;
using Apresentacao.WinApp.Despesas;

using System.IO;
using System.Collections.Generic;

namespace eAgendaComTela.WinApp
{
    public partial class Main : Form
    {
        GerenciadorArquivos gerenciador;

        Repositorio<Contato> contatoRepositorio;
        Repositorio<Compromisso> compromissoRepositorio;
        Repositorio<Tarefa> tarefaRepositorio;
        Repositorio<Despesa> despesaRepositorio;
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
            MessageBox.Show("Salvado Com Sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void PopularGerenciador()
        {
            gerenciador.AdicionarList(contatoRepositorio.GetAll);
            gerenciador.AdicionarList(compromissoRepositorio.GetAll);
            gerenciador.AdicionarList(tarefaRepositorio.GetAll);
            gerenciador.AdicionarList(despesaRepositorio.GetAll);
        }
        private void CarregarGerenciador()
        {
            contatoRepositorio = new Repositorio<Contato>(gerenciador.PegarList<Contato>());
            compromissoRepositorio = new Repositorio<Compromisso>(gerenciador.PegarList<Compromisso>());
            tarefaRepositorio = new(gerenciador.PegarList<Tarefa>());
            despesaRepositorio = new(gerenciador.PegarList<Despesa>());
        }

        private void buttonDespesas_Click(object sender, EventArgs e)
        {
            TelaDespesa despesa = new TelaDespesa(despesaRepositorio);
            Hide();
            if (despesa.ShowDialog() == DialogResult.Cancel)
                Show();

        }
    }
}
