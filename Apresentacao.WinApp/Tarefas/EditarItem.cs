using System;
using Dominio;
using System.Windows.Forms;

namespace Apresentacao.WinApp.Tarefas
{
    public partial class EditarItem : Form
    {
        Tarefa tarefa;
        public EditarItem(Tarefa tarefa)
        {
            InitializeComponent();
            comboBoxConcluido.Items.Add(tarefa.itens);
            this.tarefa = tarefa;
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            string descricao = textBoxDescricao.Text;
            bool concluido = comboBoxConcluido.Text == "Sim" ? true : false;

            Item item = new Item(descricao, concluido);

            string resultado = item.Validar();

            if (resultado != "sucesso")
            {
                MessageBox.Show(resultado, "ERRO", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            Item? itemConflitante = tarefa.itens.Find(x => x.Descricao == descricao);

            if (itemConflitante != null)
            {
                MessageBox.Show("A descrição do Item Já está Presente Em outro Item", "ERRO", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }            

            textBoxDescricao.Text = "";
            comboBoxConcluido.SelectedIndex = 0;

            MessageBox.Show("Item Editado Com Sucesso!", resultado, MessageBoxButtons.OK,
            MessageBoxIcon.Asterisk);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item selecionado = (Item)comboBoxItem.SelectedItem;
            textBoxDescricao.Text = selecionado.Descricao;
            comboBoxConcluido.SelectedIndex = selecionado.Concluido ? 1 : 0;
        }
    }
}
