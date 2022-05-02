using System;
using Dominio;
using Dominio.Compartilhado;
using System.Windows.Forms;

namespace Apresentacao.WinApp.Compromissos
{
    public partial class Editar : Form
    {
        Repositorio<Compromisso> compromissoRepositorio;
        Repositorio<Dominio.Contato> contatoRepositorio;
        int posicaoCompromisso;
        public Editar(Repositorio<Compromisso> compromissoRepositorio, int posicaoCompromisso,
            Repositorio<Dominio.Contato> contatoRepositorio)
        {
            InitializeComponent();
            this.compromissoRepositorio = compromissoRepositorio;
            this.contatoRepositorio = contatoRepositorio;
            this.posicaoCompromisso = posicaoCompromisso;
        }
    }
}
