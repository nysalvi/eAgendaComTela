using Dominio.Compartilhado;
using System;

namespace Dominio
{
    public class Compromisso : Entidade
    {
        public static int total;
        public override int Total { get { return total; } set { total = value; } }
        public Compromisso()
        {

        }
        public string Assunto { get; set; }
        public string Local { get; set; }
        public DateTime Data { set; get; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraTermino { get; set; }
        public Contato Contato { get; set; }

        public Compromisso(string assunto, string local, DateTime data, TimeSpan horaInicio,
            TimeSpan horaTermino, Contato contato)
        {
            Assunto = assunto;
            Local = local;
            Data = data;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
            Contato = contato;
        }
        public override string Validar()
        {

            if (string.IsNullOrEmpty(Assunto))
                return "O Assunto não Pode ser Vazio!!";
            if (string.IsNullOrEmpty(Local))
                return "O Local não pode Ser Vazio!!!";
            if (Data.CompareTo(DateTime.Now) == -1)
                return "O Compromisso Precisa ser numa Data Futura!!!";
            if (Contato != null && Contato.Validar() != "sucesso")
                return "O Contato Possui um dado Inválido!!!";
            if (HoraTermino < HoraInicio)
                return "O Horário Final precisa ser Obrigatoriamente Maior que o Horário Final";
            return "sucesso";
        }
        public override string ToString()
        {
            return "ID " + Numero + " :\n\tAssunto : " + Assunto + "\n\tLocal : " + Local + "\n\tData : "
                + Data + "\n\tHorário Inicial : " + HoraInicio + "\n\tHorário Final: " + HoraTermino
                + "\n\tContato : " + Contato == null ? "Sem Contato Atrelado!!!" : Contato.Nome
                + "\n\t//////////";
        }
    }
}
