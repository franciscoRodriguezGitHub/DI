using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace FormularioGridCasa
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {

            string nombre = txtNombre.Text;
            if (string.IsNullOrWhiteSpace(nombre))
            {
                txtNombreError.Text = "Error en el nombre";
            }
            else
            {
                txtNombreError.Text = "";
            }

            string apellidos = txtApellidos.Text;
            if (string.IsNullOrWhiteSpace(apellidos))
            {
                txtApellidosError.Text = "Error en el apellidos";
            }
            else
            {
                txtApellidosError.Text = "";
            }

            string fechas = txtFechas.Text;

            if (string.IsNullOrWhiteSpace(fechas))
            {
                txtFechasError.Text = "Error en el Fecha";

            }
            else
            {
                txtFechasError.Text = "";
                DateTime temp;
                if (!DateTime.TryParse(fechas, out temp)) {
                    txtFechasError.Text = "Incorrectar la fecha";
                }
                else {
                    txtFechasError.Text = "";
                }
            }
        }
    }
}
