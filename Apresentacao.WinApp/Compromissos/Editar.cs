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
            contatoRepositorio.ForEach = (x => comboBox1.Items.Add(x));
            
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Compromisso compromissoAntigo = compromissoRepositorio.Get(posicaoCompromisso);

            string assunto = textBoxAssunto.Text == "" ? compromissoAntigo.Assunto : textBoxAssunto.Text;
            string local = textBoxLocal.Text == "" ? compromissoAntigo.Local : textBoxLocal.Text;
            DateTime data = maskedTextBoxData.Text == "" ? compromissoAntigo.Data : 
                DateTime.Parse(maskedTextBoxData.Text);
            TimeSpan? horaInicio = (TimeSpan)
                (maskedTextBoxHoraInicio.Text == "" ? 
                compromissoAntigo.HoraInicio! : TimeSpan.Parse(maskedTextBoxHoraInicio.Text)!);

            TimeSpan horaFinal = (TimeSpan)(maskedTextBoxHoraFinal.Text == "" ?
                compromissoAntigo.HoraTermino! : TimeSpan.Parse(maskedTextBoxHoraInicio.Text)!);
            if (campoVazio())
            {
                MessageBox.Show("Pelo Menos Um Campo precisa Ser Editado!!!", "ATENÇÃO", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            Compromisso c = new(assunto, local, data, horaInicio, horaFinal, null);
            string resultado = c.Validar();

            Compromisso? compromissoConflitante = compromissoRepositorio.Find(x => c.Data == data.Date
            && ((c.HoraInicio > x.HoraInicio && c.HoraInicio < x.HoraTermino)
            || (c.HoraTermino < x.HoraTermino && c.HoraTermino > x.HoraInicio)));

            if (compromissoConflitante != null)
            {
                MessageBox.Show("Horário do Compromisso é conflitante com o de outros Compromissos!!!",
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (resultado == "sucesso")
            {
                compromissoRepositorio.Editar(c, posicaoCompromisso);
                MessageBox.Show("Cliente Editado Com Sucesso!!!", "SUCESSO", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                Close();
            }           
            MessageBox.Show(resultado, "ERRO", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        private bool campoVazio()
        {
            if (textBoxAssunto.Text == "" && textBoxLocal.Text == "")
            {
                if (maskedTextBoxData.Text == "" && maskedTextBoxHoraInicio.Text == "" && 
                    maskedTextBoxHoraFinal.Text == "")
                    return true;
            }
            return false;
        }
    }
}
