using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Tp_WinForm_Grupo_19.Models;

namespace Tp_WinForm_Grupo_19.UserControls
{
    public partial class CardArticulos : UserControl
    {
        private MarcaNegocio marcaNegocio = new MarcaNegocio();
        private CategoriaNegocio categoriNegocio = new CategoriaNegocio();
        private ImagenNegocio ImagenNegocio = new ImagenNegocio();
        private decimal precio;

        public event EventHandler<EventoTransferir> Eventotransferir;
        public event EventHandler<EventoTransferir> EvenetoModificar;
        public event EventHandler EventoEliminar;

        private Articulo articulo = new Articulo();


        private void OnEventotransferir(Articulo articulo)
        {
            Eventotransferir?.Invoke(this, new EventoTransferir(articulo));
        }
        private void OnEventoModificar(Articulo articulo)
        {
            EvenetoModificar?.Invoke(this, new EventoTransferir(articulo));
        }
        private void OnEventoEliminar()
        {
            EventoEliminar?.Invoke(this, EventArgs.Empty);
        }

        public CardArticulos()
        {
            InitializeComponent();
        }

        public CardArticulos(int idarticulo, string codigo, string nombre, string descripcion, int IdMarca, int IdCategoria, decimal precio)
        {
            InitializeComponent();

            try
            {
                articulo.ID = idarticulo;
                articulo.Codigo = codigo;
                articulo.Nombre = nombre;
                articulo.Descripcion = descripcion;
                articulo.IDMarca = IdMarca;
                articulo.IDCategoria = IdCategoria;
                articulo.Precio = precio;

                List<Imagen> imagenes = new List<Imagen>();

                this.precio = precio;
                lblCodigo.Text = codigo;
                lblNombre.Text = nombre;
                txtDescripcion.Text = descripcion;

                foreach (Categoria categoria in categoriNegocio.ListarCategorias())
                {
                    if (IdCategoria == categoria.Id)
                    {
                        lblCategoria.Text = "Categoria: " + categoria.Descripcion;
                        break;
                    }
                    else
                    {
                        lblCategoria.Text = "Categoria: None";

                    }
                }

                foreach (Marca marca in marcaNegocio.ListarMarcas())
                {
                    if (IdMarca == marca.Id)
                    {
                        lblMarca.Text = "Marca: " + marca.Descripcion;
                        break;
                    }
                    else
                    {
                        lblMarca.Text = "Marca: None";

                    }

                }

                foreach (Imagen imagen in ImagenNegocio.ListarImagen())
                {
                    if (imagen.IdArticulo == idarticulo)
                    {
                        imagenes.Add(imagen);
                    }
                }

                lblPrecio.Text = "$" + precio.ToString();


                using (HttpClient httpClient = new HttpClient())
                {
                    using (WebClient cliente = new WebClient())
                    {
                        byte[] imagenBytes = cliente.DownloadData(imagenes[0].URL);

                        if (imagenBytes != null && imagenBytes.Length > 0)
                        {
                            using (MemoryStream stream = new MemoryStream(imagenBytes))
                            {
                                Image imagen = Image.FromStream(stream);

                                pbImagen.Image = imagen;
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
                //En caso de que no cargue la imagen 
            }
        }

        private void ibVistaDetallada_Click(object sender, EventArgs e)
        {
            Articulo CardArticulo = new Articulo();

            CardArticulo.Nombre = lblNombre.Text;
            CardArticulo.Categoria = lblCategoria.Text;
            CardArticulo.Marca = lblMarca.Text;
            CardArticulo.Descripcion = txtDescripcion.Text;
            CardArticulo.Precio = precio;
            CardArticulo.ImagenCargada = pbImagen.Image;

            OnEventotransferir(CardArticulo);
        }

        private void ibUpdate_Click(object sender, EventArgs e)
        {
            articulo.ImagenCargada = pbImagen.Image;
            OnEventoModificar(articulo);
        }

        private void ibTrash_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio_obj = new ArticuloNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            articuloNegocio_obj.eliminarArticulo(articulo.ID);
            imagenNegocio.EliminarImagen(articulo.ID);

            OnEventoEliminar();
        }
    }
}
