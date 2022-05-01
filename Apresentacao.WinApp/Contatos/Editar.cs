﻿using System;
using Dominio.Compartilhado;
using System.Windows.Forms;

namespace Apresentacao.WinApp.Contatos
{
    public partial class Editar : Form
    {
        Repositorio<Dominio.Contato> contatoRepositorio;
        public Editar(Repositorio<Dominio.Contato> contatoRepositorio)
        {
            InitializeComponent();
            this.contatoRepositorio = contatoRepositorio;
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
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
                MessageBox.Show("Cliente Adicionado Com Sucesso!!!", "SUCESSO", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);

                contatoRepositorio.Inserir(contato);
                textBoxNome.Clear();
                textBoxEmail.Clear();
                textBoxTelefone.Clear();
                textBoxEmpresa.Clear();
                textBoxCargo.Clear();
            }
            else
            {
                MessageBox.Show(contato.Validar(), "ERRO", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
