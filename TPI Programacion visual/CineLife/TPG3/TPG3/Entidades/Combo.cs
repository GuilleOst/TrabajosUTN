using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class Combos
    {
        private int idProductoCombo;
        private List<int> idProductoSimple;
        private int cantidad;

        public Combos(int idProductoCombo, List<int> idProductoSimple, int cantidad)
        {
            this.idProductoCombo = idProductoCombo;
            this.idProductoSimple = idProductoSimple;
            this.cantidad = cantidad;
        }

        public Combos()
        {

        }

        public int IdProductoCombo { get => idProductoCombo; set => idProductoCombo = value; }
        public List<int> IdProductoSimple { get => idProductoSimple; set => idProductoSimple = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }









}
