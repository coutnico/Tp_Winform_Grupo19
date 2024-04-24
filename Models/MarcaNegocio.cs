using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tp_WinForm_Grupo_19.Models
{
    public class MarcaNegocio
    {
        static string conexionstring = "server=(local); database=CATALOGO_P3_DB; integrated security=true";

        SqlConnection conexion = new SqlConnection(conexionstring);
        SqlCommand cmd;
        SqlDataReader reader = null;


        public List<Marca> ListarMarcas()


        {
            List<Marca> lista = new List<Marca>();

            try
            {
                conexion.Open();
                string query = "Select Id, Descripcion from MARCAS";  
                cmd = new SqlCommand(query, conexion);


                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    Marca marca = new Marca();

                    marca.Id = Convert.ToInt32(reader["Id"]);
                    marca.Descripcion = reader["Descripcion"].ToString();

                    lista.Add(marca);

                }

                return lista;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { conexion.Close(); }


        }
    }


}
