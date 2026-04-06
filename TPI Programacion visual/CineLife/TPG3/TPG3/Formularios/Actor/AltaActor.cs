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

namespace TPG3.Formularios.Actores
{
    public partial class AltaActor : Form
    {
        public AltaActor(Entidades.Actor actor)
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void AltaActor_Load(object sender, EventArgs e)
        {
            btnActualizarActor.Enabled = false;
            lblError.Visible = false;
            LimpiarCampos();
            CargarGrilla();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
        }
        private void CargarGrilla()
        {
            try
            {
                dtgActualizarActor.DataSource = ObtenerTablaActor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener productos");
            }
        }

        public static DataTable ObtenerTablaActor()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Actor";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool camposCorrectos = validarCamposNoVacios();

            if (camposCorrectos)
            {
                Actor r = ObtenerDatosActor();

                bool resultado = AgregarActorABD(r);

                if (resultado)
                {
                    MessageBox.Show("Actor agregado con éxito");
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al cargar el actor");
                }
            }
            else
            {
                MessageBox.Show("Datos Incorrectos, Ingrese nuevamente los Datos");
            }

        }

        private Actor ObtenerDatosActor()
        {
            Actor actor = new Actor();

            actor.Nombre = txtNombre.Text.Trim();
            actor.Apellido = txtApellido.Text.Trim();
            actor.CodActor = int.Parse(txtCodActor.Text.Trim());
            return actor;
        }

        public static bool AgregarActorABD(Actor actor)
        {
            bool resultado = false;
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Actor (nombre, apellido) VALUES (@nombre, @apellido)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", actor.Nombre);
                cmd.Parameters.AddWithValue("@apellido", actor.Apellido);
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

        private void btnActualizarActor_Click(object sender, EventArgs e)
        {
            Actor r = ObtenerDatosActor();
            bool resultado = ActualizarActor(r);
            if (resultado)
            {
                MessageBox.Show("Actor actualizado con éxito");
                LimpiarCampos();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al actualizar actor");
            }
        }

        private bool ActualizarActor(Actor r)
        {
            bool resultado = false;
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                
                string consulta = "UPDATE Actor SET nombre = @nombre, apellido = @apellido WHERE codActor = @codActor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", r.Nombre);
                cmd.Parameters.AddWithValue("@apellido", r.Apellido);
                cmd.Parameters.AddWithValue("@codActor", r.CodActor);
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

        public bool eliminarActor(Actor r)
        {
            bool resultado = false;
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "delete Actor where codActor = @codActor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codActor", r.CodActor);
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

        private void dtgActualizarActor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizarActor.Enabled = true;
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                DataGridViewRow filaSeleccionada = dtgActualizarActor.Rows[indice];

                int codActor = (int)filaSeleccionada.Cells[0].Value;
                txtCodActor.Text = codActor.ToString();
                Actor r = ObtenerActor(codActor);
                LimpiarCampos();
                CargarCampos(r);
            };
           
        }

        private Actor ObtenerActor(int codActor)
        {
            Actor r = new Actor();
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Actor WHERE codActor LIKE @codActor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codActor", codActor);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    r.Nombre = dr["nombre"].ToString();
                    r.Apellido = dr["apellido"].ToString();
                    r.CodActor = codActor;
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

            return r;

        }

        private void CargarCampos(Actor r)
        {
            txtNombre.Text = r.Nombre;
            txtApellido.Text = r.Apellido;
        }

        private void btnLimpiarCamposActores_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private bool validarCamposNoVacios()
        {
            if (txtNombre.Text.Trim().Equals(""))
            {
                lblError.Visible = true;
                lblError.Text = " El campo Nombre del Actor no puede estar vacío.";
                txtNombre.Focus();
                return false;
            }
            if (txtApellido.Text.Trim().Equals(""))
            {
                lblError.Visible = true;
                lblError.Text = "El campo Precio no puede estar vacío o tener un valor menor a cero.";
                txtApellido.Focus();
                return false;
            }
            return true;
        }
    }
}
