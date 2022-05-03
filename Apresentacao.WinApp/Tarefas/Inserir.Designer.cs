namespace Apresentacao.WinApp.Tarefas
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
            this.buttonCriar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.labelPrioridade = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.comboBoxPrioridade = new System.Windows.Forms.ComboBox();
            this.labelDataCriacao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxCriacao = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxConclusao = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // buttonCriar
            // 
            this.buttonCriar.Location = new System.Drawing.Point(64, 276);
            this.buttonCriar.Name = "buttonCriar";
            this.buttonCriar.Size = new System.Drawing.Size(100, 48);
            this.buttonCriar.TabIndex = 0;
            this.buttonCriar.Text = "Criar";
            this.buttonCriar.UseVisualStyleBackColor = true;
            this.buttonCriar.Click += new System.EventHandler(this.buttonCriar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(265, 276);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(100, 48);
            this.buttonVoltar.TabIndex = 1;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(194, 18);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(171, 23);
            this.textBoxTitulo.TabIndex = 2;
            // 
            // labelPrioridade
            // 
            this.labelPrioridade.AutoSize = true;
            this.labelPrioridade.Location = new System.Drawing.Point(64, 73);
            this.labelPrioridade.Name = "labelPrioridade";
            this.labelPrioridade.Size = new System.Drawing.Size(67, 15);
            this.labelPrioridade.TabIndex = 3;
            this.labelPrioridade.Text = "Prioridade: ";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(64, 18);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(43, 15);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Título: ";
            // 
            // comboBoxPrioridade
            // 
            this.comboBoxPrioridade.FormattingEnabled = true;
            this.comboBoxPrioridade.Items.AddRange(new object[] {
            "Alta",
            "Média",
            "Baixa"});
            this.comboBoxPrioridade.Location = new System.Drawing.Point(237, 73);
            this.comboBoxPrioridade.Name = "comboBoxPrioridade";
            this.comboBoxPrioridade.Size = new System.Drawing.Size(128, 23);
            this.comboBoxPrioridade.TabIndex = 5;
            // 
            // labelDataCriacao
            // 
            this.labelDataCriacao.AutoSize = true;
            this.labelDataCriacao.Location = new System.Drawing.Point(64, 127);
            this.labelDataCriacao.Name = "labelDataCriacao";
            this.labelDataCriacao.Size = new System.Drawing.Size(96, 15);
            this.labelDataCriacao.TabIndex = 6;
            this.labelDataCriacao.Text = "Data de Criação: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data de Conclusão: ";
            // 
            // maskedTextBoxCriacao
            // 
            this.maskedTextBoxCriacao.Location = new System.Drawing.Point(194, 127);
            this.maskedTextBoxCriacao.Name = "maskedTextBoxCriacao";
            this.maskedTextBoxCriacao.Size = new System.Drawing.Size(171, 23);
            this.maskedTextBoxCriacao.TabIndex = 8;
            // 
            // maskedTextBoxConclusao
            // 
            this.maskedTextBoxConclusao.Location = new System.Drawing.Point(194, 188);
            this.maskedTextBoxConclusao.Name = "maskedTextBoxConclusao";
            this.maskedTextBoxConclusao.Size = new System.Drawing.Size(171, 23);
            this.maskedTextBoxConclusao.TabIndex = 9;
            // 
            // Inserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 382);
            this.Controls.Add(this.maskedTextBoxConclusao);
            this.Controls.Add(this.maskedTextBoxCriacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDataCriacao);
            this.Controls.Add(this.comboBoxPrioridade);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelPrioridade);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonCriar);
            this.Name = "Inserir";
            this.Text = "Inserir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCriar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label labelPrioridade;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.ComboBox comboBoxPrioridade;
        private System.Windows.Forms.Label labelDataCriacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCriacao;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxConclusao;
    }
}