using System;
using System.Collections.Generic;
using System.Text;

namespace integradora3
{
    public class Profesor : Persona, IExportable
    {
        public string Materia { get; set; }
        public Profesor(string nombre, int dni, string materia) : base(nombre, dni)
        {
            Materia = materia;
        }
        public override string Presentarse()
        {
            return $"Hola, soy {Nombre} y dicto {Materia}";

        }


        public string ExportarLinea()
        {
            return $"Profesor ; {Nombre} ; {Materia}";

        }
    }
    
}
