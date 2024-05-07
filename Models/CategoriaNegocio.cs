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
                string query = "Select Id, Descripcion from CATEGORIAS"; 
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
        public void agregarCategoria(Categoria Categoria_obj)
        {
            ConexionDB conexionDB_Obj = new ConexionDB();
            try
            {

                // SQL usa ' para el query. y c# com dobles para separar cadenas
                conexionDB_Obj.EjecutarComando("Insert into CATEGORIAS (Descripcion) Values (" + " ' " + Categoria_obj.Descripcion + " ') ");
                System.Windows.Forms.MessageBox.Show("Categoria agregada exitosamente");
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void eliminarCategoria(int id_delete)
        {
            ConexionDB conexionDB_Obj = new ConexionDB();

            try
            {
                // SQL usa ' para el query. y c# com dobles para separar cadenas
                conexionDB_Obj.EjecutarComando("Delete from CATEGORIAS where ID = " + id_delete);

                System.Windows.Forms.MessageBox.Show("Categoria eliminada");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void modificarCategoria(Categoria Categoria_obj, int ID_a_modificar)
        {
            ConexionDB conexionDB_Obj = new ConexionDB();

            try
            {
                // SQL usa ' para el query. y c# com dobles para separar cadenas
                conexionDB_Obj.EjecutarComando("UPDATE CATEGORIAS SET Descripcion = '" + Categoria_obj.Descripcion + " ' WHERE ID = " + ID_a_modificar);
                System.Windows.Forms.MessageBox.Show("Categoria Actualizada");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Categoria Buscar_Categoria_por_ID(int id_buscado)

        {
            try
            {
                conexion.Open();
                string query = "Select id, Descripcion from CATEGORIAS";
                cmd = new SqlCommand(query, conexion);


                reader = cmd.ExecuteReader();

                Categoria Categoria = new Categoria();
                while (reader.Read())
                {



                    Categoria.Id = Convert.ToInt32(reader["Id"]);

                    if (Categoria.Id == id_buscado)
                    {
                        Categoria.Id = Convert.ToInt32(reader["Id"]);
                        Categoria.Descripcion = reader["Descripcion"].ToString();
                    }
                }
                return Categoria;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { conexion.Close(); }


        }


    }


}
