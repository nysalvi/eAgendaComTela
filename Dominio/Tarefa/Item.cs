using Dominio.Compartilhado;

namespace Dominio.Tarefa
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
        public Item(string descricao)
        {
            Descricao = descricao;
            Concluido = false;
        }
        public override string ToString()
        {
            return "ID : " + Numero + " Descrição : " + Descricao + " Status : " + EstaConcluido;
        }
        public override string Validar()
        {
            if (string.IsNullOrEmpty(Descricao))
                return "A descrição não pode ser vazio";
            return "sucesso";
        }
    }
}
