using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_WinForm_Grupo_19.Models
{
    public class EventoTransferir : EventArgs
    {
        public Articulo ArticuloSeleccionado { get; set; }

        public EventoTransferir(Articulo articulo)
        {
            ArticuloSeleccionado = articulo;
        }
    }
}
