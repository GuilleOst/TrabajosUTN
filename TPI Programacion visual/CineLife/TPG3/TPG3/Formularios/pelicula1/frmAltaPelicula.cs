using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinev3.Formularios.pelicula1
{
    public partial class frmAltaPelicula : Form
    {
        public frmAltaPelicula()
        {
            InitializeComponent();
            cargarComboOrigen();
            cargarComboGenero();
            cargarComboFormato();
            cargarComboCalificacion();
            CargarComboDistribuidora();
            cargarComboIdioma();
        }

        private void cargarComboOrigen()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Origen";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cboOrigen.DataSource = tabla;
                cboOrigen.DisplayMember = "nombre";
                cboOrigen.ValueMember = "idOrigen";
                cboOrigen.SelectedIndex = -1;


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
        private void cargarComboGenero()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Genero";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cboGenero.DataSource = tabla;
                cboGenero.DisplayMember = "descripcion";
                cboGenero.ValueMember = "codGenero";
                cboGenero.SelectedIndex = -1;


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
        private void cargarComboFormato()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Formato";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cboFormato.DataSource = tabla;
                cboFormato.DisplayMember = "descripcion";
                cboFormato.ValueMember = "codFormato";
                cboFormato.SelectedIndex = -1;


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
        private void cargarComboCalificacion()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT descripcion, abreviatura FROM Calificacion";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cboCalificacion.DataSource = tabla;
                cboCalificacion.DisplayMember = "descripcion";
                cboCalificacion.SelectedIndex = -1;


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
        private void cargarComboIdioma()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Idioma";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cboIdioma.DataSource = tabla;
                cboIdioma.DisplayMember = "descripcion";
                cboIdioma.ValueMember = "codIdioma";
                cboIdioma.SelectedIndex = -1;


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
        private void CargarComboDistribuidora()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Distribuidora";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cboDistribuidora.DataSource = tabla;
                cboDistribuidora.DisplayMember = "nombreDistribuidora";
                cboDistribuidora.ValueMember = "idDistribuidora";
                cboDistribuidora.SelectedIndex = -1;

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
