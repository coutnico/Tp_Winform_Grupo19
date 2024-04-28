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


        public event EventHandler<EventoTransferir> Transferencia;
        public event EventHandler<EventoTransferir> TransferenciaModificar;

        public viewVerArticulos()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.degradadoAzulVioleta;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void OnTransferencia(Articulo articulo)
        {
            Transferencia?.Invoke(this, new EventoTransferir(articulo));
        }
        private void OnTransferenciaModificar(Articulo articulo)
        {
            TransferenciaModificar?.Invoke(this, new EventoTransferir(articulo));
        }

        private void viewVerArticulos_Load(object sender, EventArgs e)
        {
            List<Articulo> articulos = ArticuloNegocio.ListarArticulos();

            foreach (Articulo articulo in articulos)
            {

                CardArticulos cardArticulo = new CardArticulos(articulo.ID, articulo.Codigo, articulo.Nombre, articulo.Descripcion, articulo.IDMarca, articulo.IDCategoria, articulo.Precio);
                cardArticulo.Eventotransferir += CardArticulo_Eventotransferir1;
                cardArticulo.EvenetoModificar += CardArticulo_EvenetoModificar;
                cardArticulo.EventoEliminar += CardArticulo_EventoEliminar;
                flowpanelArticles.Controls.Add(cardArticulo);

            }
        }

        private void CardArticulo_EventoEliminar(object sender, EventArgs e)
        {
            flowpanelArticles.Controls.Clear();
            txtBuscador.Text = "";
            viewVerArticulos_Load(null, EventArgs.Empty);
        }

        private void CardArticulo_EvenetoModificar(object sender, EventoTransferir e)
        {
            OnTransferenciaModificar(e.ArticuloSeleccionado);
        }

        private void CardArticulo_Eventotransferir1(object sender, EventoTransferir e)
        {
            OnTransferencia(e.ArticuloSeleccionado);
        }


        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            //Limpio screen antes de mostrar la busqueda
            flowpanelArticles.Controls.Clear();

            List<Articulo> articulos = ArticuloNegocio.ListarArticulos();


            if (!string.IsNullOrEmpty(txtBuscador.Text))
            {
                foreach (Articulo articulo in articulos)
                {
                    if (articulo.Nombre.ToUpper().Contains(txtBuscador.Text))
                    {  // busco por ID de marca
                        CardArticulos cardArticulo = new CardArticulos(articulo.ID, articulo.Codigo, articulo.Nombre, articulo.Descripcion, articulo.IDMarca, articulo.IDCategoria, articulo.Precio);
                        cardArticulo.Eventotransferir += CardArticulo_Eventotransferir1;
                        cardArticulo.EvenetoModificar += CardArticulo_EvenetoModificar;
                        cardArticulo.EventoEliminar += CardArticulo_EventoEliminar;
                        flowpanelArticles.Controls.Add(cardArticulo);
                    }
                }
            }
            else
            {
                flowpanelArticles.Controls.Clear();
                viewVerArticulos_Load(null, EventArgs.Empty);
            }
        }

    }
}
