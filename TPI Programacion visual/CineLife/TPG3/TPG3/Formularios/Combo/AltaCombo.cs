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

namespace TPG3.Formularios.Combo
{
    public partial class AltaCombo : Form
    {
        private Entidades.Producto combo;
        private List<int> viejosProductos;
        private List<int> nuevosProductos;
        public AltaCombo(Entidades.Producto prod)
        {
            combo = prod;
            viejosProductos = new List<int>();
            viejosProductos.Add(-1);
            nuevosProductos = new List<int>();
            nuevosProductos.Add(-1);
            InitializeComponent();
            completarFormulario(combo);            
        }

        private void completarFormulario(Entidades.Producto combo)
        {
            if (combo.TipoEdicion == 2)
            {
                txtNombreCombo.Text = combo.nombre;
                txtDescripcionCombo.Text = combo.descripcion;
                txtPrecioCombo.Text = combo.precio.ToString();
                txtCantidadCombo.Text = combo.cantidadItems.ToString();
                txtIdProducto.Text = combo.idProducto.ToString();
                btnAgregarCombo.Visible = false;
            }
            else
            {
                btnActualizarCombo.Visible=false;
            }
            mostrarComponentesCombo(combo, false);
            mostrarProductosDisponibles(combo, false);
        }

        private void mostrarComponentesCombo(Entidades.Producto combo, bool quita)
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select prod.nombre,prod.idProducto, cd.cantidad, prod.precio, " +
                "(cd.cantidad * prod.precio) as 'total' from Producto prod INNER JOIN ComposicionDeCombo cd " +
                "on prod.idProducto = cd.idProductoSimple and cd.idProductoCombo = @idCombo ";

                cmd.Parameters.Clear();
                if (quita) {
                    consulta = (String.Format(consulta + "where prod.idProducto not IN ({0})", String.Join(",", viejosProductos)));
                }
                
                cmd.Parameters.AddWithValue("@idCombo", combo.idProducto);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                dgvMisProductos.DataSource = tabla;

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

        private void mostrarProductosDisponibles(Entidades.Producto combo, bool quita)
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select prod.nombre,prod.idProducto,  prod.precio from Producto prod " +
                "where prod.TipoProducto <> 1 and (prod.idProducto NOT IN (select prod2.idProducto from Producto prod2 INNER JOIN ComposicionDeCombo cd  " +
                "on prod2.idProducto = cd.idProductoSimple and cd.idProductoCombo = @idCombo)";
                cmd.Parameters.Clear();
                if (quita)
                {
                    consulta = (String.Format(consulta + " and prod.idProducto not in ({0}))", String.Join(",", nuevosProductos)));
                    consulta = (String.Format(consulta + " or prod.idProducto IN ({0})", String.Join(",", viejosProductos)));
                }
                else
                {
                    consulta += ")";
                }

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCombo", combo.idProducto);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                dgvProductosDispo.DataSource = tabla;

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

        private void AltaCombo_Load(object sender, EventArgs e)
        {
                        
        }

        private void LimpiarCampo()
        {
            txtNombreCombo.Text = "";
            txtPrecioCombo.Text = "";
            txtDescripcionCombo.Text = "";
            txtCantidadCombo.Text = "";
        }

        private int cantidadProductos()
        {
            var count = 0;
            count += dgvMisProductos.Rows.Count;
            count += dgvNuevosProductos.Rows.Count;
            return count;
        }

        private float precioActual()
        {
            float cantidad = 0;
            float precio = 0;
            float total = 0;
            for (int i = 0; i < dgvMisProductos.Rows.Count; i++)
            {
                cantidad = float.Parse(dgvMisProductos.Rows[i].Cells[2].Value.ToString());
                precio = float.Parse(dgvMisProductos.Rows[i].Cells[3].Value.ToString());
                total += cantidad * precio;
            }
            for (int i = 0; i < dgvNuevosProductos.Rows.Count; i++)
            {
                cantidad = float.Parse(dgvNuevosProductos.Rows[i].Cells[2].Value.ToString());
                precio = float.Parse(dgvNuevosProductos.Rows[i].Cells[3].Value.ToString());
                total += cantidad * precio;
            }
            return total;
        }

        private int cantItems()
        {
            int cantidad = 0;
            for (int i = 0; i < dgvMisProductos.Rows.Count; i++)
            {
                cantidad += int.Parse(dgvMisProductos.Rows[i].Cells[2].Value.ToString());
            }
            for (int i = 0; i < dgvNuevosProductos.Rows.Count; i++)
            {
                cantidad += int.Parse(dgvNuevosProductos.Rows[i].Cells[2].Value.ToString());
            }
            return cantidad;
        }

        private bool validarCampos()
        {
            if (txtNombreCombo.Equals(""))
            {
                lblError.Text = "El campo Nombre no puede estar vacío.";
                txtNombreCombo.Focus();
                return false;
            }
            if (txtDescripcionCombo.Equals(""))
            {
                lblError.Text = "El campo Descripción no puede estar vacío.";
                txtDescripcionCombo.Focus();
                return false;
            }
            if (txtPrecioCombo.Equals(""))
            {
                lblError.Text = "El campo Precio no puede estar vacío.";
                txtPrecioCombo.Focus();
                return false;
            }
            var cantidad = cantidadProductos();
            if (cantidad <= 0)
            {
                lblError.Text = "No puede cargar una promoción sin productos!";
                dgvMisProductos.Focus();
                return false;
            }
            var precioItems = precioActual();
            var precioCombo = float.Parse(txtPrecioCombo.Text);
            //if (precioItems < precioCombo)
            //{
            //    lblError.Text = "El Precio del Combo no puede ser mayor a la suma de los precios unitarios por las cantidades.";
            //    return false;
            //}
            return true;
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampo();
        }

        public bool cargarCombo(Entidades.Producto producto)
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "";
            if (producto.TipoEdicion > 1)
            {
                //Crear
                if (producto.TipoEdicion == 3)
                {
                    consulta = "INSERT INTO Producto (nombre, descripcion, tipoProducto, precio)" +
                               "VALUES (@nombre,@descripcion,1, @precio)";
                }
                //Modificar
                else
                {
                    consulta = "UPDATE Producto SET nombre=@nombre, descripcion=@descripcion, " +
                               "precio=@precio where idProducto = @idProducto";
                }
                try
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nombre", producto.nombre);
                    cmd.Parameters.AddWithValue("@descripcion", producto.descripcion);
                    cmd.Parameters.AddWithValue("@precio", producto.precio);
                    
                    if (producto.TipoEdicion == 2) cmd.Parameters.AddWithValue("@idProducto", producto.idProducto);
                    
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

                if (producto.TipoEdicion == 2)
                {
                    try
                    {
                        consulta = "DELETE FROM ComposicionDeCombo where idProductoCombo = @idProductoCombo";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@idProductoCombo", producto.idProducto);
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = consulta;
                        cn.Open();
                        cmd.Connection = cn;
                        cmd.ExecuteNonQuery();
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
                else
                {
                    try
                    {
                        consulta = "SELECT TOP 1 idProducto FROM Producto order by idProducto DESC";
                        cmd.Parameters.Clear();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = consulta;

                        cn.Open();
                        cmd.Connection = cn;
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr != null && dr.Read())
                        {
                            producto.idProducto = int.Parse(dr["idProducto"].ToString());
                        };

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
                if (dgvMisProductos.Rows.Count > 0)
                {
                    try
                    {
                        cn.Open();
                        consulta = "INSERT INTO ComposicionDeCombo (idProductoCombo, idProductoSimple, cantidad) " +
                            "VALUES (@idProductoCombo, @idProductoSimple, @cantidad)";
                        for (int i = 0; i < dgvMisProductos.Rows.Count; i++)
                        {
                            int prodSimple = int.Parse(dgvMisProductos.Rows[i].Cells[1].Value.ToString());
                            int cantidad = int.Parse(dgvMisProductos.Rows[i].Cells[2].Value.ToString());
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@idProductoCombo", producto.idProducto);
                            cmd.Parameters.AddWithValue("@idProductoSimple", prodSimple);
                            cmd.Parameters.AddWithValue("@cantidad", cantidad);
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = consulta;
                            cmd.Connection = cn;
                            cmd.ExecuteNonQuery();
                        }
                        cn.Close();
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
                if (dgvNuevosProductos.Rows.Count > 0)
                {
                    try
                    {
                        cn.Open();
                        consulta = "INSERT INTO ComposicionDeCombo (idProductoCombo, idProductoSimple, cantidad) " +
                            "VALUES (@idProductoCombo, @idProductoSimple, @cantidad)";
                        for (int i = 0; i < dgvNuevosProductos.Rows.Count; i++)
                        {
                            
                            int prodSimple = int.Parse(dgvNuevosProductos.Rows[i].Cells[1].Value.ToString());
                            int cantidad = int.Parse(dgvNuevosProductos.Rows[i].Cells[2].Value.ToString());
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@idProductoCombo", producto.idProducto);
                            cmd.Parameters.AddWithValue("@idProductoSimple", prodSimple);
                            cmd.Parameters.AddWithValue("@cantidad", cantidad);
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = consulta;
                            cmd.Connection = cn;
                            cmd.ExecuteNonQuery();
                        }
                        cn.Close();
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

            }
            else
            {
                try
                {
                    consulta = "DELETE FROM ComposicionDeCombo WHERE idProductoCombo = @idProducto";
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
                try
                {
                    consulta = "DELETE FROM Producto WHERE idProducto = @idProducto";
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
            }
            return true;
        }

        private void btnAgregarCombo_Click(object sender, EventArgs e)
        {
            
            bool valido = validarCampos();
            if (valido)
            {
                combo.nombre = txtNombreCombo.Text;
                combo.descripcion = txtDescripcionCombo.Text;
                combo.precio = float.Parse(txtPrecioCombo.Text);
                combo.cantidadItems = cantItems();
                combo.TipoEdicion = 3;
                bool result = cargarCombo(combo);
                if (result)
                {
                    MessageBox.Show("Combo cargado con éxito!");
                    Main.main1.btnSubCombo_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error!", "Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private Entidades.Producto ObtenerDatosNombreCombo()
        {
            Entidades.Producto nombreCombo = new Entidades.Producto(-1, "", "", -1, 0, 0, -1);

            nombreCombo.TipoProducto = 1;
            nombreCombo.Nombre = txtNombreCombo.Text.Trim();
            nombreCombo.Descripcion = txtDescripcionCombo.Text.Trim();
            nombreCombo.Precio = float.Parse(txtPrecioCombo.Text);


            return nombreCombo;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var currentRow = dgvProductosDispo.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvProductosDispo.Rows[currentRow];
            string nombreCombo = (dgvProductosDispo.Rows[currentRow].Cells[0].Value.ToString());
            int idProducto = int.Parse(dgvProductosDispo.Rows[currentRow].Cells[1].Value.ToString());
            float precio = float.Parse(dgvProductosDispo.Rows[currentRow].Cells[2].Value.ToString());
            if (viejosProductos.Contains(idProducto)) viejosProductos.Remove(idProducto);
            nuevosProductos.Add(idProducto);
            dgvNuevosProductos.Rows.Add(nombreCombo, idProducto, 1, precio);
            mostrarProductosDisponibles(combo, true);            
        }

        private void btnProductoViejo_Click(object sender, EventArgs e)
        {
            var currentRow = dgvMisProductos.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvMisProductos.Rows[currentRow];
            int idProducto = int.Parse(dgvMisProductos.Rows[currentRow].Cells[1].Value.ToString());

            viejosProductos.Add(idProducto);
            mostrarComponentesCombo(combo, true);
            mostrarProductosDisponibles(combo, true);
        }


        private void btnActualizarCombo_Click(object sender, EventArgs e)
        {
            bool valido = validarCampos();
            if (valido)
            {
                combo.idProducto = int.Parse(txtIdProducto.Text);
                combo.nombre = txtNombreCombo.Text;
                combo.descripcion = txtDescripcionCombo.Text;
                combo.precio = float.Parse(txtPrecioCombo.Text);
                combo.cantidadItems = cantItems();
                combo.TipoEdicion = 2;
                bool result = cargarCombo(combo);
                if (result)
                {
                    MessageBox.Show("Combo actualizado con éxito!");
                    Main.main1.btnSubCombo_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnProductoNuevo_Click(object sender, EventArgs e)
        {
            var currentRow = dgvNuevosProductos.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvNuevosProductos.Rows[currentRow];
            int idProducto = int.Parse(dgvNuevosProductos.Rows[currentRow].Cells[1].Value.ToString());
            viejosProductos.Add(idProducto);
            mostrarProductosDisponibles(combo, true);
            dgvNuevosProductos.Rows.RemoveAt(currentRow);
        }
    }
}
