namespace Apresentacao.WinApp.Despesas
{
    partial class TelaDespesa
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderID = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDescricao = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderData = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCategoria = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderValor = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderFormaPagamento = new System.Windows.Forms.ColumnHeader();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonGastoPorMes = new System.Windows.Forms.Button();
            this.buttonGastoPorCategoria = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderDescricao,
            this.columnHeaderData,
            this.columnHeaderCategoria,
            this.columnHeaderValor,
            this.columnHeaderFormaPagamento});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(34, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(738, 332);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID: ";
            this.columnHeaderID.Width = 50;
            // 
            // columnHeaderDescricao
            // 
            this.columnHeaderDescricao.Text = "Descrição: ";
            this.columnHeaderDescricao.Width = 100;
            // 
            // columnHeaderData
            // 
            this.columnHeaderData.Text = "Data: ";
            this.columnHeaderData.Width = 100;
            // 
            // columnHeaderCategoria
            // 
            this.columnHeaderCategoria.Text = "Categoria: ";
            this.columnHeaderCategoria.Width = 110;
            // 
            // columnHeaderValor
            // 
            this.columnHeaderValor.Text = "Valor: ";
            this.columnHeaderValor.Width = 100;
            // 
            // columnHeaderFormaPagamento
            // 
            this.columnHeaderFormaPagamento.Text = "Forma de Pagamento:";
            this.columnHeaderFormaPagamento.Width = 130;
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(104, 24);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(100, 43);
            this.buttonInserir.TabIndex = 1;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(231, 24);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(100, 43);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(358, 24);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(100, 43);
            this.buttonExcluir.TabIndex = 3;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonGastoPorMes
            // 
            this.buttonGastoPorMes.Location = new System.Drawing.Point(485, 24);
            this.buttonGastoPorMes.Name = "buttonGastoPorMes";
            this.buttonGastoPorMes.Size = new System.Drawing.Size(100, 43);
            this.buttonGastoPorMes.TabIndex = 4;
            this.buttonGastoPorMes.Text = "Gasto Por Mês";
            this.buttonGastoPorMes.UseVisualStyleBackColor = true;
            this.buttonGastoPorMes.Click += new System.EventHandler(this.buttonGastoPorMes_Click);
            // 
            // buttonGastoPorCategoria
            // 
            this.buttonGastoPorCategoria.Location = new System.Drawing.Point(612, 24);
            this.buttonGastoPorCategoria.Name = "buttonGastoPorCategoria";
            this.buttonGastoPorCategoria.Size = new System.Drawing.Size(100, 43);
            this.buttonGastoPorCategoria.TabIndex = 5;
            this.buttonGastoPorCategoria.Text = "Gasto Por Categoria";
            this.buttonGastoPorCategoria.UseVisualStyleBackColor = true;
            this.buttonGastoPorCategoria.Click += new System.EventHandler(this.buttonGastoPorCategoria_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(347, 411);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(100, 43);
            this.buttonFechar.TabIndex = 6;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // TelaDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonGastoPorCategoria);
            this.Controls.Add(this.buttonGastoPorMes);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.listView1);
            this.Name = "TelaDespesa";
            this.Text = "TelaDespesa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.ColumnHeader columnHeaderDescricao;
        private System.Windows.Forms.ColumnHeader columnHeaderData;
        private System.Windows.Forms.ColumnHeader columnHeaderCategoria;
        private System.Windows.Forms.ColumnHeader columnHeaderValor;
        private System.Windows.Forms.ColumnHeader columnHeaderFormaPagamento;
        private System.Windows.Forms.Button buttonGastoPorMes;
        private System.Windows.Forms.Button buttonGastoPorCategoria;
        private System.Windows.Forms.Button buttonFechar;
    }
}