using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tp_WinForm_Grupo_19.Models
{
    public class ArticuloNegocio
    {
        static string conexionstring = "server=(local); database=CATALOGO_P3_DB; integrated security=true";

        SqlConnection conexion = new SqlConnection(conexionstring);
        SqlCommand cmd;
        SqlDataReader reader = null;

        
        public List<Articulo> ListarArticulos()
        
        {
            List<Articulo> lista = new List<Articulo>();

            try
            {
                conexion.Open();
                string query = "Select id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio from ARTICULOS";
                cmd = new SqlCommand(query, conexion);


                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    Articulo articulo = new Articulo();

                    articulo.ID = Convert.ToInt32(reader["id"]);
                    articulo.Codigo = reader["Codigo"].ToString();  
                    articulo.Nombre = reader["Nombre"].ToString();
                    articulo.Descripcion = reader["Descripcion"].ToString();
                    articulo.IDMarca = Convert.ToInt32(reader["IdMarca"]);
                    articulo.IDCategoria = Convert.ToInt32(reader["IdCategoria"]);
                    articulo.Precio = Convert.ToDecimal(reader["Precio"]);

                    lista.Add(articulo);

                }

                return lista;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { conexion.Close(); }


        }

        public void agregarArticulo (Articulo articulo_obj)
        {
            ConexionDB conexionDB_Obj = new ConexionDB();


            // SQL usa ' para el query. y c# com dobles para separar cadenas
            conexionDB_Obj.EjecutarComando("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) Values (" + " ' " + articulo_obj.Codigo + "' , '" + articulo_obj.Nombre + "' , ' " + articulo_obj.Descripcion + " ' , " + articulo_obj.IDMarca + " , " + articulo_obj.IDCategoria + " , " + articulo_obj.Precio + " ) ");
            }

        public void eliminarArticulo(int id_delete)
        {
            ConexionDB conexionDB_Obj = new ConexionDB();
            // SQL usa ' para el query. y c# com dobles para separar cadenas
            conexionDB_Obj.EjecutarComando("Delete from ARTICULOS where ID = " + id_delete);
        }
    }
}

