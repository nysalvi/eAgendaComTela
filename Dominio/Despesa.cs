using Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Flags]
    public enum FormaPagamentos {Debito, Credito, Dinheiro, Pix}
    public class Despesa : Entidade
    {
        public static int total ;
        public FormaPagamentos FormaPagamento { get; set; }
        public decimal Valor { get; set; }
        public DateTime? Data { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public override int Total { get { return total; } set { total = value; } }
        public Despesa(FormaPagamentos formaPagamento, decimal valor, DateTime? data, string descricao, 
            string categoria)
        {
            Categoria = categoria;
            FormaPagamento = formaPagamento;
            Valor = valor;
            Data = data!;
            Descricao = descricao;
        }
        public override string Validar()
        {
            if (string.IsNullOrWhiteSpace(Descricao))
                return "A Descrição Não Pode Ser Vazia";
            if (string.IsNullOrWhiteSpace(Categoria))
                return "A Categoria Não Pode Ser Vazia";
            if (Data == default)
                return "Digite Uma Data Válida Ser Vazia";
            if (Valor < 0)
                return "Você não pode pagar 0 ou Menos";
            return "sucesso";
        }
    }
}
