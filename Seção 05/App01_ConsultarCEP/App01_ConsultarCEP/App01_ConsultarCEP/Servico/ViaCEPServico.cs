using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App01_ConsultarCEP.Servico.Modelo;
using Newtonsoft.Json;

namespace App01_ConsultarCEP.Servico
{
    class ViaCEPServico
    {
        private static string EnderecoURL = "https://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP(string CEP)
        {
            //Substitui o parâmetro {0} pelo CEP informado
            string NovoEnderecoURL = string.Format(EnderecoURL, CEP);

            //Instancia um novo cliente WEB
            WebClient wc = new WebClient();

            //Faz o download da string através do cliente WEB
            string Conteudo = wc.DownloadString(NovoEnderecoURL);

            //Transforma a string recebida em um objeto Endereco com seus respectivos atributos preenchidos
            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo);

            //Retorna o objeto Endereco
            return end;

        }
    }
}
