using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_WinForm_Grupo_19.Models
{
    public class ImagenNegocio
    {
        static string conexionstring = "server=(local); database=CATALOGO_P3_DB; integrated security=true";

        SqlConnection conexion = new SqlConnection(conexionstring);
        SqlCommand cmd;
        SqlDataReader reader = null;

        public List<Imagen> ListarImagen()
        {
            List<Imagen> lista = new List<Imagen>();

            try
            {
                conexion.Open();
                string query = "select Id, IdArticulo, ImagenUrl from IMAGENES\r\n";
                cmd = new SqlCommand(query, conexion);


                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    Imagen imagen = new Imagen();

                    imagen.Id = Convert.ToInt32(reader["Id"]);
                    imagen.IdArticulo = Convert.ToInt32(reader["IdArticulo"]);
                    imagen.URL = reader["ImagenUrl"].ToString();

                    lista.Add(imagen);

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
