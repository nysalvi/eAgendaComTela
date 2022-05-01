using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Compartilhado
{
    public class Repositorio<T> : IRepositorio<T> where T : Entidade
    {
        private List<T> entidadeList;
        public List<T> EntidadeList => entidadeList;
        public Repositorio()
        {
            entidadeList = new List<T>();
        }
        public void Inserir(T entidade)
        {   
            entidade.Numero = Contato.Total++;
            entidadeList.Add(entidade);
        }

        public void Editar(T entidade, int posicao)
        {
            entidade.Numero = posicao;
            entidadeList[posicao] = entidade;
        }

        public void Excluir(T entidade)
        {
            entidadeList.Remove(entidade);
        }
    }
}
