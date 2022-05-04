using System;
using System.Windows.Forms;
using Dominio;
namespace Apresentacao.WinApp.Tarefas
{
    public partial class InserirItem : Form
    {
        Tarefa tarefa;
        public InserirItem(Tarefa tarefa)
        {
            InitializeComponent();
            this.tarefa = tarefa;
        }
        private void buttonCriar_Click(object sender, EventArgs e)
        {
            string descricao = textBoxDescricao.Text;
            bool concluido = comboBox1.Text == "Sim" ? true : false;

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

            tarefa.AdicionarItem(item);

            textBoxDescricao.Text = "";
            comboBox1.SelectedIndex = 0;

            MessageBox.Show("Item Adicionado Com Sucesso!", resultado, MessageBoxButtons.OK,
            MessageBoxIcon.Asterisk);
        }
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
