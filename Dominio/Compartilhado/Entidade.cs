using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Compartilhado
{
    public abstract class Entidade : IEnumerable
    {
        abstract public int Total { get; set; }
        public int Numero { get; set; }
        public IEnumerator<Entidade> GetEnumerator()
        {
            
            throw new NotImplementedException();
        }

        public abstract string Validar();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
