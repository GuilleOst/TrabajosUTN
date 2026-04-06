using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class Genero
    {
        private int codGenero;
        private string descripcion;

        public int CodGenero { get => codGenero; set => codGenero = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public Genero(int codGenero, string descripcion)
        {
            this.codGenero = codGenero;
            this.descripcion = descripcion;
        }

        public Genero()
        {

        }

    }
}
