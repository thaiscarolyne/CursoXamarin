using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCEP.Servico.Modelo;
using App01_ConsultarCEP.Servico;

namespace App01_ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //Quando clicar no botão, chama o método BuscarCEP
            Botao.Clicked += BuscarCEP;
            
        }

        private void BuscarCEP(object sender, EventArgs args)
        {
            string cep = CEP.Text.Trim();

            //Primeiro realiza validações
            if (isValidCEP(cep))
            {
                try
                {
                    //Chamando a classe e o método que faz a busca no site
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);

                    if (end.cep != null) 
                    {
                        //Atualiza o texto da label com o resultado obtido
                        Resultado.Text = string.Format("{0} - {1} - {2} ", end.uf, end.localidade, end.logradouro);
                    }
                    else //Se mesmo digitando os 8 números, não existe aquele CEP
                    {
                        DisplayAlert("ERRO", "O endereço não foi encontrado para este CEP!", "OK");
                    }
                }
                catch (Exception e) //Essas exceções são várias (Ex: o servidor do ViaCEP pode ter caído)
                {
                    DisplayAlert("ERRO CRÍTICO", e.Message, "OK");
                }
            }
        }

        private bool isValidCEP(string cep)
        {
            bool valido = true;

            if(cep.Length != 8)
            {
                DisplayAlert("ERRO", "O CEP informado não possui 8 dígitos!", "OK");
                valido = false;
            }

            int NovoCEP = 0;

            if (!int.TryParse(cep, out NovoCEP))
            {
                DisplayAlert("ERRO", "O CEP deve conter apenas números!", "OK");
                valido = false;
            }

            return valido;
        }
    }
}
