using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Compartilhado
{
    public interface IRepositorio<T> where T : Entidade 
    {
        public int Count{ get; }
        public void ForEach(Action<T> action);
        public List<T> GetAll { get; }
        void Inserir(T entidade);
        void Editar(T entidade, int posicao);
        void Excluir(T entidade);
        void Excluir(Predicate<T> match);
        List<T> FindAll(Predicate<T> pred);
        T Find(Predicate<T> pred);
        T Get(int id);
    }
}
