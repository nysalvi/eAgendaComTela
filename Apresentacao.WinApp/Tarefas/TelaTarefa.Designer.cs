namespace Apresentacao.WinApp.Tarefas
{
    partial class TelaTarefa
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
            this.columnHeaderTarefa = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPrioridade = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDataCriacao = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDataDevolucao = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPercentual = new System.Windows.Forms.ColumnHeader();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonConcluidas = new System.Windows.Forms.Button();
            this.buttonAdicionarItem = new System.Windows.Forms.Button();
            this.buttonAtualizarItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderTarefa,
            this.columnHeaderPrioridade,
            this.columnHeaderDataCriacao,
            this.columnHeaderDataDevolucao,
            this.columnHeaderPercentual});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(568, 283);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderTarefa
            // 
            this.columnHeaderTarefa.Text = "Título: ";
            this.columnHeaderTarefa.Width = 120;
            // 
            // columnHeaderPrioridade
            // 
            this.columnHeaderPrioridade.Text = "Prioridade:";
            this.columnHeaderPrioridade.Width = 80;
            // 
            // columnHeaderDataCriacao
            // 
            this.columnHeaderDataCriacao.Text = "Data de Criação:";
            this.columnHeaderDataCriacao.Width = 100;
            // 
            // columnHeaderDataDevolucao
            // 
            this.columnHeaderDataDevolucao.Text = "Data de Devolução:";
            this.columnHeaderDataDevolucao.Width = 100;
            // 
            // columnHeaderPercentual
            // 
            this.columnHeaderPercentual.Text = "Concluído(%)";
            this.columnHeaderPercentual.Width = 100;
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(606, 12);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(97, 39);
            this.buttonInserir.TabIndex = 1;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(606, 282);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(97, 39);
            this.buttonFechar.TabIndex = 2;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(606, 57);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(97, 39);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(606, 102);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(97, 39);
            this.buttonExcluir.TabIndex = 4;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonConcluidas
            // 
            this.buttonConcluidas.Location = new System.Drawing.Point(606, 147);
            this.buttonConcluidas.Name = "buttonConcluidas";
            this.buttonConcluidas.Size = new System.Drawing.Size(97, 39);
            this.buttonConcluidas.TabIndex = 5;
            this.buttonConcluidas.Text = "Concluidas";
            this.buttonConcluidas.UseVisualStyleBackColor = true;
            this.buttonConcluidas.Click += new System.EventHandler(this.buttonConcluidas_Click);
            // 
            // buttonAdicionarItem
            // 
            this.buttonAdicionarItem.Location = new System.Drawing.Point(606, 192);
            this.buttonAdicionarItem.Name = "buttonAdicionarItem";
            this.buttonAdicionarItem.Size = new System.Drawing.Size(97, 39);
            this.buttonAdicionarItem.TabIndex = 6;
            this.buttonAdicionarItem.Text = "Adicionar Item";
            this.buttonAdicionarItem.UseVisualStyleBackColor = true;
            this.buttonAdicionarItem.Click += new System.EventHandler(this.buttonAdicionarItem_Click);
            // 
            // buttonAtualizarItem
            // 
            this.buttonAtualizarItem.Location = new System.Drawing.Point(606, 237);
            this.buttonAtualizarItem.Name = "buttonAtualizarItem";
            this.buttonAtualizarItem.Size = new System.Drawing.Size(97, 39);
            this.buttonAtualizarItem.TabIndex = 7;
            this.buttonAtualizarItem.Text = "Atualizar Item";
            this.buttonAtualizarItem.UseVisualStyleBackColor = true;
            this.buttonAtualizarItem.Click += new System.EventHandler(this.buttonAtualizarItem_Click);
            // 
            // TelaTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 332);
            this.Controls.Add(this.buttonAtualizarItem);
            this.Controls.Add(this.buttonAdicionarItem);
            this.Controls.Add(this.buttonConcluidas);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.listView1);
            this.Name = "TelaTarefa";
            this.Text = "TelaTarefa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.ColumnHeader columnHeaderTarefa;
        private System.Windows.Forms.ColumnHeader columnHeaderPrioridade;
        private System.Windows.Forms.ColumnHeader columnHeaderDataCriacao;
        private System.Windows.Forms.ColumnHeader columnHeaderDataDevolucao;
        private System.Windows.Forms.ColumnHeader columnHeaderPercentual;
        private System.Windows.Forms.Button buttonConcluidas;
        private System.Windows.Forms.Button buttonAdicionarItem;
        private System.Windows.Forms.Button buttonAtualizarItem;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
    }
}