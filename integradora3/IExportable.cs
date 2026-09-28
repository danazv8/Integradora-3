using System;
using System.Collections.Generic;
using System.Text;

namespace integradora3
{
    public interface IExportable
    {
        string ExportarLinea();

        //string ExportarEncabezado(); da error porque las 3 clases deberian implementar el metodo
    }
}
