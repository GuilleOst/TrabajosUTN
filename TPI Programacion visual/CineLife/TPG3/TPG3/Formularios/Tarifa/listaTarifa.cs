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

namespace TPG3.Formularios.Tarifa
{
    public partial class listaTarifa : Form
    {
        public listaTarifa()
        {
            InitializeComponent();
        }

        private void listaTarifa_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            try
            {
                grdTarifa.DataSource = ObtenerTablaTarifa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener tarifas");
            }
        }

        public static DataTable ObtenerTablaTarifa()
        {
            //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT Tarifa.descripcion, Tarifa.valor, Formato.descripcion as 'descri' FROM Tarifa INNER JOIN Formato ON Tarifa.codFormato = Formato.codFormato";

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

        private void txtBuscadororigen_TextChanged(object sender, EventArgs e)
        {
            (grdTarifa.DataSource as DataTable).DefaultView.RowFilter = "Convert(descripcion, 'System.String') LIKE '" + txtBuscadorTarifa.Text + "%'";
        }
    }
}
