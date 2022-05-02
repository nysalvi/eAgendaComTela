using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Compartilhado
{
    public abstract class Entidade
    {
        abstract public int Total { get; set; }
        public int Numero { get; set; }
        public abstract string Validar();
    }
}
