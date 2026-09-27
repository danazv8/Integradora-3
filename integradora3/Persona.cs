using System;
using System.Collections.Generic;
using System.Text;

namespace integradora3
{
    public class Persona
    {
        public string Nombre {  get; set; }
        public int DNI { get; private set; }

        public Persona(string nombre, int dni)
        {
            Nombre = nombre;
            DNI = dni;

        }
    }
}
