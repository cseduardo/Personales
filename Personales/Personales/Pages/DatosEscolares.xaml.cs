using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Personales.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatosEscolares : ContentPage
    {
        public DatosEscolares()
        {
            InitializeComponent();
        }
        public void nextPage(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new DatosSociales());
        }
    }
}