namespace Apresentacao.WinApp.Compromissos
{
    partial class Inserir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelHorarioFinal = new System.Windows.Forms.Label();
            this.labelHorarioInicial = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelLocal = new System.Windows.Forms.Label();
            this.labelAssunto = new System.Windows.Forms.Label();
            this.labelContato = new System.Windows.Forms.Label();
            this.textBoxAssunto = new System.Windows.Forms.TextBox();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.buttonCriar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.contatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHoraFinal = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHorarioFinal
            // 
            this.labelHorarioFinal.AutoSize = true;
            this.labelHorarioFinal.Location = new System.Drawing.Point(43, 209);
            this.labelHorarioFinal.Name = "labelHorarioFinal";
            this.labelHorarioFinal.Size = new System.Drawing.Size(78, 15);
            this.labelHorarioFinal.TabIndex = 9;
            this.labelHorarioFinal.Text = "Horário Final:";
            // 
            // labelHorarioInicial
            // 
            this.labelHorarioInicial.AutoSize = true;
            this.labelHorarioInicial.Location = new System.Drawing.Point(43, 164);
            this.labelHorarioInicial.Name = "labelHorarioInicial";
            this.labelHorarioInicial.Size = new System.Drawing.Size(84, 15);
            this.labelHorarioInicial.TabIndex = 8;
            this.labelHorarioInicial.Text = "Horário Inicial:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(43, 122);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(37, 15);
            this.labelData.TabIndex = 7;
            this.labelData.Text = "Data: ";
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Location = new System.Drawing.Point(43, 75);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(41, 15);
            this.labelLocal.TabIndex = 6;
            this.labelLocal.Text = "Local: ";
            // 
            // labelAssunto
            // 
            this.labelAssunto.AutoSize = true;
            this.labelAssunto.Location = new System.Drawing.Point(43, 30);
            this.labelAssunto.Name = "labelAssunto";
            this.labelAssunto.Size = new System.Drawing.Size(56, 15);
            this.labelAssunto.TabIndex = 5;
            this.labelAssunto.Text = "Assunto: ";
            // 
            // labelContato
            // 
            this.labelContato.AutoSize = true;
            this.labelContato.Location = new System.Drawing.Point(43, 249);
            this.labelContato.Name = "labelContato";
            this.labelContato.Size = new System.Drawing.Size(56, 15);
            this.labelContato.TabIndex = 10;
            this.labelContato.Text = "Contato: ";
            // 
            // textBoxAssunto
            // 
            this.textBoxAssunto.Location = new System.Drawing.Point(155, 27);
            this.textBoxAssunto.Name = "textBoxAssunto";
            this.textBoxAssunto.Size = new System.Drawing.Size(356, 23);
            this.textBoxAssunto.TabIndex = 0;
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Location = new System.Drawing.Point(155, 71);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(356, 23);
            this.textBoxLocal.TabIndex = 1;
            // 
            // buttonCriar
            // 
            this.buttonCriar.Location = new System.Drawing.Point(367, 246);
            this.buttonCriar.Name = "buttonCriar";
            this.buttonCriar.Size = new System.Drawing.Size(94, 49);
            this.buttonCriar.TabIndex = 6;
            this.buttonCriar.Text = "Criar";
            this.buttonCriar.UseVisualStyleBackColor = true;
            this.buttonCriar.Click += new System.EventHandler(this.buttonCriar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(367, 325);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(94, 49);
            this.buttonVoltar.TabIndex = 7;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sem Contato"});
            this.comboBox1.Location = new System.Drawing.Point(155, 246);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // contatoBindingSource
            // 
            this.contatoBindingSource.DataSource = typeof(Dominio.Contato);
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Location = new System.Drawing.Point(155, 119);
            this.maskedTextBoxData.Mask = "00/00/0000";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.Size = new System.Drawing.Size(356, 23);
            this.maskedTextBoxData.TabIndex = 2;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxHoraInicio
            // 
            this.maskedTextBoxHoraInicio.Location = new System.Drawing.Point(155, 161);
            this.maskedTextBoxHoraInicio.Mask = "00:00";
            this.maskedTextBoxHoraInicio.Name = "maskedTextBoxHoraInicio";
            this.maskedTextBoxHoraInicio.Size = new System.Drawing.Size(356, 23);
            this.maskedTextBoxHoraInicio.TabIndex = 3;
            this.maskedTextBoxHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxHoraFinal
            // 
            this.maskedTextBoxHoraFinal.Location = new System.Drawing.Point(155, 206);
            this.maskedTextBoxHoraFinal.Mask = "00:00";
            this.maskedTextBoxHoraFinal.Name = "maskedTextBoxHoraFinal";
            this.maskedTextBoxHoraFinal.Size = new System.Drawing.Size(356, 23);
            this.maskedTextBoxHoraFinal.TabIndex = 4;
            this.maskedTextBoxHoraFinal.ValidatingType = typeof(System.DateTime);
            // 
            // Inserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 429);
            this.Controls.Add(this.maskedTextBoxHoraFinal);
            this.Controls.Add(this.maskedTextBoxHoraInicio);
            this.Controls.Add(this.maskedTextBoxData);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonCriar);
            this.Controls.Add(this.textBoxLocal);
            this.Controls.Add(this.textBoxAssunto);
            this.Controls.Add(this.labelContato);
            this.Controls.Add(this.labelHorarioFinal);
            this.Controls.Add(this.labelHorarioInicial);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.labelAssunto);
            this.Name = "Inserir";
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHorarioFinal;
        private System.Windows.Forms.Label labelHorarioInicial;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.Label labelAssunto;
        private System.Windows.Forms.Label labelContato;
        private System.Windows.Forms.TextBox textBoxAssunto;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.Button buttonCriar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource contatoBindingSource;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraInicio;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraFinal;
    }
}