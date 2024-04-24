using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tp_WinForm_Grupo_19.Models
{
    public class CategoriaNegocio
    {
        static string conexionstring = "server=(local); database=CATALOGO_P3_DB; integrated security=true";

        SqlConnection conexion = new SqlConnection(conexionstring);
        SqlCommand cmd;
        SqlDataReader reader = null;


        public List<Categoria> ListarCategorias()


        {
            List<Categoria> lista = new List<Categoria>();
            
            try
            {
                conexion.Open();
                string query = "Select Id, Descripcion from Categoria"; 
                cmd = new SqlCommand(query, conexion);


                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    Categoria categoria = new Categoria();

                    categoria.Id = Convert.ToInt32(reader["Id"]);
                    categoria.Descripcion = reader["Descripcion"].ToString();

                    lista.Add(categoria);

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
