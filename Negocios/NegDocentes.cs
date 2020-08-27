using classlibrary_persona;
using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NegDocentes
    {
        DatosDocentes objDatosDocentes = new DatosDocentes();

        public int abmDocentes(string accion, Docente objDocente)
        {
            return objDatosDocentes.abmDocentes(accion, objDocente);
        }

        public DataSet listadoDocentes(string cual)
        {
            return objDatosDocentes.listadoDocentes(cual);
        }
    }
}
