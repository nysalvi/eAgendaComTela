using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Compartilhado
{
    public class Repositorio<T> : IRepositorio<T> where T : Entidade
    {
        private readonly List<T> entidadeList;
        public int Count => entidadeList.Count;
        public Action<T> ForEach { set => entidadeList.ForEach(value); }
        public List<T> GetAll => new (entidadeList);

        public Repositorio()
        {
            entidadeList = new List<T>();
        }
        public void Inserir(T entidade)
        {
            entidade.Numero = entidade.Total++;
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
        public void Excluir(Predicate<T> match)
        {            
            entidadeList.RemoveAll(match);
        }

        public List<T> FindAll(Predicate<T> pred)
        {
            return entidadeList.FindAll(pred);
        }

        public T Find(Predicate<T> pred)
        {
            return entidadeList.Find(pred);
        }

        public T Get(int id)
        {
            return entidadeList[id];
        }
    }
}
