using System;
using System.Windows.Forms;
using Dominio.Compartilhado;
using Dominio;
using Apresentacao.WinApp.Contatos;
using Apresentacao.WinApp.Compromissos;

namespace eAgendaComTela.WinApp
{
    public partial class Main : Form
    {
        Repositorio<Contato> contatoRepositorio;
        Repositorio<Compromisso> compromissoRepositorio;

        public Main()
        {
            contatoRepositorio = new Repositorio<Contato>();
            compromissoRepositorio = new Repositorio<Compromisso>();
            InitializeComponent();
            Popular();
        }

        private void buttonTarefa_Click(object sender, EventArgs e)
        {

        }
        private void buttonContato_Click(object sender, EventArgs e)
        {
            TelaContato contato = new (contatoRepositorio);
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
        private void Popular()
        {
            string nome1 = "John Cena";
            string email1 = "cena.johncena@cenation";
            string telefone1 = "+55 (44) 9 3387 - 4828";
            string empresa1 = "NDD";
            string cargo1 = "Vice-CEO";
            contatoRepositorio.Inserir(new Contato(nome1, email1, telefone1, empresa1, cargo1));

            string nome2 = "Senhor Wilson";
            string email2 = "Wilson@colonia.ataca";
            string telefone2 = "+55 (48) 9 4624 - 9957";
            string empresa2 = "NDD";
            string cargo2 = "CEO";
            contatoRepositorio.Inserir(new Contato(nome2, email2, telefone2, empresa2, cargo2));
        }
    }
}
