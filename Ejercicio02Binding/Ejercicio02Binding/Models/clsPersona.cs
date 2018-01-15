using System;

namespace Ejercicio02Binding.Models
{
    public class clsPersona
    {
        //Propiedades
    

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int IdPersona { get => idPersona; set => idPersona = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
  

        private int idPersona;
        private string nombre;
        private String apellido;
        private String direccion;
        private String telefono;
        private DateTime fechaNac;
       

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        /// <param name="idPersona"></param>
        /// <param name="nombre"></param>
        /// <param name="apellidos"></param>
        /// <param name="fechaNac"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        public clsPersona(int idPersona, string nombre, string apellidos, DateTime fechaNac, string direccion,
            string telefono)
        {
            this.IdPersona = idPersona;
            this.Nombre = nombre;
            this.Apellido = apellidos;
            this.FechaNac = fechaNac;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }
        public clsPersona()
        {

        }

        
    }

}