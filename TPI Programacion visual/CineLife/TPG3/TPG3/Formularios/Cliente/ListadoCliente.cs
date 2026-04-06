using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace TPG3.Formularios.Cliente
{
    public partial class ListadoCliente : Form
    {
        private void ListadoCliente_Load(object sender, EventArgs e)
        {
            seleccionar(cboBuscarTipoDoc);
            cargarGrilla();
            dgvClientes.Visible = false;
            btnEditarCliente.Enabled = false;
            btnEliminarCliente.Enabled = false;

        }
        private void ckbClientes_CheckedChanged(object sender, EventArgs e)
        {
            dgvClientes.Visible = ckbClientes.Checked;
            btnEditarCliente.Enabled = ckbClientes.Checked;
            btnEliminarCliente.Enabled = ckbClientes.Checked;

        }
        public ListadoCliente()
        {
            InitializeComponent();
        }
        private void cargarGrilla()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string query = "SELECT c.tipoDocumento,t.nombre as 'tipoDoc', dni,c.nombre, c.apellido,c.fechaNacimiento, " +
                "c.email,c.telefono FROM Cliente c " +
                "INNER JOIN TipoDocumento AS t ON(c.tipoDocumento = t.idTipoDocumento) ";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                dgvClientes.DataSource = tabla;
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
        private void cboBuscarTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            (dgvClientes.DataSource as DataTable).DefaultView.RowFilter = "Convert(dni, 'System.String') LIKE '" + txtBuscarDni.Text + "%' and Convert(tipoDoc, 'System.String') LIKE '" + cboBuscarTipoDoc.Text + "%'";
            dgvClientes.Visible = true;
            habilitarEdicion();
        }

        private void txtBuscarDniTextChanged(object sender, EventArgs e)
        {
            (dgvClientes.DataSource as DataTable).DefaultView.RowFilter = "Convert(dni, 'System.String') LIKE '" + txtBuscarDni.Text + "%' and Convert(tipoDoc, 'System.String') LIKE '" + cboBuscarTipoDoc.Text + "%'";
            dgvClientes.Visible = true;
            habilitarEdicion();
            if (txtBuscarDni.Text == "")
            {
                dgvClientes.Visible = false;
                btnEditarCliente.Enabled = false;
                btnEliminarCliente.Enabled = false;
            }
        }
        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
            Entidades.Cliente cliente = new Entidades.Cliente(0, 0, "", "", "", DateTime.Today, "", "", 3);
            Main.main1.btnSubTicketAltaCliente(cliente);
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            var currentRow = dgvClientes.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvClientes.Rows[currentRow];
            int idTipoDocumento = int.Parse(dgvClientes.Rows[currentRow].Cells[0].Value.ToString());
            string nombreTipoDocumento = (dgvClientes.Rows[currentRow].Cells[1].Value.ToString());
            int dni = int.Parse(dgvClientes.Rows[currentRow].Cells[2].Value.ToString());
            string nombre = dgvClientes.Rows[currentRow].Cells[3].Value.ToString();
            string apellido = dgvClientes.Rows[currentRow].Cells[4].Value.ToString();
            DateTime fechaNacimiento = DateTime.Parse(dgvClientes.Rows[currentRow].Cells[5].Value.ToString());
            string email = dgvClientes.Rows[currentRow].Cells[6].Value.ToString();
            string telefono = dgvClientes.Rows[currentRow].Cells[7].Value.ToString();

            Entidades.Cliente cliente = new Entidades.Cliente(dni, idTipoDocumento, nombreTipoDocumento, nombre, apellido, fechaNacimiento, email, telefono, 2);
            Main.main1.btnSubTicketAltaCliente(cliente);
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿ Desea eliminar a este Cliente ?", "Confirmación!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var currentRow = dgvClientes.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dgvClientes.Rows[currentRow];
                int dni = int.Parse(dgvClientes.Rows[currentRow].Cells[2].Value.ToString());
                int idTipoDocumento = int.Parse(dgvClientes.Rows[currentRow].Cells[0].Value.ToString());
                Entidades.Cliente cliente = new Entidades.Cliente(dni, idTipoDocumento, "", "", "", DateTime.Today, "", "", 1);
                AltaCliente altaCli = new AltaCliente(cliente);
                bool result = altaCli.cargarCliente(cliente);
                if (result)
                {
                    MessageBox.Show("El Cliente ha sido eliminado con Éxito");
                    cargarGrilla();
                }
                else
                {
                    MessageBox.Show("Se ha producido un Error", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void seleccionar(ComboBox cboBuscarTipoDni)
        {
            SqlConnection con = new SqlConnection("Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074");
            cboBuscarTipoDni.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TipoDocumento", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboBuscarTipoDni.Items.Add(dr[1].ToString());
            }
            con.Close();
            cboBuscarTipoDni.SelectedIndex = -1;
        }

        private void habilitarEdicion()
        {
            if (txtBuscarDni.Text != "" || cboBuscarTipoDoc.Text != "")
            {
                btnEditarCliente.Enabled = true;
                btnEliminarCliente.Enabled = true;
            }
        }
    }
}
