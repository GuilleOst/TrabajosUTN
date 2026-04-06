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

namespace TPG3
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private bool validarUsuario(string usuario, string contraseña)
        {
            //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Usuario WHERE nombreUsuario like @nombreUsuario and contraseña like @contraseña";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsuario", usuario);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 0)
                {
                    return false;
                };
                return true;
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

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim().Equals("") || txtContraseña.Text.Trim().Equals(""))
            {
                lblError.Text = "Error el usuario/contraseña ingresado no es válido."; 
            }
            else
            {
                var usuario = txtUsuario.Text.Trim();
                var contraseña = txtContraseña.Text.Trim();
                bool result = false;
                try
                {
                    result = validarUsuario(usuario, contraseña);
                    if (result)
                    {                        
                        this.Hide();
                        Main main = new Main();
                        main.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        lblError.Text = "Error el usuario/contraseña no es correcto.";
                    }
                }
                catch (Exception Ex)
                {

                    MessageBox.Show("Error!" + Ex.ToString());
                }
                
                
            }
            
        }
    }
}
