using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tp_WinForm_Grupo_19.Models
{
    public class ConexionDB
    {
        public static string conexionstring = "server=(local); database=CATALOGO_P3_DB; integrated security=true";

        public static SqlConnection conexion = new SqlConnection(conexionstring);
        public static SqlCommand cmd;
        public static SqlDataReader reader = null;

        public static void AbrirConexion()
        {
            conexion.Open();
        }
        public static void CerrarConexion()
        {
            conexion.Close();
        }

        public static SqlDataReader LeerDatos(string query)
        {
            try
            {
                cmd = new SqlCommand(query, conexion);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);        
            }
            return null;
        }

        public void EjecutarComando(string query)
        {
            try
            {
                AbrirConexion();
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }      
    }

}
