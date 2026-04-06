using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class AD_Producto
    {

        public static bool AgregarProductoABD(Producto prod)
        {
            bool resultado = false;
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Producto (nombre, descripcion, tipoProducto, precio) VALUES (@nombre, @descripcion, @tipoProducto, @precio)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", prod.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", prod.Descripcion);
                cmd.Parameters.AddWithValue("@tipoProducto", prod.TipoProducto);
                cmd.Parameters.AddWithValue("@precio", prod.Precio);
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

        public static DataTable ObtenerTablaProducto()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT Producto.idProducto, Producto.nombre, Producto.descripcion, TipoProducto.nombreTipoProd, Producto.precio "+
                "FROM Producto JOIN TipoProducto ON Producto.tipoProducto = TipoProducto.idTipoProducto " +
                "where Producto.tipoProducto <> 1";

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



        public static DataTable ObtenerTipoProducto()
        {
            string cadenaConexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G03_2022;Persist Security Info=True;User ID=BD3K7G03_2022;Password=PSW03_98074";
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM TipoProducto where TipoProducto.idTipoProducto <> 1";

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

       
    }
}
