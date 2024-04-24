using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp_WinForm_Grupo_19.Models;

namespace Tp_WinForm_Grupo_19.UserControls
{
    public partial class CardArticulos : UserControl
    {
        MarcaNegocio marcaNegocio = new MarcaNegocio();
        CategoriaNegocio categoriNegocio = new CategoriaNegocio();
        public CardArticulos(string codigo, string nombre, string descripcion, int IdMarca, int IdCategoria, decimal precio)
        {
            InitializeComponent();


            try
            {
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
                lblPrecio.Text = precio.ToString();









                //using (WebClient cliente = new WebClient())
                //{
                //    byte[] imagenBytes = cliente.DownloadData(url);
                //    using (MemoryStream stream = new MemoryStream(imagenBytes))
                //    {
                //        pbImagen.Image = Image.FromStream(stream);
                //    }
                //}
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
