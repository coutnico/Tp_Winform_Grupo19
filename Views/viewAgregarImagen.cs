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
    public partial class viewAgregarImagen : Form
    {
        private int idArticulo;
        private ImagenNegocio ImagenNegocio = new ImagenNegocio();
        public viewAgregarImagen(int idarticulo)
        {
            InitializeComponent();

            this.idArticulo = idarticulo;
        }

        private void ibClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ibAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ImagenNegocio.InsertarImagen(idArticulo, txtURL.Text);
                MessageBox.Show("Imagen Agregada exitosamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Opsss.... Error");
            }
            finally
            {
                txtURL.Text = string.Empty;
            }
        }
    }
}
