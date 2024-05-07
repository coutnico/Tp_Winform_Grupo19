using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp_WinForm_Grupo_19.Models;

namespace Tp_WinForm_Grupo_19.Views
{
    public partial class viewAgregarArticulos : Form
    {
        private CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        private MarcaNegocio marcaNegocio = new MarcaNegocio();

        List<Marca> listademarcas;
        List<Categoria> listadecategorias;
        public viewAgregarArticulos()
        {
            InitializeComponent();

            // Agrego en el listbox todos los ID de marcas que existen para poder crear un nuevo articulo


            listadecategorias = categoriaNegocio.ListarCategorias();
            listademarcas = marcaNegocio.ListarMarcas();

            foreach (Categoria categoria in listadecategorias)
            {
                cbCategorias.Items.Add(categoria.Descripcion);

            }

            foreach (Marca marca in listademarcas)
            {
                cbMarcas.Items.Add(marca.Descripcion);
            }

            this.BackgroundImage = Properties.Resources.degradadoAzulVioleta;
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }




        private void viewAgregarArticulos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lista_Marca_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void lista_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ibAgregarArticulo_Click(object sender, EventArgs e)
        {
            Articulo articulo_obj = new Articulo();


            foreach (Categoria categoria in listadecategorias)
            {
                if (cbCategorias.SelectedItem == categoria.Descripcion)
                {
                    articulo_obj.IDCategoria = categoria.Id;



                }
            }
            foreach (Marca marca in listademarcas)
            {
                if (cbMarcas.SelectedItem == marca.Descripcion)
                    articulo_obj.IDMarca = marca.Id;
            }


            articulo_obj.Codigo = txtCodigo.Text;
            articulo_obj.Nombre = txtNombre.Text;
            articulo_obj.Descripcion = txtDescripcion.Text;
            articulo_obj.Precio = Convert.ToDecimal(nudPrecio.Value);

            //Cargar en  base de datos.
            ArticuloNegocio articuloNegocio_obj = new ArticuloNegocio();

            articuloNegocio_obj.agregarArticulo(articulo_obj);



            Close();
        }


        private void ibAgregarMarca_Click(object sender, EventArgs e)
        {
            viewAgregarMarcas viewAgregarMarcas = new viewAgregarMarcas();
            viewAgregarMarcas.ShowDialog();
        }

        private void ibTrashMarca_Click(object sender, EventArgs e)
        {
            viewEliminarMarcas viewEliminarMarcas = new viewEliminarMarcas();
            viewEliminarMarcas.ShowDialog();
        }

        private void ibUpdateMarca_Click(object sender, EventArgs e)
        {
            viewModificarMarcas viewModificarMarcas = new viewModificarMarcas();
            viewModificarMarcas.ShowDialog();
        }

        private void ibAddCategoria_Click(object sender, EventArgs e)
        {
            viewAgregarCategorias viewAgregarCategorias = new viewAgregarCategorias();
            viewAgregarCategorias.ShowDialog();
        }

        private void ibTrashCategoria_Click(object sender, EventArgs e)
        {
            viewEliminarCategorias viewEliminarCategorias = new viewEliminarCategorias();
            viewEliminarCategorias.ShowDialog();
        }

        private void ibUpdateCategoria_Click(object sender, EventArgs e)
        {
            viewModificarCategorias viewModificarCategorias = new viewModificarCategorias();
            viewModificarCategorias.ShowDialog();
        }
    }
}
