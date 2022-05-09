using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Dominio.Compartilhado
{
    [Serializable]
    public class Repositorio<T> : IRepositorio<T> where T : Entidade
    {
        private readonly List<T> entidadeList;
        public int Count => entidadeList.Count;
        public List<T> GetAll => new (entidadeList);

        public Repositorio()
        {
            entidadeList = new List<T>();
        }
        public Repositorio(List<T> entidadeList)
        {
            this.entidadeList = entidadeList != null ? entidadeList : new();
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
            return new List<T>(entidadeList.FindAll(pred));
        }

        public T Find(Predicate<T> pred)
        {
            return entidadeList.Find(pred);
        }
        public T Get(int id)
        {
            JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();
            jsonSerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.All;

            string copia = JsonConvert.SerializeObject(entidadeList[id], jsonSerializerSettings);
            
            return JsonConvert.DeserializeObject<T>(copia);
        }

        public void ForEach(Action<T> action)
        {
            entidadeList.ForEach(action);
        }
    }
}
