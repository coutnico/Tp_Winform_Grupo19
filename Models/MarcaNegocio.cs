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

        public void agregarMarca(Marca marca_obj)
        {
            ConexionDB conexionDB_Obj = new ConexionDB();
            try
            {

                // SQL usa ' para el query. y c# com dobles para separar cadenas
                conexionDB_Obj.EjecutarComando("Insert into MARCAS (Descripcion) Values (" + " ' " + marca_obj.Descripcion + " ') ");
                System.Windows.Forms.MessageBox.Show("Marca agregada exitosamente");
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void eliminarMarca(int id_delete)
        {
            ConexionDB conexionDB_Obj = new ConexionDB();

            try
            {
                // SQL usa ' para el query. y c# com dobles para separar cadenas
                conexionDB_Obj.EjecutarComando("Delete from MARCAS where ID = " + id_delete);

                System.Windows.Forms.MessageBox.Show("Marca eliminada");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void modificarMarca(Marca marca_obj, int ID_a_modificar)
        {
            ConexionDB conexionDB_Obj = new ConexionDB();

            try
            {
                // SQL usa ' para el query. y c# com dobles para separar cadenas
                conexionDB_Obj.EjecutarComando("UPDATE MARCAS SET Descripcion = '" + marca_obj.Descripcion + " ' WHERE ID = " + ID_a_modificar);
                System.Windows.Forms.MessageBox.Show("Marca Actualizada");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Marca Buscar_Marca_por_ID(int id_buscado)

        {
            try
            {
                conexion.Open();
                string query = "Select id, Descripcion from MARCAS";
                cmd = new SqlCommand(query, conexion);


                reader = cmd.ExecuteReader();

                Marca marca = new Marca();
                while (reader.Read())
                {



                    marca.Id = Convert.ToInt32(reader["Id"]);

                    if (marca.Id == id_buscado)
                    {
                        marca.Id = Convert.ToInt32(reader["Id"]);
                        marca.Descripcion = reader["Descripcion"].ToString();
                    }
                }
                return marca;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { conexion.Close(); }


        }


    }


}
