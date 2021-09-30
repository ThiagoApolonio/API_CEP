using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Api
{
    class CLcep
    {
        private static WebClient InicializarCliente(string valorCep)
        {
            WebClient client = new WebClient();
            client.BaseAddress = string.Format("https://viacep.com.br/ws/{0}/json/", valorCep);
            client.Headers.Add("content-type", "application/json; charset=utf-8");
            client.Encoding = Encoding.UTF8;
            return client;
        }

        public static TexsBoxs GetApi(string valorCep)
        {
            WebClient client = InicializarCliente(valorCep);
            string response = Encoding.UTF8.GetString(client.DownloadData(client.BaseAddress));
            return (TexsBoxs)JsonConvert.DeserializeObject(response, typeof(TexsBoxs));
        }

        public class TexsBoxs
        {
            public string cep { get; set; }
            public string logradouro { get; set; }
            public string complemento { get; set; }
            public string bairro { get; set; }
            public string localidade { get; set; }
            public string uf { get; set; }
            public string unidade { get; set; }
            public string ibge { get; set; }
            public string gia { get; set; }
        }

    }
}
