using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.WinApp.Contato    
{
    public partial class Inserir : Form
    {
        public Inserir()
        {
            InitializeComponent();      
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
