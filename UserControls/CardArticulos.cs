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

namespace Tp_WinForm_Grupo_19.UserControls
{
    public partial class CardArticulos : UserControl
    {
        public CardArticulos(string codigo, string nombre, string descripcion, int IdMarca, int IdCategoria, decimal precio)
        {
            InitializeComponent();


            try
            {

                lblCodigo.Text = codigo;
                lblNombre.Text = nombre;
                txtDescripcion.Text = descripcion;
                lblMarca.Text = "Marca: " + IdMarca.ToString();
                lblCategoria.Text = "Categoria: " + IdCategoria.ToString();
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
