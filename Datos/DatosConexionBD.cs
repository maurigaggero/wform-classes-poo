using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosConexionBD
    {
        public SqlConnection conexion;
        public string cadenaConexion = "Data Source=DESKTOP-6DRN79V\\SQLEXPRESS;Initial Catalog = AlumDoc; Integrated Security = True;";

        #region CONSTRUCTOR
        public DatosConexionBD()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        #endregion

        #region MÉTODOS
        public void AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al abrir conexión", e);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al cerrar conexión", e);
            }
        }
    }
    #endregion

}