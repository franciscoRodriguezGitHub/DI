﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _04_PasarDatosView.Models
{
    public class clsPersona
    {
        public int idPersona { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public DateTime fechaNac { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

    }
}