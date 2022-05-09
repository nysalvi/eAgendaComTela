namespace Apresentacao.WinApp.Despesas
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
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelFormaPagamento = new System.Windows.Forms.Label();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxValor = new System.Windows.Forms.MaskedTextBox();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(81, 45);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(64, 15);
            this.labelDescricao.TabIndex = 0;
            this.labelDescricao.Text = "Descrição: ";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(81, 106);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(37, 15);
            this.labelData.TabIndex = 1;
            this.labelData.Text = "Data: ";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(81, 167);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(61, 15);
            this.labelCategoria.TabIndex = 2;
            this.labelCategoria.Text = "Categoria:";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(81, 228);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(36, 15);
            this.labelValor.TabIndex = 2;
            this.labelValor.Text = "Valor:";
            // 
            // labelFormaPagamento
            // 
            this.labelFormaPagamento.AutoSize = true;
            this.labelFormaPagamento.Location = new System.Drawing.Point(81, 289);
            this.labelFormaPagamento.Name = "labelFormaPagamento";
            this.labelFormaPagamento.Size = new System.Drawing.Size(124, 15);
            this.labelFormaPagamento.TabIndex = 3;
            this.labelFormaPagamento.Text = "Forma de Pagamento:";
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Location = new System.Drawing.Point(240, 103);
            this.maskedTextBoxData.Mask = "00/00/0000";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.Size = new System.Drawing.Size(141, 23);
            this.maskedTextBoxData.TabIndex = 4;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxValor
            // 
            this.maskedTextBoxValor.Location = new System.Drawing.Point(240, 225);
            this.maskedTextBoxValor.Mask = "00000,00";
            this.maskedTextBoxValor.Name = "maskedTextBoxValor";
            this.maskedTextBoxValor.Size = new System.Drawing.Size(141, 23);
            this.maskedTextBoxValor.TabIndex = 5;
            this.maskedTextBoxValor.ValidatingType = typeof(int);
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(240, 159);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(141, 23);
            this.textBoxCategoria.TabIndex = 6;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(240, 42);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(141, 23);
            this.textBoxDescricao.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(260, 289);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 8;
            // 
            // Inserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.maskedTextBoxValor);
            this.Controls.Add(this.maskedTextBoxData);
            this.Controls.Add(this.labelFormaPagamento);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelDescricao);
            this.Name = "Inserir";
            this.Text = "Inserir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelFormaPagamento;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValor;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}