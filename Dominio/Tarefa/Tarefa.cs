using System;
using System.Collections.Generic;
using Dominio.Compartilhado;

namespace Dominio
{
    public class Tarefa : Entidade
    {
        public Tarefa() 
        {

        }
        public static int total;
        public enum PRIORIDADE {Alta, Media, Baixa}
        public override int Total { get { return total; } set { total = value; } }

        public Repositorio<Item> itens;
        public int NumeroItem { get; set; }
        public string Titulo { get; set; }
        private int _Prioridade { get; set; }
        private DateTime? conclusao;
        public PRIORIDADE Prioridade { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime? Conclusao { 
            get {
                return conclusao;
            } set { conclusao = value; } 
        }
        public decimal Percentual { get; set; }

        public Tarefa(string titulo, DateTime criacao, PRIORIDADE prioridade)
        {
            itens = new Repositorio<Item>();
            Titulo = titulo;
            _Prioridade = prioridade == PRIORIDADE.Alta ? 0 : prioridade == PRIORIDADE.Media ? 1 : 2;
            Prioridade = prioridade;
            Criacao = criacao;
            Percentual = 0;
            NumeroItem = 0;
        }
        public void ConcluirItem(int item)
        {
            if (itens.Get(item - 1).Concluido)
                return;
            
            itens.Get(item - 1).Concluido = true;
            AtualizaPorcentagem();
            return;
        }
        public void AtualizaPorcentagem()
        {
            Percentual = 0;
            itens.ForEach( i => {
                if (i.Concluido)
                    Percentual += (100 / itens.Count);
            });

            if (Percentual >= 100)
                Conclusao = DateTime.Now; 
        }
        public override string Validar()
        {
            if (string.IsNullOrEmpty(Titulo))
                return "O Título não Pode Ser Vazio";
            if (_Prioridade != 0 && _Prioridade != 1 && _Prioridade != 2)
                return "A Prioridade Deve Ser entre 1 - 3";
            if (Criacao.CompareTo(DateTime.Now) == -1)
                return "Tarefas no Passado Não Podem Ser Criadas";
            return "sucesso";
        }
        public void AdicionarItem(Item item)
        {
            itens.Inserir(item);
            AtualizaPorcentagem();
        }
        public override string ToString()
        {
            return "ID " + Numero + " :\n\tTítulo : " + Titulo + "\n\tPrioridade : " + Prioridade
                + "\n\tData Criação: " + Criacao + "\n\tDevolução : " + Conclusao +
                "\n\tPercentual Concluído: " + Percentual + "\n\t//////////";
        }

        public int CompareTo(Tarefa other)
        {
            return other._Prioridade.CompareTo(_Prioridade);
        }
    }
}
