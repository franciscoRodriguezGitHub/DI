using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ejercicio02Binding.Models
{
    public class clsListadoPersona
    {
        
        /// <summary>
        /// Metodo de instaPersonas que crea y añade personas a la lista de personas
        /// Y retorna esa lista
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<clsPersona> instaPersonas()
        {
            ObservableCollection<clsPersona> personaslist = new ObservableCollection<clsPersona>();
            clsPersona persona1 = new clsPersona(3,"Fran","Sanchez",DateTime.Now,"dir","287423");
            clsPersona persona2 = new clsPersona(2,"Antonio", "Martinez", DateTime.Now, "dir", "235423");
            clsPersona persona3 = new clsPersona(4, "Carmen", "Martinez", DateTime.Now, "dir", "235423");
            clsPersona persona4 = new clsPersona(5, "Hola", "Martinez", DateTime.Now, "dir", "235423");
           
            personaslist.Add(persona1);
            personaslist.Add(persona2);
            personaslist.Add(persona3);
            personaslist.Add(persona4);
            return personaslist;
         }
        
    }
}