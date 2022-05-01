using System;
using Dominio.Compartilhado;
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
            Dominio.Contato contatoAntigo = contatoRepositorio.EntidadeList[posicaoContato];

            string nome = textBoxNome.Text == "" ? contatoAntigo.Nome : textBoxNome.Text;
            string email = textBoxEmail.Text == "" ? contatoAntigo.Email : textBoxEmail.Text;
            string telefone = textBoxTelefone.Text == "" ? contatoAntigo.Telefone : textBoxTelefone.Text;
            string empresa = textBoxEmpresa.Text;
            string cargo = textBoxCargo.Text;

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
    }
}
