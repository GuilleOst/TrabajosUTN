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
    public partial class AltaMedioPago : Form
    {
        private Entidades.MedioPago medioPago;
        public AltaMedioPago(Entidades.MedioPago medioP)
        {
            medioPago = medioP;
            InitializeComponent();
            cargarFormulario(medioPago);
        }

        private void cargarFormulario(Entidades.MedioPago editMedioPago)
        {
            if (editMedioPago.TipoEdicion > 1)
            {
                if (editMedioPago.TipoEdicion == 2)
                {
                    txtNombre.Text = editMedioPago.nombre.ToString();
                    txtDescripcion.Text = editMedioPago.descripcion.ToString();
                    //Componentes.ComboboxItem item = new Componentes.ComboboxItem();
                    //item.Text = editMedioPago.nombreTarjeta;
                    //item.Value = editMedioPago.tarjeta;
                    //cbTipoDoc.Items.Add(item);
                    //cbTipoDoc.SelectedIndex = 0;
                    
                    lblTitulo.Text = "Modificar Medio de Pago";
                }
                cargarComboTarjeta(editMedioPago);
            }
        }

        private void btnCargarMP_Click(object sender, EventArgs e)
        {
            //validamos los datos
            bool valido = validarCampos();
            if (valido) {
                bool result = cargarMP(medioPago);
                if (result)
                {
                    if (medioPago.TipoEdicion == 3)
                    {
                        MessageBox.Show("Medio de Pago cargado con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("Medio de Pago actualizado con éxito.");
                    }
                    lblError.Text = "";
                    btnListadoMP_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private bool validarCampos()
        {
            if (txtNombre.Text.Trim().Equals(""))
            {
                lblError.Text = "El campo Nombre no puede estar vacío.";
                txtNombre.Focus();
                return false;
            }
            return true;
        }


        public bool cargarMP(Entidades.MedioPago medioPago)
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "";
            if (medioPago.TipoEdicion > 1)
            {
                try
                {
                    if (medioPago.TipoEdicion == 3)
                    {
                        consulta = "INSERT INTO MedioPago (nombre,descripcion,tarjeta)" +
                                      "VALUES (@nombre, @descripcion, @tarjeta)";
                    }
                    else
                    {
                        consulta = "UPDATE MedioPago set nombre=@nombre, descripcion=@descripcion, " +
                            "tarjeta=@tarjeta where codMedioPago=@codMedioPago";
                    };

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@tarjeta", cmbTarjeta.SelectedValue);
                    if (medioPago.TipoEdicion == 2) cmd.Parameters.AddWithValue("@codMedioPago", medioPago.codMedioPago);
                    //cmd.Parameters.AddWithValue("@tarjeta", int.Parse(txtTarjeta.Text));
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
                return true;
            }
            else
            {
                try
                {
                    consulta = "DELETE FROM MedioPago where codMedioPago=@codMedioPago ";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@codMedioPago", medioPago.codMedioPago);
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
                return true;
                
            }
        }

        private void AltaMedioPago_Load(object sender, EventArgs e)
        {
            cargarComboTarjeta(medioPago);
        }
        private void cargarComboTarjeta(Entidades.MedioPago medioPago)
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            string consulta = "";
            try
            {
                SqlCommand cmd = new SqlCommand();
                if (medioPago.TipoEdicion == 2){
                    consulta = "SELECT * FROM Tarjeta where codTarjeta <> @tarjeta";
                }
                else
                {
                    consulta = "SELECT * FROM Tarjeta";
                }
                
                cmd.Parameters.Clear();
                if (medioPago.TipoEdicion == 2) cmd.Parameters.AddWithValue("@tarjeta", medioPago.tarjeta);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable listaTarjeta = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(listaTarjeta);
                cmbTarjeta.DataSource = listaTarjeta;
                cmbTarjeta.DisplayMember = "nombre";
                cmbTarjeta.ValueMember = "codTarjeta";
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

        private void btnListadoMP_Click(object sender, EventArgs e)
        {
            Main.main1.btnSubMedioPago_Click(sender, e);
        }
    }
}
