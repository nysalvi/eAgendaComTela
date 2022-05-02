namespace Apresentacao.WinApp.Contatos
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.labelCargo = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.textBoxEmpresa = new System.Windows.Forms.TextBox();
            this.textBoxCargo = new System.Windows.Forms.TextBox();
            this.buttonCriar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(62, 45);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(46, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome: ";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(62, 99);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(47, 15);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "E-Mail: ";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(62, 158);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(57, 15);
            this.labelTelefone.TabIndex = 2;
            this.labelTelefone.Text = "Telefone: ";
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.Location = new System.Drawing.Point(62, 216);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(58, 15);
            this.labelEmpresa.TabIndex = 3;
            this.labelEmpresa.Text = "Empresa: ";
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Location = new System.Drawing.Point(62, 267);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(45, 15);
            this.labelCargo.TabIndex = 4;
            this.labelCargo.Text = "Cargo: ";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(125, 45);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(244, 23);
            this.textBoxNome.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(125, 96);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(244, 23);
            this.textBoxEmail.TabIndex = 6;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(125, 155);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(244, 23);
            this.textBoxTelefone.TabIndex = 7;
            // 
            // textBoxEmpresa
            // 
            this.textBoxEmpresa.Location = new System.Drawing.Point(125, 213);
            this.textBoxEmpresa.Name = "textBoxEmpresa";
            this.textBoxEmpresa.PlaceholderText = "(opcional)...";
            this.textBoxEmpresa.Size = new System.Drawing.Size(244, 23);
            this.textBoxEmpresa.TabIndex = 8;
            // 
            // textBoxCargo
            // 
            this.textBoxCargo.Location = new System.Drawing.Point(125, 264);
            this.textBoxCargo.Name = "textBoxCargo";
            this.textBoxCargo.PlaceholderText = "(opcional)...";
            this.textBoxCargo.Size = new System.Drawing.Size(244, 23);
            this.textBoxCargo.TabIndex = 9;
            // 
            // buttonCriar
            // 
            this.buttonCriar.Location = new System.Drawing.Point(145, 318);
            this.buttonCriar.Name = "buttonCriar";
            this.buttonCriar.Size = new System.Drawing.Size(75, 41);
            this.buttonCriar.TabIndex = 10;
            this.buttonCriar.Text = "Criar";
            this.buttonCriar.UseVisualStyleBackColor = true;
            this.buttonCriar.Click += new System.EventHandler(this.buttonCriar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(305, 318);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 41);
            this.buttonVoltar.TabIndex = 11;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // Inserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 371);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonCriar);
            this.Controls.Add(this.textBoxCargo);
            this.Controls.Add(this.textBoxEmpresa);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.labelEmpresa);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNome);
            this.Name = "Inserir";
            this.Text = "Inserir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.TextBox textBoxEmpresa;
        private System.Windows.Forms.TextBox textBoxCargo;
        private System.Windows.Forms.Button buttonCriar;
        private System.Windows.Forms.Button buttonVoltar;
    }
}