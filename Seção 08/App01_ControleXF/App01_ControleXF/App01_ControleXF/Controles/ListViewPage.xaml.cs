using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App01_ControleXF.Modelo;

namespace App01_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();

            List<Pessoa> Lista = new List<Pessoa>();

            Lista.Add(new Pessoa { Nome = "José", Idade = 11 });
            Lista.Add(new Pessoa { Nome = "Maria", Idade = 23 });
            Lista.Add(new Pessoa { Nome = "Clementina", Idade = 65 });
            Lista.Add(new Pessoa { Nome = "Josefina", Idade = 33 });
            Lista.Add(new Pessoa { Nome = "Patrícia", Idade = 43 });

            ListaPessoas.ItemsSource = Lista;
		}
	}
}