using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchBarPage : ContentPage
	{
        private List<String> empresasTI;


        public SearchBarPage ()
		{
			InitializeComponent ();

            empresasTI = new List<string>();

            empresasTI.Add("Microsoft");
            empresasTI.Add("Apple");
            empresasTI.Add("Oracle");
            empresasTI.Add("SpaceX");
            empresasTI.Add("Tesla");
            empresasTI.Add("Google");
            empresasTI.Add("Telegram");

            Preencher(empresasTI);
            
        }

        private void PesquisarButton(object sender, EventArgs args)
        {
            List<String> resultado = empresasTI.Where(a => a.Contains(((SearchBar)sender).Text)).ToList<String>();

            Preencher(resultado);
        }

        private void Pesquisar(object sender, TextChangedEventArgs args)
        {
            List<String> resultado = empresasTI.Where(a => a.Contains(args.NewTextValue)).ToList<String>();

            Preencher(resultado);
        }

        private void Preencher(List<String> empresasTI)
        {
            ResultList.Children.Clear();

            foreach (var empresas in empresasTI)
            {
                ResultList.Children.Add(new Label { Text = empresas });
            }
        }
	}
}