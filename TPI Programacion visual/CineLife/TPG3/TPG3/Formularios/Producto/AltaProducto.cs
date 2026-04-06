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
using TPG3.Entidades;

namespace TPG3.Formularios.Producto
{
    public partial class AltaProducto : Form
    {
        private Entidades.Producto producto;
        public AltaProducto(Entidades.Producto prod)
        {
            this.producto = prod;
            InitializeComponent();
        }
        private void AltaProducto_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizar.Enabled = false;
            CargarComboTipoProducto();
            CargarGrilla();
            lblError.Visible = false;
        }

        
        private void LimpiarCampos()
        {
            txtPrecio1.Text = "";
            txtNombreProducto.Text = "";
            txtDescripcion1.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool camposCorrectos = validarCamposNoVacios();
                
            if (camposCorrectos)
            {
                Entidades.Producto p = ObtenerDatosProducto();


                bool resultado = AD_Producto.AgregarProductoABD(p);

                if (resultado)
                {
                    MessageBox.Show("Producto agregado con éxito");
                    LimpiarCampos();
                    CargarComboTipoProducto();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al cargar el producto");
                }
            }
            else
            {
                MessageBox.Show("Datos Incorrectos, Ingrese nuevamente los Datos");
            }
            
        }

        private Entidades.Producto ObtenerDatosProducto()
        {
            Entidades.Producto prod = new Entidades.Producto(-1,"","",-1,0,0,-1);

            prod.TipoProducto = (int)cmbTipoProducto1.SelectedValue;
            prod.Nombre = txtNombreProducto.Text.Trim();
            prod.Descripcion = txtDescripcion1.Text.Trim();
            prod.Precio = float.Parse(txtPrecio1.Text);
            

            return prod;
        }

        private void CargarComboTipoProducto()
        {
            try
            {
                cmbTipoProducto1.DataSource = AD_Producto.ObtenerTipoProducto();
                cmbTipoProducto1.DisplayMember = "nombreTipoProd";
                cmbTipoProducto1.ValueMember = "idTipoProducto";
                cmbTipoProducto1.SelectedIndex = 0;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo tipo producto");
            }
        }
        private void CargarGrilla()
        {
            try
            {
                gdrActualizarProd.DataSource = AD_Producto.ObtenerTablaProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener productos");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Entidades.Producto p = ObtenerDatosProducto();
            bool camposCorrectos = validarCamposNoVacios();

            if (camposCorrectos)
            {
                bool resultado = ActualizarProducto(p);
                if (resultado)
                {
                    MessageBox.Show("Producto actualizado con éxito");
                    LimpiarCampos();
                    CargarGrilla();
                    CargarComboTipoProducto();
                }
                else
                {
                    MessageBox.Show("Error al actualizar producto");
                };
            }
            else
            {
                MessageBox.Show("Datos Incorrectos, Ingrese nuevamente los Datos");
            }
        }

        private bool ActualizarProducto(Entidades.Producto p)
        {
            bool resultado = false;
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE Producto SET nombre = @nombre, descripcion = @descripcion, tipoProducto = @tipoProducto, precio = @precio WHERE nombre LIKE @nombre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", p.Descripcion);
                cmd.Parameters.AddWithValue("@tipoProducto", p.TipoProducto);
                cmd.Parameters.AddWithValue("@precio", p.Precio);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public bool eliminarProductoCombo(Entidades.Producto producto)
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            var consulta = "";
            try
            {
                SqlCommand cmd = new SqlCommand();

                consulta = "DELETE FROM ComposicionDeCombo WHERE idProductoSimple = @idProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProducto", producto.idProducto);
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
            bool result = eliminarProducto(producto);
            return result;
        }

        public bool eliminarProducto(Entidades.Producto producto)
        {
            bool resultado = false;
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                var consulta = "DELETE FROM Producto WHERE idProducto = @idProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProducto", producto.idProducto);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public bool estaEnCombo(Entidades.Producto producto)
        {            
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                var consulta = "SELECT Producto.idProducto from Producto where idProducto = @idProducto " +
                "and idProducto in (select idProductoSimple from ComposicionDeCombo)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProducto", producto.idProducto);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                bool existe = false;
                if (dr != null && dr.Read())
                {
                    existe = true;
                }
                return existe;
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

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void gdrActualizarProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            int indice = e.RowIndex;
            btnActualizar.Enabled = true;
            DataGridViewRow filaSeleccionada = gdrActualizarProd.Rows[indice];

            int idProducto = (int)filaSeleccionada.Cells["IdProducto"].Value;
            Entidades.Producto p = ObtenerProducto(idProducto);
            LimpiarCampos();
            CargarCampos(p);
        }

        private Entidades.Producto ObtenerProducto(int idProducto)
        {
            Entidades.Producto p = new Entidades.Producto(-1, "", "", -1, 0, 0, -1);
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Producto WHERE idProducto LIKE @idProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProducto", idProducto);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    p.Nombre = dr["nombre"].ToString();
                    p.Descripcion = dr["descripcion"].ToString();
                    p.Precio = float.Parse(dr["precio"].ToString());
                    p.TipoProducto = int.Parse(dr["tipoProducto"].ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return p;

        }

        private void CargarCampos(Entidades.Producto p)
        {
            cmbTipoProducto1.SelectedValue = p.TipoProducto;
            txtNombreProducto.Text = p.Nombre;
            txtDescripcion1.Text = p.Descripcion;
            txtPrecio1.Text = p.Precio.ToString();
        }

        private bool validarCamposNoVacios()
        {
            if (txtNombreProducto.Text.Trim().Equals(""))
            {
                lblError.Visible = true;
                lblError.Text = " El campo Nombre Producto no puede estar vacío.";
                txtNombreProducto.Focus();
                return false;
            }
            int parsedValue;
            if (!int.TryParse(txtPrecio1.Text, out parsedValue))
            {
                lblError.Visible = true;
                lblError.Text = "El campo Precio solo debe contener números.";
                txtPrecio1.Focus();
            }
            if (txtPrecio1.Text.Trim().Equals(""))
            {
                lblError.Visible = true;
                lblError.Text = "El campo Precio no puede estar vacío o tener un valor menor a cero.";
                txtPrecio1.Focus();
                return false;
            }
            if (txtDescripcion1.Text.Trim().Equals(""))
            {
                lblError.Visible = true;
                lblError.Text = "El campo Descripción no puede estar vacío.";
                txtDescripcion1.Focus();
                return false;
            }
            return true;
        }



    }
}
