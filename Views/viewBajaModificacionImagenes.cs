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
    public partial class viewBajaModificacionImagenes : Form
    {
        public List<Imagen> imagenes { get; set; }
        private ImagenNegocio imagenNegocio = new ImagenNegocio();
        public viewBajaModificacionImagenes(List<Imagen> listaImagenes)
        {
            InitializeComponent();

            this.imagenes = listaImagenes;


            foreach (Imagen imagen in imagenes)
            {
                TextBox textBox = new TextBox();
                textBox.Width = 350;
                textBox.Text = imagen.URL;
                fpURLS.Controls.Add(textBox);
            }



        }

        private void ibClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void ibAceptar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fpURLS.Controls.Count; i++)
            {
                TextBox text = (TextBox)fpURLS.Controls[i];

                if (text.Text != string.Empty)
                {
                    imagenes[i].URL = text.Text;
                    imagenNegocio.ModificarImagenXIDImagen(imagenes[i].Id, imagenes[i].URL);
                }
                else
                {
                    imagenNegocio.EliminarImagenXIDimagen(imagenes[i].Id);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
