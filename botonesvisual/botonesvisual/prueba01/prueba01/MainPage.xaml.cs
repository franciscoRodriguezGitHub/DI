using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace prueba01
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        /// <summary>
        /// MainPage() es la funcion cuando carga la pagina
        /// xml loaded=""; es para xuando carga la pagina
        /// </summary>
        public MainPage()
        {
            this.InitializeComponent();
            //Creo el Button
            Button button = new Button();

            // le doy atributos a los botones y sus correspondiente valores
            button.BorderBrush = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Yellow);
            button.Content = "btn3";
            button.FontSize = 16;
            button.Name = "btn3";
            button.HorizontalAlignment = HorizontalAlignment.Center;
            button.VerticalAlignment = VerticalAlignment.Center;
            button.Width = 200;
            button.Height = 70;
            button.FontWeight = FontWeights.Bold;
            button.FontFamily = new FontFamily("Verdana");
            button.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Blue);

            // Asigno el evento click al boton
            button.Click += (sender, args) =>
            {
                // llama a la funcion Mensage que lo que hace es crear y mostrar un MessageDialog
                Mensaje("Perfecto", "Contenido");
            };
            //Tambien se puede button.Click += boton3_click; y le añado el boton click abajo

            Panel.Children.Add(button);
        }
        /*
         * private void boton3_click(object sender, RoutedEventArgs e)
        {
            aqui ya le doy una funcion si lo hacemos de otra manera
             this.boton1.content="aa";
        } 
        */



        /// <summary>
        /// Esta funcion lo que hace es crear un MessageDialog y lo muestra 
        /// </summary>
        /// <param name="titulo">el titulo del MessageDialog</param>
        /// <param name="texto">el contenido del MessageDialog</param>
        private async void Mensaje(String titulo, String texto)
        {

            MessageDialog msgbox = new MessageDialog(titulo, texto);

            msgbox.Commands.Clear();
            //le asigno id a los label 
            msgbox.Commands.Add(new UICommand { Label = "Si", Id = 0 });
            msgbox.Commands.Add(new UICommand { Label = "No", Id = 1 });
            msgbox.Commands.Add(new UICommand { Label = "Cancelar", Id = 2 });

            //valor del id del label del MessageDialog
            var res = await msgbox.ShowAsync();

            if ((int)res.Id == 0)
            {
                MessageDialog msgbox2 = new MessageDialog("Cuando pulsa el boton si", "ok");
                await msgbox2.ShowAsync();
            }

            if ((int)res.Id == 1)
            {
                MessageDialog msgbox2 = new MessageDialog("Cuando pulsa el boton no", "fatal");
                await msgbox2.ShowAsync();
            }

            if ((int)res.Id == 2)
            {
                MessageDialog msgbox2 = new MessageDialog("Cuando pulsa el boton cancelar", "muy mal");
                await msgbox2.ShowAsync();
            }


        }


    }
}
