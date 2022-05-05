using System;
using System.Collections.Generic;
using Dominio;

namespace Infra
{
    [Serializable]
    public  class DataContext
    {
        public List<Tarefa> Tarefas { get; set; }
        public List<Contato> Contatos { get; set; }
        public List<Compromisso> Compromissos{ get; set; }

        public DataContext()
        {
            Tarefas = new List<Tarefa>();
            Contatos = new List<Contato>();
            Compromissos = new List<Compromisso>();
        }
    }
}
