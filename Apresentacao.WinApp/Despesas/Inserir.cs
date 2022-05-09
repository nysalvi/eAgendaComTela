using System;
using Dominio;
using Dominio.Compartilhado;
using System.Windows.Forms;

namespace Apresentacao.WinApp.Despesas
{
    public partial class Inserir : Form
    {
        Repositorio<Despesa> despesaRepositorio;
        public Inserir(Repositorio<Despesa> despesaRepositorio)
        {
            InitializeComponent();
            this.despesaRepositorio = despesaRepositorio;

            FormaPagamentos[] formaPagamentos = new FormaPagamentos[] { FormaPagamentos.Dinheiro, 
                FormaPagamentos.Pix};
            //comboBox1.Items.AddRange(formaPagamentos) ;
        }
    }
}
