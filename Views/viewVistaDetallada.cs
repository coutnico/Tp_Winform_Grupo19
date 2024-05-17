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
    public partial class viewVistaDetallada : Form
    {

        private int IDArticulo;
        private int IndiceImagen = 0;
        public viewVistaDetallada(Articulo articulo)
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            pbImageArticle.Image = articulo.ImagenCargada;

            this.IDArticulo = articulo.ID;
            lblName.Text = articulo.Nombre;
            lblMar.Text = articulo.Marca;
            lblCat.Text = articulo.Categoria;
            lblDesc.Text = articulo.Descripcion;
            lblPrice.Text = "$" + articulo.Precio.ToString();

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Color borderColor = Color.Black;
            int borderWidth = 8;

            using (Pen borderPen = new Pen(borderColor, borderWidth))
            {
                g.DrawRectangle(borderPen, 0, 0, panelPrincipal.Width - 1, panelPrincipal.Height - 1);
            }
        }

        private void ibFlechaDerecha_MouseHover(object sender, EventArgs e)
        {
            ibFlechaDerecha.IconColor = SystemColors.Control;
        }

        private void ibFlechaDerecha_MouseLeave(object sender, EventArgs e)
        {
            ibFlechaDerecha.IconColor = System.Drawing.Color.Black;

        }

        private void ibFlechaIzq_MouseHover(object sender, EventArgs e)
        {
            ibFlechaIzq.IconColor = SystemColors.Control;

        }

        private void ibFlechaIzq_MouseLeave(object sender, EventArgs e)
        {
            ibFlechaIzq.IconColor = System.Drawing.Color.Black;

        }

        private void pbImageArticle_Click(object sender, EventArgs e)
        {

        }

        private void ibFlechaDerecha_Click(object sender, EventArgs e)
        {
            if (IndiceImagen != ListaImagenesXArticulo().Count)
            {
                try
                {
                    List<Imagen> imagenes = ListaImagenesXArticulo();


                    using (HttpClient httpClient = new HttpClient())
                    {
                        using (WebClient cliente = new WebClient())
                        {
                            byte[] imagenBytes = cliente.DownloadData(imagenes[++IndiceImagen].URL);

                            if (imagenBytes != null && imagenBytes.Length > 0)
                            {
                                using (MemoryStream stream = new MemoryStream(imagenBytes))
                                {
                                    Image imagen = Image.FromStream(stream);

                                    pbImageArticle.Image = imagen;
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
                    List<Imagen> imagenes = ListaImagenesXArticulo();


                    using (HttpClient httpClient = new HttpClient())
                    {
                        using (WebClient cliente = new WebClient())
                        {
                            byte[] imagenBytes = cliente.DownloadData(imagenes[--IndiceImagen].URL);

                            if (imagenBytes != null && imagenBytes.Length > 0)
                            {
                                using (MemoryStream stream = new MemoryStream(imagenBytes))
                                {
                                    Image imagen = Image.FromStream(stream);

                                    pbImageArticle.Image = imagen;
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
    }
}
