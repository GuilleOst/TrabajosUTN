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

namespace TPG3.Formularios.MedioPago
{
    public partial class ListaMedioPago : Form
    {
        public ListaMedioPago()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dgvMedioPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaMedioPago_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void cargarTabla()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT MedioPago.codMedioPago as 'Codigo', MedioPago.nombre as 'Nombre', "+
                    "MedioPago.descripcion as 'Descripcion', MedioPago.tarjeta as 'Tarjeta', Tarjeta.nombre as 'Nombre Tarjeta' "+
                    "FROM MedioPago INNER JOIN Tarjeta ON MedioPago.Tarjeta = Tarjeta.codTarjeta";
                //string consulta = "SELECT codMedioPago, nombre, descripcion, tarjeta FROM MedioPago";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tablaMP = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tablaMP);
                dgvMedioPago.DataSource = tablaMP;
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

        private void btnCargarMP_Click(object sender, EventArgs e)
        {
            Entidades.MedioPago medio = new Entidades.MedioPago(-1,"", "",-1,"",3);

            Main.main1.btnSubMedioPagoAltaMedioPago(medio);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var currentRow = dgvMedioPago.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvMedioPago.Rows[currentRow];
            int codigoMedioPago = int.Parse(dgvMedioPago.Rows[currentRow].Cells[0].Value.ToString());
            string nombre = dgvMedioPago.Rows[currentRow].Cells[1].Value.ToString();
            string descripcion = dgvMedioPago.Rows[currentRow].Cells[2].Value.ToString();
            int tarjeta = int.Parse(dgvMedioPago.Rows[currentRow].Cells[3].Value.ToString());
            string nombreTarjeta = dgvMedioPago.Rows[currentRow].Cells[4].Value.ToString();

            Entidades.MedioPago medio = new Entidades.MedioPago(codigoMedioPago,nombre,descripcion,tarjeta,nombreTarjeta,2);
            Main.main1.btnSubMedioPagoAltaMedioPago(medio);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Desea eliminar este Medio de Pago ??",
                                     "Confirmación!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var currentRow = dgvMedioPago.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dgvMedioPago.Rows[currentRow];
                int codigoMedioPago = int.Parse(dgvMedioPago.Rows[currentRow].Cells[0].Value.ToString());
                Entidades.MedioPago medio = new Entidades.MedioPago(codigoMedioPago, "", "", 0, "", 1);
                AltaMedioPago altaMedioPago = new AltaMedioPago(medio);
                var result = altaMedioPago.cargarMP(medio);
                if (result)
                {
                    MessageBox.Show("Medio de Pago eliminado con éxito!");
                    cargarTabla();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
