using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPG3;


namespace Cinev3.Formularios.pelicula1
{
    public partial class frmListadoPelicula : Form
    {
        public frmListadoPelicula()
        {
            InitializeComponent();
            MostrarPelicula();
        }

        private void btnAgregarPelicula_Click(object sender, EventArgs e)
        {
            Entidades.Pelicula1 pelicula = new Entidades.Pelicula1(0,"","","","",0,0,0,0,0,0,0,0);
            frmAltaPelicula frm = new frmAltaPelicula();
            frm.ShowDialog();
        }
        private void MostrarPelicula()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = " SELECT p.codPelicula,p.titulo AS 'ptitulo',p.leyenda AS 'pleyenda',p.duracion,p.sinposis AS 'sinopsis',p.añoEstreno,o.nombre, c.abreviatura, f.descripcion AS 'fdescripcion', g.descripcion AS 'gdescripcion', d.nombreDistribuidora, i.descripcion AS 'idescripcion' " +
                                    "FROM Pelicula AS p " +
                                    "JOIN Origen AS o ON(o.idOrigen= p.origen) " +
                                    "JOIN Calificacion AS c ON(c.codCalificacion = p.calificacion) " +
                                    "JOIN Formato AS f ON(f.codFormato = p.formato) " +
                                    "JOIN Genero AS g ON(g.codGenero = p.genero) " +
                                    "JOIN Distribuidora AS d ON(d.idDistribuidora = p.distribuidora) " +
                                    "JOIN Idioma AS i ON(i.codIdioma = p.idioma) ";
                                   

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                
                dgvPelicula.DataSource = tabla;

            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                cn.Close();
            }
        }
    }
}
