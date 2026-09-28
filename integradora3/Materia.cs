using System;
using System.Collections.Generic;
using System.Text;

namespace integradora3
{
    public class Materia : IExportable
    {
        public string Codigo { get; set; }
        public string Nombre { get; set;}
        public int Horas { get; set; }

        public Materia(string codigo, string nombre, int horas) 
        {
            Codigo = codigo;
            Nombre = nombre;
            Horas = horas;

        }

        public string ExportarLinea()
        {
            return $"Materia;{Codigo};{Nombre};{Horas}";
        }
    }
}
