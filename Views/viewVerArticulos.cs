using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp_WinForm_Grupo_19.Models;
using Tp_WinForm_Grupo_19.UserControls;

namespace Tp_WinForm_Grupo_19.Views
{
    public partial class viewVerArticulos : Form
    {

        ArticuloNegocio ArticuloNegocio = new ArticuloNegocio();

        public viewVerArticulos()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.degradadoAzulVioleta;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void viewVerArticulos_Load(object sender, EventArgs e)
        {
            List<Articulo> articulos = ArticuloNegocio.ListarArticulos();

            foreach (Articulo articulo in articulos)
            { 

            }
        }
    }
}
