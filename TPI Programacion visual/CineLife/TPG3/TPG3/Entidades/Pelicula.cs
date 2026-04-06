using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class Peliculas
    {
        private int codPelicula;
        private string titulo;
        private string leyenda;
        private string duracion;
        private string sinopsis;
        private int añoEstreno;
        private int origen;
        private int calificacion;
        private int formato;
        private int genero;
        private int distribuidora;
        private int idioma;


        public Peliculas()
        {

        }

        public Peliculas(int codPelicula, string titulo, string leyenda, string duracion, string sinopsis, int añoEstreno, int origen, int calificacion, int formato, int genero, int distribuidora, int idioma)
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
        }

        public int CodPelicula { get => codPelicula; set => codPelicula = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Leyenda { get => leyenda; set => leyenda = value; }
        public string Duracion { get => duracion; set => duracion = value; }
        public string Sinopsis { get => sinopsis; set => sinopsis = value; }
        public int AñoEstreno { get => añoEstreno; set => añoEstreno = value; }
        public int Origen { get => origen; set => origen = value; }
        public int Calificacion { get => calificacion; set => calificacion = value; }
        public int Formato { get => formato; set => formato = value; }
        public int Genero { get => genero; set => genero = value; }
        public int Distribuidora { get => distribuidora; set => distribuidora = value; }
        public int Idioma { get => idioma; set => idioma = value; }
    }
}
