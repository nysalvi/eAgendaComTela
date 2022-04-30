using System.Windows.Forms;
using Dominio.Compartilhado;
using Dominio;

namespace Apresentacao.WinApp.Contato
{
    public partial class TelaContato : Form
    {
        IRepositorio<Dominio.Contato> contatoRepositorio;
        public TelaContato(IRepositorio<Dominio.Contato> contatoRepositorio)
        {
            InitializeComponent();
            this.contatoRepositorio = contatoRepositorio;
        }


        private void buttonInserir_Click(object sender, System.EventArgs e)
        {
            Inserir inserir = new (contatoRepositorio);
            Hide();
            if (inserir.ShowDialog() == DialogResult.Cancel)
                Show();
        }
        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }   
}
