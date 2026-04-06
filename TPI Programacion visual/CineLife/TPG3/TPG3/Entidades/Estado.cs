using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class Estado
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Estado(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
    }
}
