using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace App01_ControleXF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;

            var height = (double)(mainDisplayInfo.Height / mainDisplayInfo.Density);

            AlturaTela.Text = mainDisplayInfo.Height.ToString(); 
        }
    }
}
