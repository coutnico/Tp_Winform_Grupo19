using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp_WinForm_Grupo_19.Models;

namespace Tp_WinForm_Grupo_19.UserControls
{
    public partial class CardArticulos : UserControl
    {
        private MarcaNegocio marcaNegocio = new MarcaNegocio();
        private CategoriaNegocio categoriNegocio = new CategoriaNegocio();
        private ImagenNegocio ImagenNegocio = new ImagenNegocio();



        public CardArticulos(int idarticulo, string codigo, string nombre, string descripcion, int IdMarca, int IdCategoria, decimal precio)
        {
            InitializeComponent();


            try
            {
                List<Imagen> imagenes = new List<Imagen>();

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


                //using (HttpClient httpClient = new HttpClient())
                //{
                //    using (WebClient cliente = new WebClient())
                //    {
                //        byte[] imagenBytes = cliente.DownloadData(imagenes[0].URL);

                //        if (imagenBytes != null && imagenBytes.Length > 0)
                //        {
                //            using (MemoryStream stream = new MemoryStream(imagenBytes))
                //            {
                //                Image imagen = Image.FromStream(stream);

                //                pbImagen.Image = imagen;
                //            }
                //        }
                //        else
                //        {
                //            MessageBox.Show("Los datos de la imagen están vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        }
                //    }
                //}
                lblPrecio.Text = precio.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
