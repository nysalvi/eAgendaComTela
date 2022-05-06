using Dominio.Compartilhado;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections;
//using System.Text.Json;
//using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.IO;
namespace Infra
{
    public class GerenciadorArquivos
    {
        private ArrayList repositorios;
        private readonly string path;
        private readonly JsonSerializerSettings jsonSerializerSettings;

        public GerenciadorArquivos(string path)
        {
            this.path = path;
            repositorios = new ArrayList();
            jsonSerializerSettings = new JsonSerializerSettings();

            jsonSerializerSettings.Formatting = Formatting.Indented;
            jsonSerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.All;
            CarregarList();
        }
        /*
        public void AdicionarList<T>(List<T> lista) where T : Entidade
        {            
            if (lista.GetType() == typeof(List<Tarefa>))
                dataContext.Tarefas = (List<Tarefa>)lista.Cast<Tarefa>();
            if (lista.GetType() == typeof(List<Contato>))
                dataContext.Contatos = (List<Contato>)lista.Cast<Contato>();
            if (lista.GetType() == typeof(List<Compromisso>))
                dataContext.Compromissos = (List<Compromisso>)lista.Cast<Compromisso>();            
        }*/
        public void AdicionarList<T>(List<T> lista) where T : Entidade
        {
            repositorios.Add(lista);
        }
        public void SalvarRepositorio()
        {
            string dados = JsonConvert.SerializeObject(repositorios, jsonSerializerSettings);
            File.WriteAllText(path, dados);
        }
        public List<T> PegarList<T>() where T : Entidade
        {
            Console.WriteLine(repositorios[0].GetType().ToString());
            foreach (JArray list in repositorios)
            {
                List<T> lista = list.ToObject<List<T>>();
                if (lista.GetType() == typeof(T))
                    return (List<T>)lista;
            }
            return null;
        }
        private void CarregarList()
        {
            if (!File.Exists(path))
                return;
            string dados = File.ReadAllText(path);
            repositorios = JsonConvert.DeserializeObject<ArrayList>(dados, jsonSerializerSettings);
        }
    }
}
