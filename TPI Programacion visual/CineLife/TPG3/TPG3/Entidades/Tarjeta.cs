using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
//{
//    public class Tarjetas
//    {
//        private string Codigo;
//        private string Nombre;
//        private string Banco;

//        public Tarjetas(string codigo, string nombre, string banco)
//        {
//            Codigo = codigo;
//            Nombre = nombre;
//            Banco = banco;
//        }

//        public string codigoTarjeta
//        {
//            get => Codigo;
//            set => Codigo = value;
//        }

//        public string nombreTarjeta
//        {
//            get => Nombre;
//            set => Nombre = value;
//        }

//        public string bancoTarjeta
//        {
//            get => Banco;
//            set => Banco = value;
//        }
//    }
//}
{ 
    public class Tarjeta
    {
        public int codTarjeta { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int banco { get; set; }
        public string nombreBanco { get; set; }
        public int TipoEdicion { get; set; }

        public Tarjeta(int codTarjeta, string nombre, string descripcion, int banco, string nombreBanco,  int TipoEdicion)
        {
            this.codTarjeta = codTarjeta;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.banco = banco;
            this.nombreBanco = nombreBanco;
            this.TipoEdicion = TipoEdicion;
        }
    }
}
