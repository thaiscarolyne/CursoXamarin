using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App01_ControleXF.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();

            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;

            var height = (double)(mainDisplayInfo.Height/ mainDisplayInfo.Density);
            
            Menu.Spacing = 0.005 * height;

            var alturaBotao = 0.06;

            Botao1.HeightRequest = alturaBotao * height;
            Botao2.HeightRequest = alturaBotao * height;
            Botao3.HeightRequest = alturaBotao * height;
            Botao4.HeightRequest = alturaBotao * height;
            Botao5.HeightRequest = alturaBotao * height;
            Botao6.HeightRequest = alturaBotao * height;
            Botao7.HeightRequest = alturaBotao * height;
            Botao8.HeightRequest = alturaBotao * height;
            Botao9.HeightRequest = alturaBotao * height;
            Botao10.HeightRequest = alturaBotao * height;
            Botao11.HeightRequest = alturaBotao * height;
            Botao12.HeightRequest = alturaBotao * height;
            Botao13.HeightRequest = alturaBotao * height;
            Botao14.HeightRequest = alturaBotao * height;
            Botao15.HeightRequest = alturaBotao * height;
        }

        private void GoActivityIndicatorPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ActivityIndicatorPage());
            IsPresented = false;
        }

        private void GoTableViewPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.TableViewPage());
            IsPresented = false;
        }

        private void GoWebViewPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.WebViewPage());
            IsPresented = false;
        }

        private void GoListViewPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ListViewPage());
            IsPresented = false;
        }

        private void GoImagePage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ImagePage());
            IsPresented = false;
        }

        private void GoSwitchPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.SwitchPage());
            IsPresented = false;
        }        

        private void GoProgressBarPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ProgressBarPage());
            IsPresented = false;
        }

        private void GoBoxViewPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.BoxViewPage());
            IsPresented = false;
        }

        private void GoLabelPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.LabelPage());
            IsPresented = false;
        }

        private void GoButtonPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ButtonPage());
            IsPresented = false;
        }

        private void GoEntryEditorPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.EntryEditorPage());
            IsPresented = false;
        }

        private void GoDatePickerPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.DatePickerPage());
            IsPresented = false;
        }

        private void GoTimePickerPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.TimePickerPage());
            IsPresented = false;
        }

        private void GoPickerPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.PickerPage());
            IsPresented = false;
        }        

        private void GoSearchBarPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.SearchBarPage());
            IsPresented = false;
        }

        private void GoSlidderStepperPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.SliderStepperPage());
            IsPresented = false;
        }



    }
}