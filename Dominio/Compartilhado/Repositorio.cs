using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Compartilhado
{
    internal class Repositorio : IRepositorio<Entidade>
    {        
        private List<Entidade> entidadeList;

        public Repositorio()
        {
            entidadeList = new List<Entidade>();
        }
        public void Inserir(Entidade entidade)
        {
            throw new NotImplementedException();
        }
        public void Editar(Entidade entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Entidade entidade)
        {
            throw new NotImplementedException();
        }
        public List<Entidade> Visualizar(Predicate<Entidade> pred)
        {
            return pred == null ? entidadeList: entidadeList.FindAll(pred);
        }
    }
}
