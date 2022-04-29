namespace eAgendaComTela.WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTarefa = new System.Windows.Forms.Button();
            this.buttonContato = new System.Windows.Forms.Button();
            this.buttonCompromisso = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTarefa
            // 
            this.buttonTarefa.Location = new System.Drawing.Point(130, 27);
            this.buttonTarefa.Name = "buttonTarefa";
            this.buttonTarefa.Size = new System.Drawing.Size(92, 40);
            this.buttonTarefa.TabIndex = 0;
            this.buttonTarefa.Text = "Tarefa";
            this.buttonTarefa.UseVisualStyleBackColor = true;
            this.buttonTarefa.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonContato
            // 
            this.buttonContato.Location = new System.Drawing.Point(130, 97);
            this.buttonContato.Name = "buttonContato";
            this.buttonContato.Size = new System.Drawing.Size(92, 40);
            this.buttonContato.TabIndex = 1;
            this.buttonContato.Text = "Contato";
            this.buttonContato.UseVisualStyleBackColor = true;
            // 
            // buttonCompromisso
            // 
            this.buttonCompromisso.Location = new System.Drawing.Point(130, 163);
            this.buttonCompromisso.Name = "buttonCompromisso";
            this.buttonCompromisso.Size = new System.Drawing.Size(92, 40);
            this.buttonCompromisso.TabIndex = 2;
            this.buttonCompromisso.Text = "Compromisso";
            this.buttonCompromisso.UseVisualStyleBackColor = true;
            this.buttonCompromisso.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(130, 234);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(92, 40);
            this.buttonSair.TabIndex = 3;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 308);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonCompromisso);
            this.Controls.Add(this.buttonContato);
            this.Controls.Add(this.buttonTarefa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTarefa;
        private System.Windows.Forms.Button buttonContato;
        private System.Windows.Forms.Button buttonCompromisso;
        private System.Windows.Forms.Button buttonSair;
    }
}
