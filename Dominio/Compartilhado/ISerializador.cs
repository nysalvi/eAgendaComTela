using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Compartilhado
{
    public interface ISerializador<T> where T : Entidade
    {
        List<T> CarregarTarefasDoArquivo();
        void GravarTarefasEmArquivo(List<T> tarefas);
    }
}
