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

namespace TPG3.Formularios.Pelicula
{
    public partial class ListaPelicula : Form
    {
        public ListaPelicula()
        {
            InitializeComponent();
        }

        private void btnRegistrarPelícula_Click(object sender, EventArgs e)
        {
            Main.main1.btnSubPeliculaAltaPelicula(sender, e);
        }

        private void ListaPelicula_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                gdrActualizarPeli.DataSource = AltaPelicula.ObtenerTablaPelicula();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la película");
            }
        }

        private void txtBuscadorTitulo_TextChanged(object sender, EventArgs e)
        {
            (gdrActualizarPeli.DataSource as DataTable).DefaultView.RowFilter = "Convert(ptitulo, 'System.String') LIKE '" + txtBuscadorTitulo.Text + "%' and Convert(gdescripcion, 'System.String') LIKE '" + txtBuscadorGenero.Text + "%'";

        }

        private void txtBuscadorGenero_TextChanged(object sender, EventArgs e)
        {
            (gdrActualizarPeli.DataSource as DataTable).DefaultView.RowFilter = "Convert(ptitulo, 'System.String') LIKE '" + txtBuscadorTitulo.Text + "%' and Convert(gdescripcion, 'System.String') LIKE '" + txtBuscadorGenero.Text + "%'";
        }

        private void btnEliminarPelicula_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Desea eliminar esta Película ??",
                                     "Confirmación!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var currentRow = gdrActualizarPeli.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = gdrActualizarPeli.Rows[currentRow];
                int codPelicula = int.Parse(gdrActualizarPeli.Rows[currentRow].Cells[0].Value.ToString());
                AltaPelicula altaPeli = new AltaPelicula();
                var result = altaPeli.EliminarPeliculaABD(codPelicula);
                if (result)
                {
                    MessageBox.Show("Pelicula eliminada con éxito!");
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
