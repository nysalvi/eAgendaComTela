using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Compartilhado
{
    public interface IRepositorio<T> where T : Entidade 
    {
        void Inserir(T entidade);
        void Editar(T entidade);
        void Excluir(T pred);
        List<T> Visualizar(Predicate<T> pred);

    }
}
