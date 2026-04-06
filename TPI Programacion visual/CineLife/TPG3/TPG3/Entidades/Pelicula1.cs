using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinev3.Entidades
{
        public class Pelicula1
        {
            private int codPelicula { get; set; }
            private string titulo { get; set; }
            private string leyenda { get; set; }
            private string duracion { get; set; }
            private string sinopsis { get; set; }
            private int añoEstreno { get; set; }
            private int origen { get; set; }
            private int calificacion { get; set; }
            private int formato { get; set; }
            private int genero { get; set; }
            private int distribuidora { get; set; }
            private int idioma { get; set; }
            public int TipoEdicion { get; set; }

            public Pelicula1(int codPelicula, string titulo, string leyenda, string duracion, string sinopsis, int añoEstreno, int origen, int calificacion, int formato, int genero, int distribuidora, int idioma,int TipoEdicion)
            {
                this.codPelicula = codPelicula;
                this.titulo = titulo;
                this.leyenda = leyenda;
                this.duracion = duracion;
                this.sinopsis = sinopsis;
                this.añoEstreno = añoEstreno;
                this.origen = origen;
                this.calificacion = calificacion;
                this.formato = formato;
                this.genero = genero;
                this.distribuidora = distribuidora;
                this.idioma = idioma;
                this.TipoEdicion = TipoEdicion;
            }
        }
}
