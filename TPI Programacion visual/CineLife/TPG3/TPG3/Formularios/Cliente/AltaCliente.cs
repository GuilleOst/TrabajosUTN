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

namespace TPG3.Formularios.Cliente
{
    public partial class AltaCliente : Form
    {
        private Entidades.Cliente cliente;
        public AltaCliente(Entidades.Cliente cli)
        {
            cliente = cli;
            InitializeComponent();
            cargarFormulario(cli);
        }
        private void limpiarEspacios()
        {
            mtbDni.Text = mtbDni.Text.Replace("_", "");
            mtbTelefono.Text = mtbTelefono.Text.Replace("_", "");
        }
        private void cargarFormulario(Entidades.Cliente editCliente)
        {
            if (editCliente.TipoEdicion > 1)
            {
                if (editCliente.TipoEdicion == 2)
                {
                    mtbDni.Text = editCliente.dni.ToString().Trim();
                    Componentes.ComboboxItem item = new Componentes.ComboboxItem();
                    item.Text = editCliente.nombreTipoDocumento;
                    item.Value = editCliente.tipoDocumento;
                    cbTipoDoc.Items.Add(item);
                    mtbDni.Enabled = false;
                    cbTipoDoc.Enabled = false;
                    cbTipoDoc.SelectedIndex = cbTipoDoc.FindString(editCliente.nombreTipoDocumento);
                    cbTipoDoc.SelectedValue = editCliente.tipoDocumento;
                    txtNombre.Text = editCliente.nombre;
                    txtApellido.Text = editCliente.apellido;
                    mtbNacimiento.Text = editCliente.fechaNacimiento.ToString();
                    mtbTelefono.Text = editCliente.telefono.Trim();
                    txtEmail.Text = editCliente.email;
                    lblTitulo.Text = "Modificar Cliente";
                    limpiarEspacios();
                }
                else
                {
                    cargarComboTiposDescuentos();
                }
            }
        }

        private void btnCargarPromocion_Click(object sender, EventArgs e)
        {
            //validamos los datos
            limpiarEspacios();
            bool valido = validarCampos();
            if (valido)
            {
                bool result = cargarCliente(cliente);
                if (result)
                {
                    if (cliente.TipoEdicion == 3)
                    {
                        MessageBox.Show("Cliente cargado con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("Cliente actualizado con éxito!");
                    }
                    lblError.Text = "";
                    btnListado_Click(sender, e);

                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void cargarComboTiposDescuentos()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM TipoDocumento";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cbTipoDoc.DataSource = tabla;
                cbTipoDoc.DisplayMember = "Nombre";
                cbTipoDoc.ValueMember = "idTipoDocumento";

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

        private bool validarCampos()
        {
            if (mtbDni.Text.Trim().Equals(""))
            {
                lblError.Text = "El campo Dni no puede estar vacío.";
                mtbDni.Focus();
                return false;
            }
            if (txtNombre.Text.Trim().Equals(""))
            {
                lblError.Text = "El campo Nombre no puede estar vacío.";
                txtNombre.Focus();
                return false;
            }
            if (txtApellido.Text.Trim().Equals(""))
            {
                lblError.Text = "El campo Apellido no puede estar vacío.";
                txtApellido.Focus();
                return false;
            }
            if (mtbTelefono.Text.Trim().Equals(""))
            {
                lblError.Text = "El campo Teléfono no puede estar vacío.";
                mtbTelefono.Focus();
                return false;
            }
            if (txtEmail.Text.Trim().Equals(""))
            {
                lblError.Text = "El campo Email no puede estar vacío.";
                txtEmail.Focus();
                return false;
            }
            if (mtbNacimiento.Text.Trim().Equals("_/_/____"))
            {
                lblError.Text = "El campo Nacimiento no puede estar vacío.";
                mtbNacimiento.Focus();
                return false;
            }
            return true;
        }

        public bool cargarCliente(Entidades.Cliente cliente)
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "";
            if (cliente.TipoEdicion > 1)
            {
                //Crear
                if (cliente.TipoEdicion == 3)
                {
                    consulta = "INSERT INTO Cliente (dni, tipoDocumento, nombre, apellido, fechaNacimiento, email, telefono)" +
                               "VALUES (@dni,@tipoDocumento,@nombre, @apellido, @fechaNacimiento, @email, @telefono)";
                    if (consulta == mtbDni.Text)
                    {
                        lblError.Text = "Este DNI ya existe, ingrese otro.";
                        mtbDni.Focus();
                        txtNombre.Enabled = false;
                        txtApellido.Enabled = false;
                        txtEmail.Enabled = false;
                        mtbTelefono.Enabled = false;
                        mtbNacimiento.Enabled = false;
                        cbTipoDoc.Enabled = false;
                        return true;
                    }
                }
                //Modificar
                else
                {
                    consulta = "UPDATE Cliente SET nombre=@nombre, apellido=@apellido, fechaNacimiento=@fechaNacimiento, " +
                               "email=@email, telefono=@telefono where dni = @dni and tipoDocumento=@tipoDocumento ";
                }
                try
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@apellido", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@fechaNacimiento", mtbNacimiento.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@telefono", mtbTelefono.Text);
                    cmd.Parameters.AddWithValue("@dni", mtbDni.Text);
                    if (cliente.TipoEdicion == 2) cmd.Parameters.AddWithValue("@tipoDocumento", cliente.tipoDocumento);
                    if (cliente.TipoEdicion == 3) cmd.Parameters.AddWithValue("@tipoDocumento", cbTipoDoc.SelectedValue);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    cn.Close();
                }
            }
            else
            {
                try
                {
                    consulta = "DELETE FROM Cliente WHERE dni = @dni and tipoDocumento = @tipoDocumento";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@dni", cliente.dni);
                    cmd.Parameters.AddWithValue("@tipoDocumento", cliente.tipoDocumento);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    cn.Close();
                }
            }
            return true;

        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            Main.main1.btnSubCliente_Click(sender, e);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            btnListado_Click(sender, e);
        }
    }
}
