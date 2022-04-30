using System;
using System.Windows.Forms;
using Apresentacao.WinApp.Contato;
using Dominio.Compartilhado;
using Dominio;

namespace eAgendaComTela.WinForms
{
    public partial class Main : Form
    {
        IRepositorio<Contato> contatoRepositorio;
        
        public Main()
        {
            InitializeComponent();
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

        }
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
