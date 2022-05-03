using System;
using System.Windows.Forms;
using Dominio;
using Dominio.Compartilhado;

namespace Apresentacao.WinApp.Compromissos
{
    public partial class Inserir : Form
    {
        Repositorio<Compromisso> compromissoRepositorio;
        Repositorio<Dominio.Contato> contatoRepositorio;
        public Inserir(Repositorio<Compromisso> compromissoRepositorio, Repositorio<Dominio.Contato> contatoRepositorio)
        {
            InitializeComponent();
            this.compromissoRepositorio = compromissoRepositorio;
            this.contatoRepositorio = contatoRepositorio;
            comboBox1.SelectedIndex = 0;
            //comboBox1.Items.Add();            
            contatoRepositorio.EntidadeList.ForEach(x =>
            {
                comboBox1.Items.Add(x);
            });
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            string assunto = textBoxAssunto.Text;
            string local = textBoxLocal.Text;
            DateTime data = DateTime.Parse(maskedTextBoxData.Text);
            TimeSpan? timespanInicio = 
                    maskedTextBoxHoraInicio.Text == "" ? null : TimeSpan.Parse(maskedTextBoxHoraInicio.Text);

            TimeSpan? timespanFinal = 
                    maskedTextBoxHoraFinal.Text == "" ? null : TimeSpan.Parse(maskedTextBoxHoraInicio.Text);
            
            Dominio.Contato contato = comboBox1.SelectedIndex == 0 ? null : (Dominio.Contato)comboBox1.SelectedItem;

            Compromisso c = new(assunto, local, data, timespanInicio!, timespanFinal!, contato);
            string resultado = c.Validar();
            if (resultado == "sucesso")
            {
                if (compromissoRepositorio.EntidadeList.Count > 0)
                {
                    Compromisso? compromissoConflitante = compromissoRepositorio.EntidadeList.Find(x=> c.Data == 
                    data.Date 
                    && ((c.HoraInicio > x.HoraInicio && c.HoraInicio < x.HoraTermino) 
                    || (c.HoraTermino < x.HoraTermino && c.HoraTermino > x.HoraInicio))
                    );
                    if (compromissoConflitante != null){
                        MessageBox.Show("Horário do Compromisso é conflitante com o de outros Compromissos!!!", 
                            "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                MessageBox.Show("Compromisso Adicionado Com Sucesso!!!", "SUCESSO", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);

                compromissoRepositorio.Inserir(c);
                textBoxAssunto.Clear();
                textBoxLocal.Clear();
                maskedTextBoxData.Clear();
                maskedTextBoxHoraInicio.Clear();
                maskedTextBoxHoraFinal.Clear();
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(resultado, "ERRO", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}
