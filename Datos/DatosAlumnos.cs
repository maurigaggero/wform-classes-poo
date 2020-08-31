using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using classlibrary_persona;

namespace Datos
{
    public class DatosAlumnos : DatosConexionBD
    {
        public int abmAlumnos(string accion, Alumno objAlumno)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Agregar")
                orden = "begin if not exists (select Dni from Alumnos where Dni = " + objAlumno.Dni + ")"
                   + "begin insert into Alumnos " +
                   "values ("
                    + "'" + objAlumno.Dni + "',"
                    + "'" + objAlumno.Nombre + "',"
                    + "'" + objAlumno.FechNac + "',"
                    + "'" + objAlumno.Sexo + "',"
                    + "'" + objAlumno.Legajo + "',"
                    + "'" + objAlumno.Carrera + "') "
                 + "end end";

            if (accion == "Modificar")
                orden = "update Alumnos set "
                   + "Nombre= '" + objAlumno.Nombre + "',"
                   + "FechaNac= '" + objAlumno.FechNac + "',"
                   + "Sexo= '" + objAlumno.Sexo + "',"
                   + "Legajo= '" + objAlumno.Legajo + "',"
                   + "Carrera= '" + objAlumno.Carrera + "' "

                   + "where Dni= " + objAlumno.Dni;


            if (accion == "Eliminar")
                orden = "delete from Alumnos where Dni = " + objAlumno.Dni;

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                AbrirConexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar, borrar o modificar registros", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoAlumnos(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Alumnos where Dni = '" + int.Parse(cual) + "';";
            else
                orden = "select * from Alumnos;";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar registros", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}


