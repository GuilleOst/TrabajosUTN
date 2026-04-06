using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace TPG3.Formularios.Empleado
{
    public partial class ListadoEmpleado : Form
    {
        private void ListadoEmpelado_Load(object sender, EventArgs e)
        {
            seleccionar(cboBuscarTipoDoc);
            cargarGrilla();
            dgvEmpleados.Visible = false;
            btnEditarEmpleado.Enabled = false;
            btnEliminarEmpleado.Enabled = false;
        }
        private void ckbEmpleados_CheckedChanged(object sender, EventArgs e)
        {
            dgvEmpleados.Visible = ckbEmpleados.Checked;
            btnEditarEmpleado.Enabled = ckbEmpleados.Checked;
            btnEliminarEmpleado.Enabled = ckbEmpleados.Checked;
        }
        public ListadoEmpleado()
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
                string consulta = "SELECT TipoDocumento.nombre as 'tipoDoc',dni,TipoDocumento.idTipoDocumento as 'idTipoDocumento',Empleado.nombre, apellido, email, telefono  FROM Empleado " +
                "INNER JOIN TipoDocumento ON Empleado.tipoDocumento = TipoDocumento.idTipoDocumento";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                dgvEmpleados.DataSource = tabla;
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

        private void cboBuscarTipoDoc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            (dgvEmpleados.DataSource as DataTable).DefaultView.RowFilter = "Convert(dni, 'System.String') LIKE '" + txtBuscarDni.Text + "%' and Convert(tipoDoc, 'System.String') LIKE '" + cboBuscarTipoDoc.Text + "%'";
            dgvEmpleados.Visible = true;
            habilitarEdicion();
        }

        private void txtBuscarDni_TextChanged(object sender, EventArgs e)
        {
            (dgvEmpleados.DataSource as DataTable).DefaultView.RowFilter = "Convert(dni, 'System.String') LIKE '" + txtBuscarDni.Text + "%' and Convert(tipoDoc, 'System.String') LIKE '" + cboBuscarTipoDoc.Text + "%'";
            dgvEmpleados.Visible = true;
            habilitarEdicion();
            if (txtBuscarDni.Text == "")
            {
                dgvEmpleados.Visible = false;
                btnEditarEmpleado.Enabled = false;
                btnEliminarEmpleado.Enabled = false;
            }
        }
        private void btnCargarEmpleado_Click(object sender, EventArgs e)
        {
            //3 - Nuevo
            //2 - Editar
            //1 - Eliminar
            Entidades.Empleado empleado = new Entidades.Empleado(0, 0, "", "", "", "", "", 3);
            Main.main1.btnSubTicketAltaEmpleado(empleado);
        }
        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            var currentRow = dgvEmpleados.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvEmpleados.Rows[currentRow];
            string nombreTipoDocumento = dgvEmpleados.Rows[currentRow].Cells[1].Value.ToString();
            int dni = int.Parse(dgvEmpleados.Rows[currentRow].Cells[2].Value.ToString());
            int idTipoDocumento = int.Parse(dgvEmpleados.Rows[currentRow].Cells[3].Value.ToString());
            string nombre = dgvEmpleados.Rows[currentRow].Cells[4].Value.ToString();
            string apellido = dgvEmpleados.Rows[currentRow].Cells[5].Value.ToString();
            string email = dgvEmpleados.Rows[currentRow].Cells[6].Value.ToString();
            string telefono = dgvEmpleados.Rows[currentRow].Cells[7].Value.ToString();

            Entidades.Empleado empleado = new Entidades.Empleado(dni, idTipoDocumento, nombreTipoDocumento, nombre, apellido, email, telefono, 2);
            Main.main1.btnSubTicketAltaEmpleado(empleado);
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Desea eliminar este Empleado ??",
                                     "Confirmación!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var currentRow = dgvEmpleados.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dgvEmpleados.Rows[currentRow];
                int dni = int.Parse(dgvEmpleados.Rows[currentRow].Cells[2].Value.ToString());
                int idTipoDocumento = int.Parse(dgvEmpleados.Rows[currentRow].Cells[3].Value.ToString());
                Entidades.Empleado empleado = new Entidades.Empleado(dni, idTipoDocumento, "", "", "", "", "", 1);
                AltaEmpleado altaEmp = new AltaEmpleado(empleado);
                var result = altaEmp.cargarEmpleado(empleado);
                if (result)
                {
                    MessageBox.Show("Empleado eliminado con éxito!");
                    cargarGrilla();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                btnEditarEmpleado.Enabled = true;
                btnEliminarEmpleado.Enabled = true;
            }
        }
    }
}


