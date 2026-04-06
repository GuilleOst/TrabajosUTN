using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class Sala
    {
        public int codigo { get; set; }
        public int numero { get; set; }
        public int capacidadButacas { get; set; }
        public bool es3d { get; set; }

        public string formato { get; set; }

        public Sala()
        {
            this.codigo = codigo;
            this.numero = numero;
            this.capacidadButacas = capacidadButacas;
            this.es3d = es3d;
            this.formato = formato;
        }
    }
}
