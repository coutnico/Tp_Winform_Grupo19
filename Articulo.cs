using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_WinForm_Grupo_19
{
    internal class Articulo
    {
        /* •	Código de artículo.
       •	Nombre.
       •	Descripción.
       •	Marca(seleccionable de una lista desplegable).
       •	Categoría(seleccionable de una lista desplegable.
       •	Imagen.
       •	Precio.*/

        private int Codigo;
        private string Nombre;
        private string Descripcion;
        private int Marca;
        //private  Imagen; SE USA BYTE? VER
        private float Precio;

        //Sets
        public void setCodigo (int Cod) { Codigo = Cod ;}
        public void setCodigo(string Nom) { Nombre = Nom; }
        public void setDescripcion(string descripcion) { Descripcion = descripcion;}
        public void setMarca(int marca) { Marca = marca; }

        //Gets

        //FUNCIONES

    }
}
