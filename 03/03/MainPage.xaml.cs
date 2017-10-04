using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace _03
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

        private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnSaludo_Click(object sender, RoutedEventArgs e)
        {
            String nombre;
            //recogo el valor del TextBox
            nombre = this.txtNombre.Text;
           
            //DisplayDialog2("Perfecto", nombre);
            DisplayDialog("Perfecto",nombre);
        }
        private async void DisplayDialog(String titulo, String nombre)
        {
            ContentDialog Dialog = new ContentDialog
            {
                Title = titulo,
                Content = $"hola {nombre}",
                CloseButtonText = "No",
                PrimaryButtonText="S"

            };
            ContentDialogResult result = await Dialog.ShowAsync();
            //otra manera
            /*
            ContentDialog Dialog2 = new ContentDialog();
            Dialog2.Title = titulo;
            Dialog2.Content = nombre;
            ContentDialogResult result2 = await Dialog2.ShowAsync();
            */
        }
        private async void DisplayDialog2(String titulo, String nombre)
        {
            MessageDialog showDialog = new MessageDialog("hola");
            showDialog.Commands.Add(new UICommand("Si") { Id = 0 });
            showDialog.Commands.Add(new UICommand("No") { Id = 1 });
            showDialog.DefaultCommandIndex = 0;
            showDialog.CancelCommandIndex = 1;
            var result = await showDialog.ShowAsync();
            if ((int)result.Id == 0)
            {
                //Cuando dice que si
            }
            else
            {
                //Cuando dice que no 
            }

        }

    }
}
