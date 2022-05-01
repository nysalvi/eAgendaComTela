using System.Windows.Forms;
using Dominio.Compartilhado;
using Dominio;
using System.ComponentModel;
using System.Collections.Generic;
using System;
using Apresentacao.WinApp.Contatos;

namespace Apresentacao.WinApp.Contato
{
    public partial class TelaContato : Form
    {
        Repositorio<Dominio.Contato> contatoRepositorio;
        public int totalContatos;
        public TelaContato(Repositorio<Dominio.Contato> contatoRepositorio)
        {
            InitializeComponent();
            this.contatoRepositorio = contatoRepositorio;
            //dataGridView.DataSource = contatoRepositorio.EntidadeList;
        }
        private void buttonInserir_Click(object sender, System.EventArgs e)
        {
            Inserir inserir = new(contatoRepositorio, totalContatos);
            Hide();
            if (inserir.ShowDialog() == DialogResult.Cancel)
            {
                Show();
                AdicionarLinha();                
            }
        }
        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        private void AdicionarLinha()
        {
            //cont.Numero = ++totalContatos;


            //ListViewItem.ListViewSubItem nome = new(coluna, cont.Nome);
            //ListViewItem.ListViewSubItem email = new(coluna, cont.Email);
            //ListViewItem.ListViewSubItem telefone = new(coluna, cont.Telefone);
            //ListViewItem.ListViewSubItem empresa = new(coluna, cont.Empresa);
            //ListViewItem.ListViewSubItem cargo = new(coluna, cont.Cargo);

            for (int i = totalContatos; i < contatoRepositorio.EntidadeList.Count; i++)
            {
                ListViewItem coluna = new("" + totalContatos);

                coluna.SubItems.Add(contatoRepositorio.EntidadeList[i].Nome);
                coluna.SubItems.Add(contatoRepositorio.EntidadeList[i].Email);
                coluna.SubItems.Add(contatoRepositorio.EntidadeList[i].Telefone);
                coluna.SubItems.Add(contatoRepositorio.EntidadeList[i].Empresa);
                coluna.SubItems.Add(contatoRepositorio.EntidadeList[i].Cargo);

                listView1.Items.Add(coluna);
            }

            totalContatos = contatoRepositorio.EntidadeList.Count;

        }

        private void buttonEditar_Click(object sender, System.EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lista VAzia", "SUCESSO", MessageBoxButtons.OK,
        MessageBoxIcon.Asterisk);

            }
            else
            {
            string contato = listView1.SelectedItems[0].Text;
            Console.WriteLine(contato);
            MessageBox.Show(contato, "SUCESSO", MessageBoxButtons.OK,
    MessageBoxIcon.Asterisk);

            Editar editar = new(contatoRepositorio);
            }
            
        }
    }
}
