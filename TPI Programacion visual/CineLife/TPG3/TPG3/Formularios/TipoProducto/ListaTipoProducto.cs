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

namespace TPG3.Formularios.TipoProducto
{
    public partial class ListaTipoProducto : Form
    {
        public ListaTipoProducto()
        {
            InitializeComponent();
        }

        private void ListaTipoProducto_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                grdBuscadorTipoProd.DataSource = ObtenerTablaOrigen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener tipos de productos.");
            }
        }
        public static DataTable ObtenerTablaOrigen()
        {
            //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT nombreTipoProd FROM TipoProducto";

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

        private void txtBuscadorTipoProd_TextChanged(object sender, EventArgs e)
        {
            (grdBuscadorTipoProd.DataSource as DataTable).DefaultView.RowFilter = "Convert(nombreTipoProd, 'System.String') LIKE '" + txtBuscadorTipoProd.Text + "%'";
        }
    }
}
