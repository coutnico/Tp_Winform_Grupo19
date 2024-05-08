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

            ActualizarComboBoxs();

            this.BackgroundImage = Properties.Resources.degradadoAzulVioleta;
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void ActualizarComboBoxs()
        {
            cbCategorias.Items.Clear();
            cbMarcas.Items.Clear();

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
            DialogResult resultado = viewAgregarMarcas.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ActualizarComboBoxs();
            }
        }

        private void ibTrashMarca_Click(object sender, EventArgs e)
        {
            viewEliminarMarcas viewEliminarMarcas = new viewEliminarMarcas();
            DialogResult resultado = viewEliminarMarcas.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ActualizarComboBoxs();
            }
        }

        private void ibUpdateMarca_Click(object sender, EventArgs e)
        {
            viewModificarMarcas viewModificarMarcas = new viewModificarMarcas();
            DialogResult resultado = viewModificarMarcas.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ActualizarComboBoxs();
            }
        }

        private void ibAddCategoria_Click(object sender, EventArgs e)
        {
            viewAgregarCategorias viewAgregarCategorias = new viewAgregarCategorias();
            DialogResult resultado = viewAgregarCategorias.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ActualizarComboBoxs();
            }
        }

        private void ibTrashCategoria_Click(object sender, EventArgs e)
        {
            viewEliminarCategorias viewEliminarCategorias = new viewEliminarCategorias();
            DialogResult resultado = viewEliminarCategorias.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ActualizarComboBoxs();
            }
        }

        private void ibUpdateCategoria_Click(object sender, EventArgs e)
        {
            viewModificarCategorias viewModificarCategorias = new viewModificarCategorias();
            DialogResult resultado = viewModificarCategorias.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ActualizarComboBoxs();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
