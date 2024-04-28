using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp_WinForm_Grupo_19.Models;

namespace Tp_WinForm_Grupo_19.Views
{
    public partial class viewModificarArticulos : Form
    {
        public viewModificarArticulos()
        {
            InitializeComponent();
            // Agrego en el listbox todos los ID de marcas que existen para poder crear un nuevo articulo

            MarcaNegocio marcaNegocio = new MarcaNegocio();

            List<Marca> marcas = marcaNegocio.ListarMarcas();

            for (int i = 0; i < marcas.Count; i++)
            {
                Marca marca_obj = marcas[i];
                lista_Marca.Items.Add(marca_obj.Id);// lista_marca es el nombre del combobox
            }

            // Agrego en el listbox todos los ID de categoria que existen para poder crear un nuevo articulo

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            List<Categoria> categorias = categoriaNegocio.ListarCategorias();


            for (int i = 0; i < categorias.Count; i++)
            {
                Categoria categoria_obj = categorias[i];
                lista_Categoria.Items.Add(categoria_obj.Id); // lista_categoria es el nombre del combobox
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {
            

        }

        private void ID_Articulo_a_modificar_TextChanged(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio_obj = new ArticuloNegocio();
            Articulo articulo_obj = new Articulo();
           
            ID_actual.Text = ID_Articulo_a_modificar.Text;

            if (int.Parse(ID_actual.Text) > 0)
            {
                articulo_obj = articuloNegocio_obj.Buscar_Articulo_por_ID(int.Parse(ID_Articulo_a_modificar.Text));

                Codigo_Actual.Text = articulo_obj.Codigo;
                Descripcion_Actual.Text = articulo_obj.Descripcion;
                ID_marca_Actual.Text = Convert.ToString(articulo_obj.IDMarca);
                ID_cat_Actual.Text = Convert.ToString(articulo_obj.IDCategoria);
                Precio_Actual.Text = Convert.ToString(articulo_obj.Precio);
            } else
            {
                Codigo_Actual.Text = Convert.ToString(-1);
                Descripcion_Actual.Text = Convert.ToString(-1);
                ID_marca_Actual.Text = Convert.ToString(-1);
                ID_cat_Actual.Text = Convert.ToString(-1);
                Precio_Actual.Text = Convert.ToString(-1);
            }
        }

        private void modificar_Articulo_Click(object sender, EventArgs e)
        {
            Articulo articulo_obj = new Articulo();


            articulo_obj.IDMarca = int.Parse(lista_Marca.Text);
            articulo_obj.IDCategoria = int.Parse(lista_Categoria.Text);

            articulo_obj.Codigo = codigo_Articulo_a_modificar.Text;
            articulo_obj.Nombre = nombre_Articulo_a_modificar.Text;
            articulo_obj.Descripcion = descripcion_Articulo_a_modificar.Text;
            articulo_obj.Precio = decimal.Parse(precio_Articulo_a_modificar.Text);

            //Cargar en  base de datos.
            ArticuloNegocio articuloNegocio_obj = new ArticuloNegocio();

            articuloNegocio_obj.modificarArticulo(articulo_obj, int.Parse(ID_Articulo_a_modificar.Text));

            //Limpio carga y copio en ultimo reg.
            codigo_Articulo_a_modificar.Clear();
            nombre_Articulo_a_modificar.Clear();
            descripcion_Articulo_a_modificar.Clear();
            precio_Articulo_a_modificar.Clear();

            lista_Marca.Items.Clear();
            lista_Categoria.Items.Clear();

            Close();

        }
    }
}
