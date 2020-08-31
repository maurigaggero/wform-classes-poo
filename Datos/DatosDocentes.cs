using classlibrary_persona;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosDocentes : DatosConexionBD
    {
        public int abmDocentes(string accion, Docente objDocente)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Agregar")
                orden = "begin if not exists (select Dni from Docentes where Dni = " + objDocente.Dni + ")"
                       + "begin insert into Docentes " +
                       "values ("
                        + "'" + objDocente.Dni + "',"
                        + "'" + objDocente.Nombre + "',"
                        + "'" + objDocente.FechNac + "',"
                        + "'" + objDocente.Sexo + "',"
                        + "'" + objDocente.Legajo + "',"
                        + "'" + objDocente.Materia + "') "
                     + "end end";

            if (accion == "Modificar")
                orden = "update Docentes set "
                   + "Nombre= '" + objDocente.Nombre + "',"
                   + "FechaNac= '" + objDocente.FechNac + "',"
                   + "Sexo= '" + objDocente.Sexo + "',"
                   + "Legajo= '" + objDocente.Legajo + "',"
                   + "Materia= '" + objDocente.Materia + "' "

                   + "where Dni= " + objDocente.Dni;


            if (accion == "Eliminar")
                orden = "delete from Docentes where Dni = " + objDocente.Dni;

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

        public DataSet listadoDocentes(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Docentes where Dni = '" + int.Parse(cual) + "';";
            else
                orden = "select * from Docentes;";

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
