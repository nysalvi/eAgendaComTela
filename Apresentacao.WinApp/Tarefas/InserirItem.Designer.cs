namespace Apresentacao.WinApp.Tarefas
{
    partial class InserirItem
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
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelConcluido = new System.Windows.Forms.Label();
            this.buttonCriar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(46, 28);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(61, 15);
            this.labelDescricao.TabIndex = 0;
            this.labelDescricao.Text = "Descrição:";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(160, 28);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(149, 23);
            this.textBoxDescricao.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nao",
            "Sim"});
            this.comboBox1.Location = new System.Drawing.Point(160, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // labelConcluido
            // 
            this.labelConcluido.AutoSize = true;
            this.labelConcluido.Location = new System.Drawing.Point(46, 106);
            this.labelConcluido.Name = "labelConcluido";
            this.labelConcluido.Size = new System.Drawing.Size(68, 15);
            this.labelConcluido.TabIndex = 3;
            this.labelConcluido.Text = "Concluído: ";
            // 
            // buttonCriar
            // 
            this.buttonCriar.Location = new System.Drawing.Point(46, 153);
            this.buttonCriar.Name = "buttonCriar";
            this.buttonCriar.Size = new System.Drawing.Size(110, 44);
            this.buttonCriar.TabIndex = 4;
            this.buttonCriar.Text = "Criar";
            this.buttonCriar.UseVisualStyleBackColor = true;
            this.buttonCriar.Click += new System.EventHandler(this.buttonCriar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(199, 153);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(110, 44);
            this.buttonVoltar.TabIndex = 5;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // InserirItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 224);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonCriar);
            this.Controls.Add(this.labelConcluido);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.labelDescricao);
            this.Name = "InserirItem";
            this.Text = "InserirItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelConcluido;
        private System.Windows.Forms.Button buttonCriar;
        private System.Windows.Forms.Button buttonVoltar;
    }
}