using System;
using Dominio.Compartilhado;
using Dominio;
using System.Windows.Forms;

namespace Apresentacao.WinApp.Contatos
{
    public partial class Editar : Form
    {
        Repositorio<Dominio.Contato> contatoRepositorio;
        int posicaoContato;
        public Editar(Repositorio<Dominio.Contato> contatoRepositorio, int posicaoContato)
        {
            InitializeComponent();
            this.posicaoContato = posicaoContato;
            this.contatoRepositorio = contatoRepositorio;
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Dominio.Contato contatoAntigo = contatoRepositorio.Get(posicaoContato);

            string nome = textBoxNome.Text == "" ? contatoAntigo.Nome : textBoxNome.Text;
            string email = textBoxEmail.Text == "" ? contatoAntigo.Email : textBoxEmail.Text;
            string telefone = textBoxTelefone.Text == "" ? contatoAntigo.Telefone : textBoxTelefone.Text;
            string empresa = textBoxEmpresa.Text == "" ? contatoAntigo.Empresa : textBoxEmpresa.Text;
            string cargo = textBoxCargo.Text == "" ? contatoAntigo.Cargo : textBoxCargo.Text;

            if (campoVazio())
            {
                MessageBox.Show("Pelo Menos Um Campo precisa Ser Editado!!!", "ATENÇÃO", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            Dominio.Contato contato = new(nome, email, telefone, empresa, cargo);
            string resultado = contato.Validar();

            if (resultado == "sucesso")
            {
                contatoRepositorio.Editar(contato, posicaoContato);
                MessageBox.Show("Cliente Editado Com Sucesso!!!", "SUCESSO", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                Close();
            }
            else
            {
                MessageBox.Show(contato.Validar(), "ERRO", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private bool campoVazio()
        {
            if (textBoxCargo.Text == "" && textBoxEmail.Text == "")
            {
                if (textBoxEmpresa.Text == "" && textBoxNome.Text == "" && textBoxTelefone.Text == "")
                    return true;
            }
            return false;
        }
    }
}
