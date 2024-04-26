using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_WinForm_Grupo_19
{
    public class Articulo
    {
        /* •	Código de artículo.
       •	Nombre.
       •	Descripción.
       •	Marca(seleccionable de una lista desplegable).
       •	Categoría(seleccionable de una lista desplegable.
       •	Imagen.
       •	Precio.*/


        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IDMarca { get; set; }
        public int IDCategoria { get; set; }
        public decimal Precio { get; set; }
        public string ImagenURl { get; set; }




        //DatosCargados
        public Image ImagenCargada { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }

        //FUNCIONES

    }
}
