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
        private CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        private MarcaNegocio marcaNegocio = new MarcaNegocio();
        private Articulo articulo;
        List<Marca> listademarcas;
        List<Categoria> listadecategorias;
        public viewModificarArticulos(Articulo articulo)
        {
            InitializeComponent();

            this.articulo = articulo;

            ID_Articulo_a_modificar.Text = articulo.ID.ToString();
            codigo_Articulo_a_modificar.Text = articulo.Codigo;
            nombre_Articulo_a_modificar.Text = articulo.Nombre;
            descripcion_Articulo_a_modificar.Text = articulo.Descripcion;
            pbImagen.Image = articulo.ImagenCargada;

            listadecategorias = categoriaNegocio.ListarCategorias();

            foreach (Categoria categoria in listadecategorias)
            {
                cbCategorias.Items.Add(categoria.Descripcion);

            }

            foreach (Categoria categoria in listadecategorias)
            {
                if (articulo.IDCategoria == categoria.Id)
                {
                    cbCategorias.SelectedItem = categoria.Descripcion;
                }
            }

            listademarcas = marcaNegocio.ListarMarcas();

            foreach (Marca marca in listademarcas)
            {
                cbMarcas.Items.Add(marca.Descripcion);
            }

            foreach (Marca marca in listademarcas)
            {
                if (articulo.IDMarca == marca.Id)
                {
                    cbMarcas.SelectedItem = marca.Descripcion;
                }
            }

            precio_Articulo_a_modificar.Text = articulo.Precio.ToString();

        }


        /*
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
        */
        private void modificar_Articulo_Click(object sender, EventArgs e)
        {
            Articulo articulo_obj = new Articulo();


            //articulo_obj.IDMarca = int.Parse(lista_Marca.Text);
            //articulo_obj.IDCategoria = int.Parse(lista_Categoria.Text);

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

            //lista_Marca.Items.Clear();
            //lista_Categoria.Items.Clear();

            Close();

        }

        private void viewModificarArticulos_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.degradadoAzulVioleta;
            this.BackgroundImageLayout = ImageLayout.Stretch;


             

        }
    }
}
