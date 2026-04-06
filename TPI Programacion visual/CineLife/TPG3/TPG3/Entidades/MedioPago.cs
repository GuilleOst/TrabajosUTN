using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class MedioPago
    {
        public int codMedioPago { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int tarjeta { get; set; }
        public string nombreTarjeta { get; set; }
        public int TipoEdicion { get; set; }

        public MedioPago(int codMedioPago,string nombre, string descripcion, int tarjeta, string nombreTarjeta,int TipoEdicion)
        {
            this.codMedioPago = codMedioPago;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.tarjeta = tarjeta;
            this.nombreTarjeta = nombreTarjeta;
            this.TipoEdicion = TipoEdicion;
        }
    }
}
