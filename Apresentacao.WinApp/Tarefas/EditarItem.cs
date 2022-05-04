using System;
using Dominio;
using System.Windows.Forms;

namespace Apresentacao.WinApp.Tarefas
{
    public partial class EditarItem : Form
    {
        Tarefa tarefa;
        int posicaoItem;
        public EditarItem(Tarefa tarefa)
        {
            InitializeComponent();
            comboBoxItem.Items.AddRange(tarefa.itens.GetAll.ToArray());
            this.tarefa = tarefa;
            comboBoxConcluido.SelectedIndex = 1;
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Item itemAntigo = tarefa.itens.Get(comboBoxItem.SelectedIndex);

            string descricao = textBoxDescricao.Text;
            bool concluido = comboBoxConcluido.Text == "Sim" ? true : false;

            if (descricao == itemAntigo.Descricao && concluido == itemAntigo.Concluido)
            {
                MessageBox.Show("Pelo Menos Um dos Itens Precisam Ser Alterados", "ERRO", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            Item item = new Item(descricao, concluido);

            string resultado = item.Validar();

            if (resultado != "sucesso")
            {
                MessageBox.Show(resultado, "ERRO", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }


            Item? itemConflitante = tarefa.itens.Find(x => x != itemAntigo && x.Descricao == descricao);

            if (itemConflitante != null)
            {
                MessageBox.Show("A descrição do Item Já está Presente Em outro Item", "ERRO", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }            

            textBoxDescricao.Text = "";
            comboBoxConcluido.SelectedIndex = 1;

            tarefa.itens.Editar(item, posicaoItem);
            MessageBox.Show("Item Editado Com Sucesso!", resultado, MessageBoxButtons.OK,
            MessageBoxIcon.Asterisk);

        }

        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            posicaoItem = comboBoxItem.SelectedIndex;
            Item selecionado = (Item)comboBoxItem.SelectedItem;
            textBoxDescricao.Text = selecionado.Descricao;
            comboBoxConcluido.SelectedIndex = selecionado.Concluido ? 0 : 1;
        }
    }
}
