using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace demoviews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class View2 : ContentPage
	{
		public View2 ()
		{
			InitializeComponent ();
		}

        private void pickMusic_SelectedIndexChanged(object sender,System.EventArgs e)
        {
            var elementoSelecionado = pickMusic.SelectedItem.ToString();
            DisplayAlert("Genero Mùsica", elementoSelecionado, "Aceptar");
        }
    }
}