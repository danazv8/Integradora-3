using System;
using System.Collections.Generic;
using System.Text;

namespace integradora3
{
    public class Preceptor : Persona
    {
        public Preceptor(string nombre, int dni) : base(nombre, dni)
        {

        }

        public override string Presentarse()
        {
            return $"Hola, soy {Nombre}, preceptor.";

        }
    }
}
