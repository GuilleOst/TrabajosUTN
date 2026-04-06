using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class Formato
    {
        public int codFormato { get; set; }
        public string descripcion { get; set; }

        public Formato(int codFormato, string descripcion)
        {
            this.codFormato = codFormato;
            this.descripcion = descripcion;
        }
    }

    
}
