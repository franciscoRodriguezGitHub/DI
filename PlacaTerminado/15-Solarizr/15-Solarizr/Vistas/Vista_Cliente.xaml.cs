using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace _15_Solarizr.Vistas
{

    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Vista_Cliente : Page
    {
        public Vista_Cliente()
        {
            this.InitializeComponent();
         

          //  Mapa();


        }
        public async void Mapa()
        {
            // Launch the Windows Maps app
            var launcherOptions = new Windows.System.LauncherOptions();
            var uriNewYork = new Uri(@"bingmaps:?cp=40.726966~-74.006076");
            launcherOptions.TargetApplicationPackageFamilyName = "Microsoft.WindowsMaps_8wekyb3d8bbwe";
            var success = await Windows.System.Launcher.LaunchUriAsync(uriNewYork, launcherOptions);
        }
        private void btnGaleria_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Vista_Imagenes));
        }
        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            // this.Frame.Navigate(typeof(MainPage));
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.GoBack();
        }
        private void btnSalir(object sender, RoutedEventArgs e)
        {
            
            Frame.Navigate(typeof(MainPage));
        }
    }
}
