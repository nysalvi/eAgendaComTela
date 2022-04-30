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
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }   
}
