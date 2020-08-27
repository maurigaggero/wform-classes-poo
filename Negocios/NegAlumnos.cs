using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using classlibrary_persona;
using Datos;

namespace Negocios
{
    public class NegAlumnos
    {
        DatosAlumnos objDatosAlumnos = new DatosAlumnos();

        public int abmAlumnos(string accion, Alumno objAlumno)
        {
            return objDatosAlumnos.abmAlumnos(accion, objAlumno);
        }

        public DataSet listadoAlumnos(string cual)
        {
            return objDatosAlumnos.listadoAlumnos(cual);
        }
    }
}
