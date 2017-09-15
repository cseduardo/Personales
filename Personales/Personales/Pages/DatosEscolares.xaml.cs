using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personales.ViewModel;

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
        public void nextPaged(object sender, EventArgs e)
        {
            locals.carrera = career.Text;
            locals.semestre = Convert.ToString(picker.SelectedItem);
            locals.id = Convert.ToInt32(matricula.Text);
            Navigation.PushModalAsync(new DatosSociales());
        }
    }
}