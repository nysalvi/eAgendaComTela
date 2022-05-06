using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace Dominio.Compartilhado
{
    public abstract class Entidade
    {
        public Entidade()
        {

        }
        abstract public int Total { get; set; }
        public int Numero { get; set; }

        public abstract string Validar();
    }
}
