namespace Apresentacao.WinApp.Tarefas
{
    partial class EditarItem
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
            this.labelConcluido = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.comboBoxConcluido = new System.Windows.Forms.ComboBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonCriar = new System.Windows.Forms.Button();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.labelItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelConcluido
            // 
            this.labelConcluido.AutoSize = true;
            this.labelConcluido.Location = new System.Drawing.Point(41, 158);
            this.labelConcluido.Name = "labelConcluido";
            this.labelConcluido.Size = new System.Drawing.Size(68, 15);
            this.labelConcluido.TabIndex = 5;
            this.labelConcluido.Text = "Concluído: ";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(41, 81);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(61, 15);
            this.labelDescricao.TabIndex = 4;
            this.labelDescricao.Text = "Descrição:";
            // 
            // comboBoxConcluido
            // 
            this.comboBoxConcluido.FormattingEnabled = true;
            this.comboBoxConcluido.Items.AddRange(new object[] {
            "Nao",
            "Sim"});
            this.comboBoxConcluido.Location = new System.Drawing.Point(191, 150);
            this.comboBoxConcluido.Name = "comboBoxConcluido";
            this.comboBoxConcluido.Size = new System.Drawing.Size(121, 23);
            this.comboBoxConcluido.TabIndex = 7;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(163, 81);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(149, 23);
            this.textBoxDescricao.TabIndex = 6;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(202, 229);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(110, 44);
            this.buttonVoltar.TabIndex = 9;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonCriar
            // 
            this.buttonCriar.Location = new System.Drawing.Point(34, 229);
            this.buttonCriar.Name = "buttonCriar";
            this.buttonCriar.Size = new System.Drawing.Size(110, 44);
            this.buttonCriar.TabIndex = 8;
            this.buttonCriar.Text = "Criar";
            this.buttonCriar.UseVisualStyleBackColor = true;
            this.buttonCriar.Click += new System.EventHandler(this.buttonCriar_Click);
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(191, 26);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(121, 23);
            this.comboBoxItem.TabIndex = 10;
            this.comboBoxItem.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(41, 26);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(37, 15);
            this.labelItem.TabIndex = 11;
            this.labelItem.Text = "Item: ";
            // 
            // EditarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 359);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonCriar);
            this.Controls.Add(this.comboBoxConcluido);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.labelConcluido);
            this.Controls.Add(this.labelDescricao);
            this.Name = "EditarItem";
            this.Text = "EditarItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConcluido;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.ComboBox comboBoxConcluido;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonCriar;
        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.Label labelItem;
    }
}