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

namespace TPG3.Formularios.Formato
{
    public partial class listaFormato : Form
    {
        public listaFormato()
        {
            InitializeComponent();
        }
        private void listaFormato_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void CargarGrilla()
        {
            try
            {
                grdBuscadorFormato.DataSource = ObtenerTablaOrigen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener tipos de formato.");
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

                string consulta = "SELECT descripcion FROM Formato";

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

        private void txtBuscadorFormatos_TextChanged(object sender, EventArgs e)
        {
            (grdBuscadorFormato.DataSource as DataTable).DefaultView.RowFilter = "Convert(descripcion, 'System.String') LIKE '" + txtBuscadorFormatos.Text + "%'";
        }

       
    }
}
