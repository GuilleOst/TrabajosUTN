using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class Calificacion
    {
        private int codCalificacion;
        private string descripcion;
        private string abreviatura;

        public Calificacion(int codCalificacion, string descripcion, string abreviatura)
        {
            this.codCalificacion = codCalificacion;
            this.descripcion = descripcion;
            this.abreviatura = abreviatura;
        }

        public Calificacion()
        {

        }

        public int CodCalificacion { get => codCalificacion; set => codCalificacion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Abreviatura { get => abreviatura; set => abreviatura = value; }
    }
}
