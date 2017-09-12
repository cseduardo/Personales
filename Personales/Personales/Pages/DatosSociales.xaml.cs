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
	public partial class DatosSociales : ContentPage
	{
		public DatosSociales ()
		{
			InitializeComponent ();
		}
        public void nextPaged(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new DatosSociales());
        }
    }
}