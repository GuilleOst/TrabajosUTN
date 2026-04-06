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

namespace TPG3.Formularios.TipoDocumento
{
    public partial class ListadoTipoDocumento : Form
    {
        public ListadoTipoDocumento()
        {
            InitializeComponent();
        }

        private void ListadoTipoDocumento_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT nombre FROM TipoDocumento";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                dgvPromocion.DataSource = tabla;

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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            (dgvPromocion.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre LIKE '%{0}%' or Nombre LIKE '% {0}%'", txtBuscar.Text);
        }
    }
}
