using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class Origen
    {
        private int idOrigen;
        private string descripcion;

        public Origen(int idOrigen, string descripcion)
        {
            this.idOrigen = idOrigen;
            this.descripcion = descripcion;
        }

        public int IdOrigen { get => idOrigen; set => idOrigen = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
