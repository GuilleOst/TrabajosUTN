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

namespace TPG3.Formularios.Promocion
{
    public partial class AltaPromocion : Form
    {
        private Entidades.Promocion promo;
        public AltaPromocion(Entidades.Promocion editPromo)
        {
            promo = editPromo;
            InitializeComponent();
            cargarFormulario(promo);
        }

        private void limpiarEspacios()
        {
            mtbValor.Text = mtbValor.Text.Replace("_", "");
            mtbInicio.Text = mtbInicio.Text.Replace(" ", "0");
            mtbInicio.Text = mtbInicio.Text.Replace("_", "0");
            mtbFin.Text = mtbFin.Text.Replace(" ", "0");
            mtbFin.Text = mtbFin.Text.Replace("_", "0");
        }

        private void cargarFormulario(Entidades.Promocion editPromo)
        {
            if (editPromo.TipoEdicion > 1)
            {
                if (editPromo.TipoEdicion == 2)
                {
                    txtNombre.Text = editPromo.nombre;
                    txtNombre.Enabled = false;
                    txtDescripcion.Text = editPromo.descripcion;
                    mtbValor.Text = editPromo.valor.ToString();
                    
                    lblTitulo.Text = "Modificar Promoción";
                    btnCargarPromocion.Text = "Modificar";
                    limpiarEspacios();
                }
                else
                {
                    mtbInicio.Text = "11/05/2022";
                    mtbFin.Text = "11/05/2022";
                }
            }
        }

        private void btnCargarPromocion_Click(object sender, EventArgs e)
        {
            limpiarEspacios();
            //validamos los datos
            bool valido = validarCampos();
            if (valido)
            {
                bool result = cargarPromocion(promo);
                if (result)
                {   
                    if (promo.TipoEdicion == 3)
                    {
                        MessageBox.Show("Promoción cargada con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("Promoción actualizada con éxito!");
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

        private bool validarFormatoDate(String fecha)
        {
            string inputString = fecha;
            DateTime dDateInicio;

            if (DateTime.TryParse(inputString, out dDateInicio))
            {
                String.Format("{0:dd/MM/yyyy}", dDateInicio);
                return true;
            }
            else
            {
                return false;
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
            if (mtbValor.Text.Trim().Equals(""))
            {
                lblError.Text = "El campo Valor no puede estar vacío.";
                mtbValor.Focus();
                return false;
            }
            
            if (mtbInicio.Text.Trim().Equals(""))
            {
                lblError.Text = "El campo Fecha Inicio no puede estar vacío.";
                mtbInicio.Focus();
                return false;
            }
            if (mtbFin.Text.Trim().Equals(""))
            {
                lblError.Text = "El campo Fecha Fin no puede estar vacío.";
                mtbFin.Focus();
                return false;
            }
            int count = 0;
            foreach (char c in mtbInicio.Text)
            {    
                count++;   
            }
            if (count < 10)
            {
                lblError.Text = "La Fecha Inicio no está completa (dd/mm/yyyy).";
                mtbInicio.Focus();
                return false;
            }
            count = 0;
            foreach (char c in mtbFin.Text)
            {
                count++;
            }
            if (count < 10)
            {
                lblError.Text = "La Fecha Fin no está completa (dd/mm/yyyy).";
                mtbFin.Focus();
                return false;
            }
            if (!validarFormatoDate(mtbInicio.Text))
            {
                lblError.Text = "La Fecha Inicio no está en el formato correcto (dd/mm/yyyy).";
                mtbInicio.Focus();
                return false;
            }
            if (!validarFormatoDate(mtbFin.Text))
            {
                lblError.Text = "La Fecha Fin no está en el formato correcto (dd/mm/yyyy).";
                mtbFin.Focus();
                return false;
            }
            var date = new DateTime(1800, 1, 1);
            DateTime fechaInicio = DateTime.ParseExact(mtbInicio.Text, "dd/MM/yyyy", null);
            if (fechaInicio <= date)
            {
                lblError.Text = "La Fecha Inicio no es válida.";
                mtbInicio.Focus();
                return false;
            }
            DateTime fechaFin = DateTime.ParseExact(mtbFin.Text, "dd/MM/yyyy", null);
            if (fechaFin <= date)
            {
                lblError.Text = "La Fecha Fin no es válida.";
                mtbFin.Focus();
                return false;
            }
            if (fechaFin <= fechaInicio)
            {
                lblError.Text = "La Fecha Inicio debe ser menor que la Fecha Fin.";
                mtbInicio.Focus();
                return false;
            }
            return true;
        }

        public bool cargarPromocion(Entidades.Promocion promo)
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string consulta = "";
            if (promo.TipoEdicion > 1)
            {
                //Crear
                if (promo.TipoEdicion == 3)
                {
                    consulta = "INSERT INTO Promocion (nombre,descripcion,valor, fechaInicio, fechaFin)" +
                               "VALUES (@nombre, @descripcion, @valor, @fechaInicio, @fechaFin)";
                }
                //Modificar
                else
                {
                    consulta = "UPDATE Promocion SET descripcion=@descripcion, valor=@valor, " +
                               "fechaInicio=@fechaInicio, fechaFin=@fechaFin where nombre = @nombre ";
                }
                try
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@valor", float.Parse(mtbValor.Text.Trim()));
                    cmd.Parameters.AddWithValue("@fechaInicio", DateTime.Parse(mtbInicio.Text));
                    cmd.Parameters.AddWithValue("@fechaFin", DateTime.Parse(mtbFin.Text));
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
                    consulta = "DELETE FROM Promocion WHERE nombre = @nombre";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nombre", promo.nombre);
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
            Main.main1.btnSubPromocion_Click(sender, e);
        }
    }
}
