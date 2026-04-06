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

namespace TPG3.Formularios.Funcion
{
    public partial class ListaFuncion : Form
    {
        public ListaFuncion()
        {
            InitializeComponent();
        }

        private void ListaFuncion_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT Funcion.fechaHora as 'Fecha y Hora', Funcion.sala as 'Sala', Funcion.pelicula as 'Pelicula', " +
                    "Pelicula.titulo as 'Titulo', Funcion.estado as 'Estado', Funcion.fechaInicio as 'Fecha Inicio', " +
                    "Funcion.fechaFin as 'Fecha Fin', ProgramacionSemanal.nroSemana as 'Nro Semana' FROM((Funcion " +
                    "INNER JOIN Pelicula ON Funcion.pelicula = Pelicula.codPelicula) " +
                    "INNER JOIN ProgramacionSemanal ON Funcion.fechaInicio = ProgramacionSemanal.fechaInicio)";
                

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tablaFuncion = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tablaFuncion);
                dgvFuncion.DataSource = tablaFuncion;
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

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dgvFuncion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCargarFuncion_Click(object sender, EventArgs e)
        {
            Entidades.Funcion funcion = new Entidades.Funcion(DateTime.Today, 0, 0, "", DateTime.Today, DateTime.Today, 3);
            //Main.main1.btnSubFuncionAltaFuncion(funcion);
        }

        private void btnEditarFuncion_Click(object sender, EventArgs e)
        {

            var currentRow = dgvFuncion.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvFuncion.Rows[currentRow];
            DateTime fechaHora = DateTime.Parse(dgvFuncion.Rows[currentRow].Cells[0].Value.ToString());
            int sala = int.Parse(dgvFuncion.Rows[currentRow].Cells[1].Value.ToString());
            int pelicula = int.Parse(dgvFuncion.Rows[currentRow].Cells[2].Value.ToString());
            string estado = dgvFuncion.Rows[currentRow].Cells[3].Value.ToString();
            DateTime fechaInicio = DateTime.Parse(dgvFuncion.Rows[currentRow].Cells[0].Value.ToString());
            DateTime fechaFin = DateTime.Parse(dgvFuncion.Rows[currentRow].Cells[0].Value.ToString());

            Entidades.Funcion funcion = new Entidades.Funcion(fechaHora, sala, pelicula, estado, fechaInicio, fechaFin, 2);
            //Main.main1.btnSubFuncionAltaFuncion(funcion);

        }

        private void btnEliminarFuncion_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Desea eliminar este Función ??",
                                     "Confirmación!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var currentRow = dgvFuncion.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dgvFuncion.Rows[currentRow];
                DateTime fechaHora = DateTime.Parse(dgvFuncion.Rows[currentRow].Cells[0].Value.ToString());
                Entidades.Funcion func = new Entidades.Funcion(fechaHora, 0, 0, "", DateTime.Today, DateTime.Today, 1);
                AltaFuncion altaFuncion = new AltaFuncion(func);
                var result = altaFuncion.cargarFunc(func);
                if (result)
                {
                    MessageBox.Show("Función eliminada con éxito!");
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
