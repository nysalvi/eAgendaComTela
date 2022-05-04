using Dominio.Compartilhado;
using Dominio;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Apresentacao.WinApp.Tarefas
{
    public partial class TelaTarefa : Form
    {
        Repositorio<Tarefa> tarefaRepositorio;
        int totalTarefas;
        public TelaTarefa(Repositorio<Tarefa> tarefaRepositorio)
        {
            InitializeComponent();
            this.tarefaRepositorio = tarefaRepositorio;
            this.totalTarefas = tarefaRepositorio.Count;
            AdicionarLinha(true);
        }

        private void buttonInserir_Click(object sender, System.EventArgs e)
        {
            Inserir inserir = new(tarefaRepositorio);
            Hide();
            if (inserir.ShowDialog() == DialogResult.Cancel)
            {
                Show();
                AdicionarLinha(false);
            }
        }
        private void AdicionarLinha(bool adicionarListaCompleta)
        {
            if (tarefaRepositorio.Count == 0)
                return;
            int i = adicionarListaCompleta ? 0 : totalTarefas;

            while (i < tarefaRepositorio.Count)
            {
                ListViewItem coluna = new("" + i);

                coluna.SubItems.Add(tarefaRepositorio.Get(i).Titulo);
                coluna.SubItems.Add(tarefaRepositorio.Get(i).Prioridade.ToString());
                coluna.SubItems.Add(tarefaRepositorio.Get(i).Criacao.ToString());
                coluna.SubItems.Add(tarefaRepositorio.Get(i).Conclusao.ToString());
                coluna.SubItems.Add(tarefaRepositorio.Get(i).Percentual.ToString());

                listView1.Items.Add(coluna);
                i++;
            }
            totalTarefas = tarefaRepositorio.Count;
        }

        private void buttonFechar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void buttonEditar_Click(object sender, System.EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lista Vazia", "ATENÇÃO", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(listView1.SelectedItems[0].Text, out int posicao))
            {
                MessageBox.Show("Seleção Inválida", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Hide();
            Editar editar = new(tarefaRepositorio, posicao);
            if (editar.ShowDialog() == DialogResult.Cancel)
            {
                editarLinha(posicao);
                Show();
            }            
        }
        private void editarLinha(int posicao)
        {
            ListViewItem coluna = listView1.SelectedItems[0];
            Tarefa tarefa = tarefaRepositorio.Get(posicao);
            coluna.SubItems[1].Text = tarefa.Titulo;
            coluna.SubItems[2].Text = tarefa.Prioridade.ToString();
            coluna.SubItems[3].Text = tarefa.Criacao.ToString();
            coluna.SubItems[4].Text = tarefa.Conclusao.ToString();
            coluna.SubItems[5].Text = tarefa.Percentual.ToString();
        }

        private void buttonExcluir_Click(object sender, System.EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nenhum Item Selecionado", "ATENÇÃO", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(listView1.SelectedItems[0].Text, out int posicao))
            {
                MessageBox.Show("Seleção Inválida", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Tarefa? tarefa = tarefaRepositorio.Find(x => x.Numero == posicao);

            if (tarefa.Percentual < 100)
            {
                MessageBox.Show("Você não Pode Deletar Tarefas que não estejam Concluídas", "ERRO", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ListViewItem coluna = listView1.SelectedItems[0];
            listView1.Items.Remove(coluna);
            tarefaRepositorio.Excluir(tarefa!);
        }

        private void buttonConcluidas_Click(object sender, System.EventArgs e)
        {
            string filtro = buttonConcluidas.Text == "Concluidas" ? 
                "Pendentes" : buttonConcluidas.Text == "Pendentes" ? 
                "Todos" : "Concluidas";
            buttonConcluidas.Text = filtro;

            List<Tarefa> copia;
            if (filtro == "Concluidas")
                copia = new List<Tarefa>(tarefaRepositorio.GetAll.OrderBy(x => x.Percentual == 100)
                    .ThenBy(x => x.Prioridade));
            else if (filtro == "Pendentes")
                copia = new List<Tarefa>(tarefaRepositorio.GetAll.OrderBy(x => x.Percentual < 100)
                    .ThenBy(x => x.Prioridade));
            else
                copia = new (tarefaRepositorio.GetAll.OrderBy(x => x.Prioridade));

            LoadListView(copia);

        }

        private void buttonAdicionarItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nenhum Item Selecionado", "ATENÇÃO", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(listView1.SelectedItems[0].Text, out int posicao))
            {
                MessageBox.Show("Seleção Inválida", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Tarefa? tarefa = tarefaRepositorio.Find(x => x.Numero == posicao);

            InserirItem item = new InserirItem(tarefa);
            if (item.ShowDialog() == DialogResult.Cancel)
            {
                tarefa.AtualizaPorcentagem();
                editarLinha(listView1.SelectedIndices[0]);
                Show();
            }
        }
        private void LoadListView(List<Tarefa> copia)
        {
            listView1.Items.Clear();
            foreach (Tarefa t in copia)
            {
                ListViewItem coluna = new("" + t.Numero);

                coluna.SubItems.Add(t.Titulo);
                coluna.SubItems.Add(t.Prioridade.ToString());
                coluna.SubItems.Add(t.Criacao.ToString());
                coluna.SubItems.Add(t.Criacao.ToString());
                coluna.SubItems.Add(t.Percentual.ToString());

                listView1.Items.Add(coluna);
            }
        }

        private void buttonAtualizarItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nenhum Item Selecionado", "ATENÇÃO", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(listView1.SelectedItems[0].Text, out int posicao))
            {
                MessageBox.Show("Seleção Inválida", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Tarefa? tarefa = tarefaRepositorio.Find(x => x.Numero == posicao);

            EditarItem editar = new EditarItem(tarefa);
            Hide();
            if (editar.ShowDialog() == DialogResult.Cancel)
            {
                tarefa.AtualizaPorcentagem();
                editarLinha(posicao);
                Show();
            }

        }
    }
}
