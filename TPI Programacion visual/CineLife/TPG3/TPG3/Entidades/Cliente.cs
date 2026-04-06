using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class Cliente
    {
        public int dni { get; set; }
        public int tipoDocumento { get; set; }
        public string nombreTipoDocumento { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public int TipoEdicion { get; set; }

        public Cliente(int dni, int tipoDocumento, string nombreTipoDocumento, string nombre, string apellido, DateTime fechaNacimiento, string email, string telefono, int TipoEdicion)

        {
            this.dni = dni;
            this.tipoDocumento = tipoDocumento;
            this.nombreTipoDocumento = nombreTipoDocumento;
            this.nombre = nombre;  
            this.apellido = apellido;  
            this.fechaNacimiento = fechaNacimiento;
            this.email = email;
            this.telefono = telefono;  
            this.TipoEdicion = TipoEdicion;
        }
    }
}
