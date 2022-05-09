using System;
using System.Windows.Forms;
using Dominio.Compartilhado;

namespace Apresentacao.WinApp.Contatos 
{
    public partial class Inserir : Form
    {
        Repositorio<Dominio.Contato> contatoRepositorio;
        public Inserir(Repositorio<Dominio.Contato> contatoRepositorio)
        {
            InitializeComponent();      
            this.contatoRepositorio = contatoRepositorio;
        }
        private void buttonCriar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string email = textBoxEmail.Text;
            string telefone = textBoxTelefone.Text;
            string empresa = textBoxEmpresa.Text;
            string cargo = textBoxCargo.Text;

            Dominio.Contato contato = new(nome, email, telefone, empresa, cargo);
            string resultado = contato.Validar();

            if (resultado == "sucesso")
            {
                if (contatoRepositorio.Find(x => x.Nome == contato.Nome || x.Email == contato.Email
                    || x.Telefone == contato.Telefone) != null)
                {
                    MessageBox.Show("Nome/Telefone/Email já inserido!!!", "ERRO", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Contato Adicionado Com Sucesso!!!", "SUCESSO", MessageBoxButtons.OK, 
                    MessageBoxIcon.Asterisk);

                contatoRepositorio.Inserir(contato);
                textBoxNome.Clear();
                textBoxEmail.Clear();
                textBoxTelefone.Clear();
                textBoxEmpresa.Clear();
                textBoxCargo.Clear();
            }
        }
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
