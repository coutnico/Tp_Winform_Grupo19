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

        int Id_Marca_Buscado;
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
                
                CardArticulos cardArticulo = new CardArticulos(articulo.Codigo, articulo.Nombre, articulo.Descripcion, articulo.IDMarca, articulo.IDCategoria, articulo.Precio);

                flowpanelArticles.Controls.Add(cardArticulo);
                
            }
        }
       private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            //Limpio screen antes de mostrar la busqueda
            flowpanelArticles.Controls.Clear();
            

            Id_Marca_Buscado = int.Parse(txtBuscador.Text);

            List<Articulo> articulos = ArticuloNegocio.ListarArticulos();

            foreach (Articulo articulo in articulos)
            {
                if (Id_Marca_Buscado == articulo.IDMarca)
                {  // busco por ID de marca
                    CardArticulos cardArticulo = new CardArticulos(articulo.Codigo, articulo.Nombre, articulo.Descripcion, articulo.IDMarca, articulo.IDCategoria, articulo.Precio);

                    flowpanelArticles.Controls.Add(cardArticulo);
                }
            }
        }
    }
}
