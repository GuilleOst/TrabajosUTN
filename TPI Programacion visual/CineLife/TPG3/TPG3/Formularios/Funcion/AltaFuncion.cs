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

namespace TPG3.Formularios.Funcion
{
    public partial class AltaFuncion : Form
    {
        private Entidades.Funcion func;
        public AltaFuncion(Entidades.Funcion editFuncion)
        {
            func = editFuncion;
            InitializeComponent();
            cargarFormulario(func);
        }

        private void limpiarEspacios()
        {
            maskedTextBox1.Text = maskedTextBox1.Text.Replace("_", "");
        }
        private void cargarFormulario(Entidades.Funcion editFuncion)
        {
            if (editFuncion.TipoEdicion > 1)
            {
                if (editFuncion.TipoEdicion == 2)
                {
                    maskedTextBox1.Text = editFuncion.fechaHora.ToString();
                    
                }
                

                cargarComboSala();
                cargarComboPelicula();
                cargarComboEstado();
                cargarComboFechaInicio();
                //cuando la fechaInicio es la primera del cmb, simepre me dice q 'ha ocurrido un error'
                //cargarComboFechaFin();

            }
            
        }

        //private void cargarComboFechaFin()
        //{
        //    string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
        //    //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
        //    SqlConnection cn = new SqlConnection(cadenaConexion);
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        string consulta = "SELECT * FROM ProgramacionSemanal";

        //        cmd.Parameters.Clear();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = consulta;
        //        cn.Open();
        //        cmd.Connection = cn;

        //        DataTable tabla = new DataTable();

        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(tabla);
        //        cmbFechaFin.DataSource = tabla;
        //        cmbFechaFin.DisplayMember = "fechaFin";
        //        cmbFechaFin.ValueMember = "fechaFin";

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }
        //}

        private void btnCargarFuncion_Click(object sender, EventArgs e)
        {
            //validamos los datos
            limpiarEspacios();
            bool valido = validarCampos();
            if (valido)
            {
                bool result = cargarFunc(func);
                if (result)
                {
                    if (func.TipoEdicion == 3)
                    {
                        MessageBox.Show("Función cargada con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("Función actualizada con éxito!");
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
        private void cargarComboFechaInicio()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM ProgramacionSemanal";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cmbFechaInicio.DataSource = tabla;
                cmbFechaInicio.DisplayMember = "fechaInicio";
                cmbFechaInicio.ValueMember = "fechaInicio";

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

        private void cargarComboEstado()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Estado";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cmbEstado.DataSource = tabla;
                cmbEstado.DisplayMember = "Nombre";
                cmbEstado.ValueMember = "nombre";

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

        private void cargarComboPelicula()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Pelicula";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cmbPeli.DataSource = tabla;
                cmbPeli.DisplayMember = "Titulo";
                cmbPeli.ValueMember = "codPelicula";

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
            if (maskedTextBox1.Text.Trim().Equals(""))
            {
                lblError.Text = "El campo 'Fecha y Hora' no puede estar vacío.";
                maskedTextBox1.Focus();
                return false;
            }
            return true;
        }
        public bool cargarFunc(Entidades.Funcion func)
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "";
            if (func.TipoEdicion > 1)
            {
                try
                {
                    if (func.TipoEdicion == 3)
                    {
                        consulta = "INSERT INTO Funcion (fechaHora, sala, pelicula, estado, fechaInicio, fechaFin) " +
                                      "VALUES (@fechaHora, @sala, @pelicula, @estado, @fechaInicio, @fechaFin) ";
                    }
                    else
                    {
                        consulta = "UPDATE Funcion set sala=@sala, pelicula=@pelicula, estado=@estado, " +
                            "fechaInicio=@fechaInicio, fechaFin=@fechaFin where fechaHora=@FechaHora ";
                    };

                    cmd.Parameters.Clear();
                    if (func.TipoEdicion == 2)
                    {
                        cmd.Parameters.AddWithValue("@fechaHora", func.fechaHora);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@fechaHora", maskedTextBox1.Text);
                    }
                   
                    cmd.Parameters.AddWithValue("@sala", cmbSala.SelectedValue);
                    cmd.Parameters.AddWithValue("@pelicula", cmbPeli.SelectedValue);
                    cmd.Parameters.AddWithValue("@estado", cmbEstado.SelectedValue);
                    cmd.Parameters.AddWithValue("@fechaInicio", cmbFechaInicio.SelectedValue);
                    var fechaFin = DateTime.Parse(cmbFechaInicio.SelectedText);
                    cmd.Parameters.AddWithValue("@fechaFin", fechaFin.AddDays(7)); 
             
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
                    consulta = "DELETE FROM Funcion where fechaHora=@fechaHora ";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@fechaHora", func.fechaHora);
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

        private void cargarComboSala()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
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
                cmbSala.DataSource = tabla;
                cmbSala.DisplayMember = "Numero";
                cmbSala.ValueMember = "codigo";

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

        
        private void btnListado_Click(object sender, EventArgs e)
        {
            //Main.main1.btnFuncion_Click(sender, e);
        }

        private void cmbFechaInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fechaFin = DateTime.Parse(cmbFechaInicio.SelectedText);
            cmbFechaFin.SelectedText = fechaFin.AddDays(7).ToString();
        }
    }
}



    //private void AltaFuncion_Load(object sender, EventArgs e)
    //{

    //}

