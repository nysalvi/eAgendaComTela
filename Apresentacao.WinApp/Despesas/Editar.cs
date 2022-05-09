using Dominio;
using Dominio.Compartilhado;

using System.Windows.Forms;

namespace Apresentacao.WinApp.Despesas
{
    public partial class Editar : Form
    {
        Repositorio<Despesa> despesaRepositorio;
        public Editar(Repositorio<Despesa> despesaRepositorio)
        {
            InitializeComponent();
            this.despesaRepositorio = despesaRepositorio;
        }
    }
}
