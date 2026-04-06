using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPG3.Entidades;

namespace TPG3.Formularios.Producto
{
    public partial class ListaProducto : Form
    {
        public ListaProducto()
        {
            InitializeComponent();
        }

        private void ListaProducto_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.main1.btnSubComboAltaProducto(sender, e);
        }

        private void CargarGrilla()
        {
            try
            {
                gdrConsultarProd.DataSource = AD_Producto.ObtenerTablaProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener productos");
            }
        }

 

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            (gdrConsultarProd.DataSource as DataTable).DefaultView.RowFilter = "Convert(nombre, 'System.String') LIKE '" + txtNombreProducto.Text + "%' and Convert(nombreTipoProd, 'System.String') LIKE '" + txtBuscadorTipoProd.Text + "%'";
        }

        private void txtBuscadorTipoProd_TextChanged(object sender, EventArgs e)
        {
            (gdrConsultarProd.DataSource as DataTable).DefaultView.RowFilter = "Convert(nombre, 'System.String') LIKE '" + txtNombreProducto.Text + "%' and Convert(nombreTipoProd, 'System.String') LIKE '" + txtBuscadorTipoProd.Text + "%'";
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            var currentRow = gdrConsultarProd.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = gdrConsultarProd.Rows[currentRow];
            int idProducto = int.Parse(gdrConsultarProd.Rows[currentRow].Cells[0].Value.ToString());

            Entidades.Producto producto = new Entidades.Producto(idProducto, "", "", 1, 0, 0, 1);
            AltaProducto altProd = new AltaProducto(producto);
            bool estaEnCombo = altProd.estaEnCombo(producto);
            bool result;
            if (estaEnCombo)
            {
                var confirmResult = MessageBox.Show("Este Producto pertenece a un Combo, desea eliminarlo ??",
                                     "Confirmación!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    result = altProd.eliminarProductoCombo(producto);
                    if (result)
                    {
                        MessageBox.Show("Producto eliminado con éxito!");
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                var confirmResult2 = MessageBox.Show("Desea eliminar este Producto ??",
                                     "Confirmación!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult2 == DialogResult.Yes)
                {

                    result = altProd.eliminarProducto(producto);
                    if (result)
                    {
                        MessageBox.Show("Producto eliminado con éxito!");
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            Main.main1.btnSubComboAltaProducto(sender, e);
        }
    }
}
