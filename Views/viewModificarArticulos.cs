using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net;
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
        private ImagenNegocio ImagenNegocio = new ImagenNegocio();
        private int IDArticulo = 0;
        private int IndiceImagen = 0;
        List<Imagen> imagenes;


        public viewModificarArticulos(Articulo articulo)
        {
            InitializeComponent();

            this.articulo = articulo;

            this.IDArticulo = articulo.ID;
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

            precio_Articulo_a_modificar.Value = articulo.Precio;

            imagenes = ListaImagenesXArticulo();


            try
            {

                using (HttpClient httpClient = new HttpClient())
                {
                    using (WebClient cliente = new WebClient())
                    {
                        byte[] imagenBytes = cliente.DownloadData(imagenes[IndiceImagen].URL);
                        txtUrlImagen.Text = imagenes[IndiceImagen].URL;

                        if (imagenBytes != null && imagenBytes.Length > 0)
                        {
                            using (MemoryStream stream = new MemoryStream(imagenBytes))
                            {
                                Image imagen = Image.FromStream(stream);

                                pbImagen.Image = imagen;

                                txtUrlImagen.Text = imagenes[IndiceImagen].URL;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Los datos de la imagen están vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception)
            {

            }

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

            articulo_obj.Codigo = codigo_Articulo_a_modificar.Text;
            articulo_obj.Nombre = nombre_Articulo_a_modificar.Text;
            articulo_obj.Descripcion = descripcion_Articulo_a_modificar.Text;

            precio_Articulo_a_modificar.Text.Replace(',', ' ');

            decimal preciomodificado = Convert.ToDecimal(precio_Articulo_a_modificar.Text.Trim());

            articulo_obj.Precio = preciomodificado;


            foreach (Categoria categoria in listadecategorias)
            {
                if (cbCategorias.SelectedItem == categoria.Descripcion)
                    articulo_obj.IDCategoria = categoria.Id;
            }
            foreach (Marca marca in listademarcas)
            {
                if (cbMarcas.SelectedItem == marca.Descripcion)
                    articulo_obj.IDMarca = marca.Id;
            }

            //Cargar en  base de datos.
            ArticuloNegocio articuloNegocio_obj = new ArticuloNegocio();

            articuloNegocio_obj.modificarArticulo(articulo_obj, int.Parse(ID_Articulo_a_modificar.Text));

            this.Close();

        }

        private void viewModificarArticulos_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.degradadoAzulVioleta;
            this.BackgroundImageLayout = ImageLayout.Stretch;


        }

        private void ibFlechaDerecha_Click(object sender, EventArgs e)
        {
            if (IndiceImagen != ListaImagenesXArticulo().Count - 1)
            {
                try
                {
                    using (HttpClient httpClient = new HttpClient())
                    {
                        using (WebClient cliente = new WebClient())
                        {
                            IndiceImagen++;
                            byte[] imagenBytes = cliente.DownloadData(imagenes[IndiceImagen].URL);
                            txtUrlImagen.Text = imagenes[IndiceImagen].URL;

                            if (imagenBytes != null && imagenBytes.Length > 0)
                            {
                                using (MemoryStream stream = new MemoryStream(imagenBytes))
                                {
                                    Image imagen = Image.FromStream(stream);

                                    pbImagen.Image = imagen;

                                    txtUrlImagen.Text = imagenes[IndiceImagen].URL;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Los datos de la imagen están vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }

                    ibFlechaDerecha.BackColor = System.Drawing.Color.Transparent;
                    ibFlechaIzq.BackColor = System.Drawing.Color.Transparent;
                }
                catch (Exception)
                {
                    //En caso de que no cargue la imagen 
                }
            }
        }

        private void ibFlechaIzq_Click(object sender, EventArgs e)
        {
            if (IndiceImagen != 0)
            {
                try
                {
                    using (HttpClient httpClient = new HttpClient())
                    {
                        using (WebClient cliente = new WebClient())
                        {
                            IndiceImagen--;
                            byte[] imagenBytes = cliente.DownloadData(imagenes[IndiceImagen].URL);
                            txtUrlImagen.Text = imagenes[IndiceImagen].URL;

                            if (imagenBytes != null && imagenBytes.Length > 0)
                            {
                                using (MemoryStream stream = new MemoryStream(imagenBytes))
                                {
                                    Image imagen = Image.FromStream(stream);
                                    pbImagen.Image = imagen;
                                    txtUrlImagen.Text = imagenes[IndiceImagen].URL;

                                }
                            }
                            else
                            {
                                MessageBox.Show("Los datos de la imagen están vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    ibFlechaDerecha.BackColor = System.Drawing.Color.Transparent;
                    ibFlechaIzq.BackColor = System.Drawing.Color.Transparent;
                }
                catch (Exception)
                {
                    //En caso de que no cargue la imagen 
                }
            }
        }
        private List<Imagen> ListaImagenesXArticulo()
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            List<Imagen> imagenes = new List<Imagen>();


            foreach (Imagen imagen in imagenNegocio.ListarImagen())
            {
                if (imagen.IdArticulo == IDArticulo)
                {
                    imagenes.Add(imagen);
                }
            }

            return imagenes;
        }

        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {

        }

        private void ibModImage_Click(object sender, EventArgs e)
        {
            viewBajaModificacionImagenes bmImagenes = new viewBajaModificacionImagenes(imagenes);
            DialogResult result = bmImagenes.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Reinicio para aplicar cambios");
                this.Close();
            }
        }

        private void ibAgregarImagen_Click(object sender, EventArgs e)
        {
            viewAgregarImagen agregarImagenes = new viewAgregarImagen(this.articulo.ID);
            DialogResult result = agregarImagenes.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Reinicio para aplicar cambios");
                this.Close();
            }
        }
    }
}
