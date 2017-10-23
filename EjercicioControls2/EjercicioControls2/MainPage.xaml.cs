using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace EjercicioControls2
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //Declaro el objeto font
        ObservableCollection<FontFamily> fonts = new ObservableCollection<FontFamily>();

        private int cont = 0;


        public MainPage()
        {
            this.InitializeComponent();
            //aqui le doy valores al objeto fonts
            fonts.Add(new FontFamily("Arial"));
            fonts.Add(new FontFamily("Courier New"));
            fonts.Add(new FontFamily("Times New Roman"));
            //cada vez que seleciona una fecha en este calendario mostrara un mensaje y lo dejara selecionada la fecha
            MyCalendarDatePicker.Date = new DateTime(2017, 10, 11);//Selected date is March 3rd 2016        
            calendarView.SelectedDatesChanged += (e, f) =>
            {
                f.AddedDates.ToList().ForEach(x =>
                {

                    ShowMessage("Añadir selecion: " + x.Date.ToString("dd/MM/yyyy"));
                   
                });
                //si la fecha esta selecionada se borra la seleccion
                f.RemovedDates.ToList().ForEach(x =>
                {
                    ShowMessage("borrar selecion: " + x.Date.ToString("dd/MM/yyyy"));
                });
            };



            calendario2.SelectedDatesChanged += (e, f) =>
            {
                f.AddedDates.ToList().ForEach(x =>
                {
                    if (cont == 0)
                    {
                        calendario2.MinDate = x.Date;
                      
                        cont++;
                    }
                    else if (cont == 1)
                    {
                        calendario2.MaxDate = x.Date;
                       
                    }
                });
            };
        }
        private HashSet<DateTimeOffset> validDates = new HashSet<DateTimeOffset>
            {
                DateTimeOffset.Parse("27/10/2017"),
                DateTimeOffset.Parse("05/01/2017"),
                DateTimeOffset.Parse("20/01/2017"),
                DateTimeOffset.Parse("06/02/2017"),
            };


        private void onCalendarViewDayItemChanging(CalendarView sender, CalendarViewDayItemChangingEventArgs e)
        {
            e.Item.IsBlackout = !validDates.Contains(e.Item.Date.Date);
        }

        public async void ShowMessage(string message)
        {
            var msg = new Windows.UI.Popups.MessageDialog(message);
            msg.DefaultCommandIndex = 1;
            await msg.ShowAsync();
        }
        /// <summary>
        /// checkbox de pizzas este es el simple
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toppingsCheckbox_Click(object sender, RoutedEventArgs e)
        {
            string selectedToppingsText = string.Empty;
            CheckBox[] checkboxes = new CheckBox[] { pepperoniCheckbox, barbacoaCheckbox,
                                             jamonYquesoCheckbox };
            foreach (CheckBox c in checkboxes)
            {
                if (c.IsChecked == true)
                {
                    if (selectedToppingsText.Length > 1)
                    {
                        selectedToppingsText += ", ";
                    }
                    selectedToppingsText += c.Content;
                }
            }
            toppingsList.Text = selectedToppingsText;
        }
        ////checkbox complejo
        private void Option_Checked(object sender, RoutedEventArgs e)
        {
            SetCheckedState();
        }
        private void Option_Unchecked(object sender, RoutedEventArgs e)
        {
            SetCheckedState();
        }
        /// <summary>
        /// cuando selecionamos el check selecionar todo ponemos lo demas cheboxes a true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAll_Checked(object sender, RoutedEventArgs e)
        {
            Option1CheckBox.IsChecked = Option2CheckBox.IsChecked = Option3CheckBox.IsChecked = true;
        }

        private void SelectAll_Unchecked(object sender, RoutedEventArgs e)
        {
            Option1CheckBox.IsChecked = Option2CheckBox.IsChecked = Option3CheckBox.IsChecked = false;
        }

        private void SelectAll_Indeterminate(object sender, RoutedEventArgs e)
        {
            // Si la casilla Seleccionar todo está marcada (todas las opciones están seleccionadas),
            // al hacer clic en el cuadro, lo cambiará a su estado indeterminado.
            // En cambio, queremos desmarcar todos los cuadros,
            // entonces hacemos esto programáticamente. El estado indeterminado debería
            // solo se establece programáticamente, no por el usuario.

            if (Option1CheckBox.IsChecked == true &&
                Option2CheckBox.IsChecked == true &&
                Option3CheckBox.IsChecked == true)
            {
                // Esto causará que SelectAll_Unchecked se ejecute, por lo que
                // no necesitamos desmarcar los otros cuadros aquí.
                OptionsAllCheckBox.IsChecked = false;
            }
        }

        private void SetCheckedState()
        {
            // Los controles son nulos la primera vez que se llama, así que solo
            // necesita realizar una comprobación nula en cualquiera de los controles.
            if (Option1CheckBox != null)
            {
                if (Option1CheckBox.IsChecked == true &&
                    Option2CheckBox.IsChecked == true &&
                    Option3CheckBox.IsChecked == true)
                {
                    OptionsAllCheckBox.IsChecked = true;
                }
                else if (Option1CheckBox.IsChecked == false &&
                    Option2CheckBox.IsChecked == false &&
                    Option3CheckBox.IsChecked == false)
                {
                    OptionsAllCheckBox.IsChecked = false;
                }
                else
                {
                    // Establece el tercer estado (indeterminado) configurando IsChecked a null.
                    OptionsAllCheckBox.IsChecked = null;
                }
            }
        }
        private static int _clicks = 0;
        /// <summary>
        /// esto es que hace que cada vez que se pulse se incremente la barra de progreso al darle clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            _clicks += 1;
            progressBar1.Value = _clicks;
            if (_clicks >= progressBar1.Maximum) _clicks = 0;
        }
        /// <summary>
        ///cuando se modificar el slider se modificara la barra de progreso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            Slider slider = sender as Slider;
            if (slider != null)
            {
                progressBar1.Value = slider.Value;
            }
        }
        //Al pulsar una fecha salta este evento
        private void MyCalendarDatePicker_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            //cuando la es no es null 
            if (args.NewDate != null)
            {
                /* le pasa pasa la fecha para mostrarlo en un content dialog*/
                DisplayDate(args.NewDate.Value.ToString());
            }
        }

        private async void DisplayDate(string SelectedDate)
        {
            ContentDialog noWifiDialog = new ContentDialog()
            {
                Title = "Titulo",
                Content = "Fecha selecionada: " + SelectedDate,
                PrimaryButtonText = "Ok"
            };
            noWifiDialog.Margin = new Thickness(0, 100, 0, 0);
            await noWifiDialog.ShowAsync();
        }




    }
}
