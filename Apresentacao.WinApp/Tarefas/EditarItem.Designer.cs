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
            this.buttonEditar = new System.Windows.Forms.Button();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.labelItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelConcluido
            // 
            this.labelConcluido.AutoSize = true;
            this.labelConcluido.Location = new System.Drawing.Point(41, 128);
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
            this.comboBoxConcluido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConcluido.FormattingEnabled = true;
            this.comboBoxConcluido.Items.AddRange(new object[] {
            "Sim",
            "Nao"});
            this.comboBoxConcluido.Location = new System.Drawing.Point(202, 128);
            this.comboBoxConcluido.Name = "comboBoxConcluido";
            this.comboBoxConcluido.Size = new System.Drawing.Size(137, 23);
            this.comboBoxConcluido.TabIndex = 2;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(108, 78);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(231, 23);
            this.textBoxDescricao.TabIndex = 1;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(202, 184);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(110, 44);
            this.buttonVoltar.TabIndex = 4;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(41, 184);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(110, 44);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "Editar: ";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(84, 23);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(255, 23);
            this.comboBoxItem.TabIndex = 0;
            this.comboBoxItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxItem_SelectedIndexChanged);
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
            this.ClientSize = new System.Drawing.Size(351, 264);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonEditar);
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
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.Label labelItem;
    }
}