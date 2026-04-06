using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class Banco
    {
        public int idBanco { get; set; }
        public string nombreBanco { get; set; }

        public Banco(int idBanco, string nombreBanco)
        {
            this.idBanco = idBanco;
            this.nombreBanco = nombreBanco;
        }
    }
}
