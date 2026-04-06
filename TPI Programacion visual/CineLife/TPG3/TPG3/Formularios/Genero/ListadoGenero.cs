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
using TPG3.Entidades;

namespace TPG3.Formularios.Genero
{
    public partial class ListadoGenero : Form
    {
        public ListadoGenero()
        {
            InitializeComponent();
        }

        private void grdBuscadorGenero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListadoGenero_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                grdBuscadorGenero.DataSource = ObtenerTablaGenero();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener género");
            }
        }
        public static DataTable ObtenerTablaGenero()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT descripcion FROM Genero";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }

            catch (Exception ex)
            {

                throw;
            }

            finally
            {
                cn.Close();
            }
        }

        private void txtBuscadorGenero_TextChanged(object sender, EventArgs e)
        {
            (grdBuscadorGenero.DataSource as DataTable).DefaultView.RowFilter = "Convert(descripcion, 'System.String') LIKE '" + txtBuscadorGenero.Text + "%'";
        }
    }
}
