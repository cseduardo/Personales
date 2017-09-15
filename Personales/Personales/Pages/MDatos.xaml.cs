using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personales.Pages;
using Personales.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Personales.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MDatos : ContentPage
    {
        public MDatos()
        {
            InitializeComponent();
            //is called to call the label and will be assigned the value of the variables of the class locals
            dCompletos.Text = "NOMBRE COMPLETO: " + locals.nombre + " " + locals.ape_pat + " " + locals.ape_mat + " TELEFONO: " +
                locals.num_telefono +"\nDOMICILIO\nCALLE: " + locals.calle + " NUMERO: " + locals.num_calle + " CODIGO POSTAL: " + 
                locals.cod_postal + "\nMUNICIPIO: " +locals.municipio + "\nESTADO: " + locals.estado + "\n ESCUELA\nCARRERA: " + 
                locals.carrera + " SEMESTRE: " + locals.semestre + " MATRICULA: " +locals.id + "\nSOCIALES\nCORREO: " + locals.email + 
                "\ngitHub: " + locals.git;
        }
    }
}