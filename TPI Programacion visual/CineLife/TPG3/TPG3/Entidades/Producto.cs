using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class Producto
    {
        public int idProducto;
        public string nombre;
        public string descripcion;
        public int tipoProducto;
        public float precio;
        public int cantidadItems;
        public int TipoEdicion;

        public Producto(int idProducto,string nombre, string descripcion, int tipoProducto, float precio, int cantidadItems, int tipoEdicion)
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.tipoProducto = tipoProducto;
            this.precio = precio;
            this.cantidadItems = cantidadItems;
            this.TipoEdicion = tipoEdicion;
        }


        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int TipoProducto { get => tipoProducto; set => tipoProducto = value; }
        public float Precio { get => precio; set => precio = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
    }
}
