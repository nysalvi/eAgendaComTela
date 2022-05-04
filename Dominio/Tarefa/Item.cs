using Dominio.Compartilhado;

namespace Dominio
{
    public class Item : Entidade
    {
        public static int total;
        public override int Total { get { return total; } set { total = value; } }
        public Item()
        {

        }
        public string Descricao { get; set; }
        public bool Concluido { get; set; }

        public string EstaConcluido => Concluido ? "Concluída" : "Incompleta";
        public Item(string descricao, bool concluido)
        {
            Descricao = descricao;
            Concluido = concluido;
        }
        public override string ToString()
        {
            return "ID : " + Numero + " Descrição : " + Descricao + " Status : " + EstaConcluido;
        }
        public override string Validar()
        {
            if (string.IsNullOrEmpty(Descricao))
                return "A descrição não pode ser vazia";
            return "sucesso";
        }
    }
}
