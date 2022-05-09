using Dominio.Compartilhado;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Linq;
using System.Collections;
using Dominio;
using Dominio.Compartilhado;
//using System.Text.Json;
//using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.IO;
using System;

namespace Infra
{
    public class GerenciadorArquivos
    {
        private List<List<Entidade>> listas;

        private List<Tarefa> tarefas;
        private List<Compromisso> compromissos;
        private List<Contato> contatos;

        private ArrayList lista;
        private readonly string path;
        private readonly JsonSerializerSettings jsonSerializerSettings;

        public GerenciadorArquivos(string path)
        {
            this.path = path;
            listas = new();
            tarefas = new();
            contatos = new();
            compromissos = new();
            lista = new();
            jsonSerializerSettings = new JsonSerializerSettings();
            jsonSerializerSettings.Formatting = Formatting.Indented;
            jsonSerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.All;
            //CarregarList();
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
            List<Entidade> itemAntigo = null;

            foreach (List<Entidade> list in listas)
            {
                //List<T> listao = list.ToObject<List<T>>();
                if (list is List<T>)                    
                    itemAntigo = list;
            }
            if (itemAntigo is not null && itemAntigo.Count > 0)
                listas.Remove(itemAntigo);
            if (lista is not null && lista.Count > 0)
                listas.Add(lista.ToList<Entidade>());
        }
        public void SalvarRepositorio()
        {
            string dados = JsonConvert.SerializeObject(listas, jsonSerializerSettings);
            File.WriteAllText(path, dados);
        }
        public List<T> PegarList<T>() where T : Entidade
        {            
            if (listas is not null)
            {
                foreach (var list in listas)
                {
                    if (list is not null && list.GetType() is List<T>)
                        return list as List<T>;
                }
            }
            return null;
        }
        private void CarregarList()
        {
            if (!File.Exists(path))
                return;
            string dados = File.ReadAllText(path);
            var listasa = JsonConvert.DeserializeObject(dados, jsonSerializerSettings); //as List<List<Entidade>>;
            listas = (List<List<Entidade>>)Convert.ChangeType(listasa, typeof(List<List<Entidade>>));
            //lista.AddRange(listar);
        }
    }
}
