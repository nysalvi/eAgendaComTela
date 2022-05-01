﻿using System;
using System.Windows.Forms;
using Dominio.Compartilhado;

namespace Apresentacao.WinApp.Contato    
{
    public partial class Inserir : Form
    {
        Repositorio<Dominio.Contato> contatoRepositorio;
        int TotalContatos { get; set; }
        public Inserir(Repositorio<Dominio.Contato> contatoRepositorio,int totalContatos)
        {
            InitializeComponent();      
            TotalContatos = totalContatos;
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
                MessageBox.Show("Cliente Adicionado Com Sucesso!!!", "SUCESSO", MessageBoxButtons.OK, 
                    MessageBoxIcon.Asterisk);

                contato.Numero = TotalContatos++;
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
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
