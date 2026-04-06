using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class Actor
    {
        private int codActor;
        private string nombre;
        private string apellido;

        public Actor(int codActor, string nombre, string apellido)
        {
            this.codActor = codActor;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Actor()
        {

        }
            
        public int CodActor { get => codActor; set => codActor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
}
