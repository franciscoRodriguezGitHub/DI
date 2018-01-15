using Ejercicio02Binding.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02Binding.ViewModels
{
    class clsMainPageVM : INotifyPropertyChanged
    {
        //atributos privados
#region "atributos"


        private ObservableCollection<clsPersona> _listapersona;
        private clsPersona _personaSeleccionada;

        #endregion
        public ObservableCollection<clsPersona> listapersona {
            get
            {
                return _listapersona;
            }
        }
        public clsPersona personaSeleccionada {
            get { return _personaSeleccionada; }
            set {
                _personaSeleccionada = value;
                RaisePropertyChanged("personaSeleccionada");
                ;
            } }

        public clsMainPageVM()
        {
            clsListadoPersona oListado = new clsListadoPersona();
            _listapersona = oListado.instaPersonas();
            
        }

       
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
