using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class TipoProducto
    {
        public int idTipoProducto { get; set; }
        public string nombreTipoProd { get; set; }
        public TipoProducto(int idTipoProduco, string nombreTipoProd)
        {
            this.idTipoProducto = idTipoProduco;
            this.nombreTipoProd = nombreTipoProd;
        }
    }
}
