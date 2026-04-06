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

namespace TPG3.Formularios.Combo
{
    public partial class ListaCombo : Form
    {
        public ListaCombo()
        {
            InitializeComponent();
        }

        private void ListaCombo_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnRegistrarCombo_Click(object sender, EventArgs e)
        {
            Entidades.Producto combo = new Entidades.Producto(-1, "", "", 1, 0, 0, 3);
            Main.main1.btnSubComboAltaCombo(combo);

        }

        private void cargarGrilla()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select p.nombre,p.idProducto,p.descripcion ,p.precio, SUM(cs.cantidad) as 'cantidadItems' from Producto p inner join ComposicionDeCombo cs on p.idProducto = cs.idProductoCombo "+
                "group by p.nombre,p.idProducto,p.descripcion ,p.precio,cs.idProductoCombo";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                gdrConsultarProd.DataSource = tabla;

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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            (gdrConsultarProd.DataSource as DataTable).DefaultView.RowFilter = "Convert(nombre, 'System.String') LIKE '" + txtNombre.Text + "%'";
        }

        private void btnActualizarCombo_Click(object sender, EventArgs e)
        {
            var currentRow = gdrConsultarProd.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = gdrConsultarProd.Rows[currentRow];
            string nombreCombo = (gdrConsultarProd.Rows[currentRow].Cells[0].Value.ToString());
            int idProducto = int.Parse(gdrConsultarProd.Rows[currentRow].Cells[1].Value.ToString());
            string descripcion =(gdrConsultarProd.Rows[currentRow].Cells[2].Value.ToString());
            float precio = float.Parse(gdrConsultarProd.Rows[currentRow].Cells[3].Value.ToString());
            int cantidadItems = int.Parse(gdrConsultarProd.Rows[currentRow].Cells[4].Value.ToString());

            Entidades.Producto producto = new Entidades.Producto(idProducto,nombreCombo,descripcion,1,precio,cantidadItems,2);
            Main.main1.btnSubComboAltaCombo(producto);
        }

        private void btnEliminarCombo_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Desea eliminar este Combo ??",
                                     "Confirmación!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var currentRow = gdrConsultarProd.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = gdrConsultarProd.Rows[currentRow];
                int idProducto = int.Parse(gdrConsultarProd.Rows[currentRow].Cells[1].Value.ToString());
                Entidades.Producto producto = new Entidades.Producto(idProducto, "", "", 1, 0, 0, 1);
                AltaCombo altaCmb = new AltaCombo(producto);
                var result = altaCmb.cargarCombo(producto);
                if (result)
                {
                    MessageBox.Show("Combo eliminado con éxito!");
                    cargarGrilla();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
