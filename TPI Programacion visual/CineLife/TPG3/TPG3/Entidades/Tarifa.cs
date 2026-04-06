using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class Tarifa
    {
        public int idTarifa { get; set; }
        public string descripcion { get; set; }
        public float valor { get; set; }
        public int codFormato { get; set; }

        public Tarifa (int idTariga, string descripcion, float valor, int codFormato)
        {
            this.idTarifa = idTariga;
            this.descripcion = descripcion;
            this.valor = valor;
            this.codFormato = codFormato;
        }
    }
}
