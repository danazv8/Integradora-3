using System;
using System.Collections.Generic;
using System.Text;

namespace integradora3
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int DNI { get; private set; }

        public Persona(string nombre, int dni)
        {
            Nombre = nombre;
            DNI = dni;

        }

        public virtual string Presentarse()
            //si sacamos el virtual va a aparecer errores en Alumno, Profesor y Preceptor
        {
            return $"Hola, soy {Nombre}";

        }
    }
}

