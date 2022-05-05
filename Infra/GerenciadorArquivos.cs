using System;
using System.Collections;
using Dominio;
using Dominio.Compartilhado;
//using System.Text.Json;
//using System.Text.Json.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Serialization;

namespace Infra
{    
    public class GerenciadorArquivos
    {
        private readonly string path;
        private readonly JsonSerializerSettings jsonSerializerSettings;
        private DataContext dataContext;
        public GerenciadorArquivos(string path)
        {
            this.path = path;

            jsonSerializerSettings = new JsonSerializerSettings();

            jsonSerializerSettings.Formatting = Formatting.Indented;
            jsonSerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.All;           
            dataContext = new DataContext();
        }
        /*
        public void AdicionarRepositorio<T>(List<T> repositorio) where T : Entidade
        {
            if (repositorio.GetType() == typeof(List<Tarefa>))
                dataContext.Tarefas = (List<Tarefa>)repositorio;
            if (repositorio.GetType() == typeof(List<Contato>))
                dataContext.Contatos = (List<Compromisso>)repositorio;
            if (repositorio.GetType() == typeof(List<Compromisso>))
                dataContext.Compromissos = repositorio;
        }
        public void SalvarRepositorio()
        {
            string dados = JsonConvert.SerializeObject(repositorios, jsonSerializerSettings);
            File.WriteAllText(path, dados);
        }
        public ArrayList CarregarRepositorio()
        {
            if (!File.Exists(path))
                return new ArrayList();
            string dados = File.ReadAllText(path);
            repositorios = (ArrayList)JsonConvert.DeserializeObject(dados, jsonSerializerSettings);
            return repositorios;
        }*/
    }
}
