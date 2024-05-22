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
        //static string conexionstring = "server=(local); database=CATALOGO_P3_DB; integrated security=true";
        ConexionDB conexionDB_obj = new ConexionDB();
        //SqlConnection conexion = new SqlConnection(conexionstring);
        SqlCommand cmd;
        SqlDataReader reader = null;

        public List<Imagen> ListarImagen()
        {
            List<Imagen> lista = new List<Imagen>();

            try
            {
                //conexion.Open();
                string query = "select Id, IdArticulo, ImagenUrl from IMAGENES\r\n";
                //cmd = new SqlCommand(query, conexion);


                reader = conexionDB_obj.LeerDatos(query); // cmd.ExecuteReader();


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
            finally { conexionDB_obj.CerrarConexion(); }
        }

        public void InsertarImagen (int idArticulo, string url)
        {
            try
            {
                //conexion.Open();
                conexionDB_obj.AbrirConexion();
                string query = "INSERT INTO IMAGENES(IdArticulo, ImagenUrl) VALUES (@valor1, @valor2)";
                cmd = new SqlCommand (query, conexionDB_obj.conexion);
                cmd.Parameters.AddWithValue("@valor1", idArticulo);
                cmd.Parameters.AddWithValue("@valor2", url);

                cmd.ExecuteNonQuery();

                

            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                conexionDB_obj.CerrarConexion();
            }
        }

        public void EliminarImagen(int idArticulo)
        {
            try
            {
                conexionDB_obj.AbrirConexion();
                string query = "DELETE FROM iMAGENES WHERE IdArticulo = @valor1";
                cmd = new SqlCommand(query, conexionDB_obj.conexion);
                cmd.Parameters.AddWithValue("@valor1", idArticulo);
                cmd.ExecuteNonQuery();


            }
            catch (SqlException ex  )
            {

                throw ex;
            }
            finally
            {
                conexionDB_obj.CerrarConexion();
            }
        }

        public void EliminarImagenXIDimagen(int IdImagen)
        {
            try
            {
                conexionDB_obj.AbrirConexion();
                string query = "DELETE FROM iMAGENES WHERE Id = @valor1";
                cmd = new SqlCommand(query, conexionDB_obj.conexion);
                cmd.Parameters.AddWithValue("@valor1", IdImagen);
                cmd.ExecuteNonQuery();


            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                conexionDB_obj.CerrarConexion();
            }
        }


        public void ModificarImagen(int idArticulo, string url)
        {
            try
            {
                conexionDB_obj.AbrirConexion();
                string query = "UPDATE IMAGENES SET ImagenUrl = @valor1 WHERE IdArticulo = @valor2";
                cmd = new SqlCommand(query, conexionDB_obj.conexion);
                cmd.Parameters.AddWithValue("@valor1", url);
                cmd.Parameters.AddWithValue("@valor2", idArticulo);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                conexionDB_obj.CerrarConexion();
            }
        }

        public void ModificarImagenXIDImagen(int IdImagen, string url)
        {
            try
            {
                conexionDB_obj.AbrirConexion();
                string query = "UPDATE IMAGENES SET ImagenUrl = @valor1 WHERE Id = @valor2";
                cmd = new SqlCommand(query, conexionDB_obj.conexion);
                cmd.Parameters.AddWithValue("@valor1", url);
                cmd.Parameters.AddWithValue("@valor2", IdImagen);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                conexionDB_obj.CerrarConexion();
            }
        }

    }
}
