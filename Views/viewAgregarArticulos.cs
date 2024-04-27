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
        public viewAgregarArticulos()
        {
            InitializeComponent();

            // Agrego en el listbox todos los ID de marcas que existen para poder crear un nuevo articulo

            MarcaNegocio marcaNegocio = new MarcaNegocio();

            List<Marca> marcas = marcaNegocio.ListarMarcas();

            for (int i = 0; i < marcas.Count; i++) {
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

        private void crear_Articulo_Click(object sender, EventArgs e)
        {
            Articulo articulo_obj = new Articulo();
            //string codigo_art_sel, nombre_art_sel, descripcion_art_sel, imagen_art_sel;
            //int id_marca_sel, id_categoria_sel;
            //decimal precio_art_sel;

            /*id_marca_sel = int.Parse(lista_Marca.Text);
            id_categoria_sel = int.Parse(lista_Categoria.Text);

            codigo_art_sel = codigo_Articulo.Text;
            nombre_art_sel = nombre_Articulo.Text;
            descripcion_art_sel = descripcion_Articulo.Text;
            imagen_art_sel = imagen_Articulo.Text;


            // precio_art_sel = decimal.Parse(precio_Articulo.Text);*/

            articulo_obj.IDMarca = int.Parse(lista_Marca.Text);
            articulo_obj.IDCategoria = int.Parse(lista_Categoria.Text);

            articulo_obj.Codigo = codigo_Articulo.Text;
            articulo_obj.Nombre = nombre_Articulo.Text;
            articulo_obj.Descripcion = descripcion_Articulo.Text;
            articulo_obj.Precio = decimal.Parse(precio_Articulo.Text);

            //Cargar en  base de datos.
            ArticuloNegocio articuloNegocio_obj = new ArticuloNegocio();

            articuloNegocio_obj.agregarArticulo(articulo_obj);
            
            //Limpio carga y copio en ultimo reg.
            codigo_Articulo.Clear();
            nombre_Articulo.Clear();
            descripcion_Articulo.Clear();
            precio_Articulo.Clear();

            lista_Marca.Items.Clear();
            lista_Categoria.Items.Clear();

            Close();


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
