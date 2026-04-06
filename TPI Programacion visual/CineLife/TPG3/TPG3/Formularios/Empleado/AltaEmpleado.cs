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

namespace TPG3.Formularios.Empleado
{
    public partial class AltaEmpleado : Form
    {
        private Entidades.Empleado empleado;
        public AltaEmpleado(Entidades.Empleado emp)
        {
            empleado = emp;
            InitializeComponent();
            cargarFormulario(emp);
        }

        private void limpiarEspacios()
        {
            mtbDni.Text = mtbDni.Text.Replace("_","");
            mtbTelefono.Text = mtbTelefono.Text.Replace("_", "");            
        }

        private void cargarFormulario(Entidades.Empleado editEmpleado)
        {            
            if (editEmpleado.TipoEdicion > 1)
            {
                if (editEmpleado.TipoEdicion == 2)
                {
                    mtbDni.Text = editEmpleado.dni.ToString().Trim();
                    Componentes.ComboboxItem item = new Componentes.ComboboxItem();
                    item.Text = editEmpleado.nombreTipoDocumento;
                    item.Value = editEmpleado.tipoDocumento;
                    cbTipoDoc.Items.Add(item);
                    mtbDni.Enabled = false;
                    cbTipoDoc.Enabled = false;
                    cbTipoDoc.SelectedIndex = cbTipoDoc.FindString(editEmpleado.nombreTipoDocumento);
                    cbTipoDoc.SelectedValue = editEmpleado.tipoDocumento;
                    txtNombre.Text = editEmpleado.nombre;
                    txtApellido.Text = editEmpleado.apellido;
                    mtbTelefono.Text = editEmpleado.telefono.Trim();
                    txtEmail.Text = editEmpleado.email;
                    lblTitulo.Text = "Modificar Empleado";
                    limpiarEspacios();
                }
                else
                {
                    cargarComboTiposDocumentos();
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
                bool result = cargarEmpleado(empleado);
                if (result)
                {
                    if (empleado.TipoEdicion == 3)
                    {
                        MessageBox.Show("Empleado cargado con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("Empleado actualizado con éxito!");
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

        private void cargarComboTiposDocumentos()
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
            return true;
        }

        public bool cargarEmpleado(Entidades.Empleado empleado)
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "";
            if (empleado.TipoEdicion > 1)
            {
                //Crear
                if (empleado.TipoEdicion == 3)
                {
                    consulta = "INSERT INTO Empleado (dni, tipoDocumento, nombre, apellido, email, telefono)" +
                               "VALUES (@dni,@tipoDocumento,@nombre, @apellido, @email, @telefono)";
                }
                //Modificar
                else
                {
                    consulta = "UPDATE Empleado SET nombre=@nombre, apellido=@apellido, " +
                               "email=@email, telefono=@telefono where dni = @dni and tipoDocumento=@tipoDocumento ";
                }
                try
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@apellido", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@telefono", mtbTelefono.Text);
                    cmd.Parameters.AddWithValue("@dni", mtbDni.Text);
                    if (empleado.TipoEdicion == 2)cmd.Parameters.AddWithValue("@tipoDocumento", empleado.tipoDocumento);
                    if (empleado.TipoEdicion == 3) cmd.Parameters.AddWithValue("@tipoDocumento", cbTipoDoc.SelectedValue);
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
                    consulta = "DELETE FROM Empleado WHERE dni = @dni and tipoDocumento = @tipoDocumento";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@dni", empleado.dni);
                    cmd.Parameters.AddWithValue("@tipoDocumento", empleado.tipoDocumento);
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
            Main.main1.btnSubEmpleado_Click(sender, e);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            btnListado_Click(sender, e);
        }
    }

}

