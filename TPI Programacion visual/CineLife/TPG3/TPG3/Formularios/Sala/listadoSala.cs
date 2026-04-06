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

namespace TPG3.Formularios.Sala
{
    public partial class listadoSala : Form
    {
        public listadoSala()
        {
            InitializeComponent();
        }

        private void listadoSala_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void cargarGrilla()
        {
            try
            {
                grdSala.DataSource = ObtenerTablaOrigen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las salas");
            }
        }
        public static DataTable ObtenerTablaOrigen()
        {
            //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            //Entidades.Sala sala = new Entidades.Sala(-1,-1,-1,false,"");
            var salas = new List<Entidades.Sala>();
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Sala";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                //if (dr != null && dr.Read())
                //{
                //    Entidades.Sala sala = new Entidades.Sala()
                //    {
                //        codigo = int.Parse(dr["codigo"].ToString()),
                //        numero = int.Parse(dr["numero"].ToString()),
                //        capacidadButacas = int.Parse(dr["capacidadButacas"].ToString()),
                //        formato = (dr["es3d"].ToString() == "0") ? "2D" : "3D"
                //    };
                //    salas.Add(sala);
                //}

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

        private void txtBuscadorSala_TextChanged(object sender, EventArgs e)
        {
            (grdSala.DataSource as DataTable).DefaultView.RowFilter = "Convert(numero, 'System.String') LIKE '" + txtBuscadorSala.Text + "%'";
        }
    }
}
