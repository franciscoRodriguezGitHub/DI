using System;

namespace FormularioGridCasa.Models

{
    public class clsPersona
    {
        //Atributo de la clase Persona
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public DateTime? fechaNac { get; set; }
        //Constructor por defecto
        public clsPersona() {
            this.nombre = "Fran";
            this.apellidos = "Rodriguez";
            this.fechaNac = null;
        }
        //Constructor por parametros


    }
}