using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaComputadoras.Clases;

namespace TiendaComputadoras.Controladores
{
    public class MetodosVentas
    {
        private MySqlConnection sqlConexion;
        private MySqlDataReader resultado;

        public MetodosVentas()
        {
            sqlConexion = new Conexion().ObtenerConexion();
        }

        public string RealizarVenta(int idEmpleado, int idCliente, List<DetalleVenta> detallesVenta)
        {
            try
            {
                // Crear una instancia de la clase Venta y asignar valores
                Venta venta = new Venta
                {
                    FechaVenta = DateTime.Now,
                    IdEmpleado = idEmpleado,
                    IdCliente = idCliente
                };

                // Llamar a un método para insertar la venta en la base de datos
                int idVenta = InsertarVenta(venta);

                // Insertar los detalles de la venta
                foreach (var detalle in detallesVenta)
                {
                    detalle.IdVenta = idVenta;
                    InsertarDetalleVenta(detalle);
                }

                return "Venta realizada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al realizar la venta: " + ex.Message;
            }
        }

        public DataTable ObtenerVentas()
        {
            try
            {
                sqlConexion.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM Venta", sqlConexion);
                resultado = comando.ExecuteReader();

                DataTable tablaVentas = new DataTable();
                tablaVentas.Load(resultado);

                return tablaVentas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }

        private int InsertarVenta(Venta venta)
        {
            try
            {
                sqlConexion.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO Venta (fecha_venta, id_empleado, id_cliente) VALUES (@fecha, @idEmpleado, @idCliente); SELECT LAST_INSERT_ID();", sqlConexion);
                comando.Parameters.AddWithValue("@fecha", venta.FechaVenta);
                comando.Parameters.AddWithValue("@idEmpleado", venta.IdEmpleado);
                comando.Parameters.AddWithValue("@idCliente", venta.IdCliente);

                // Obtener el ID de la venta recién creada
                int idVenta = Convert.ToInt32(comando.ExecuteScalar());

                return idVenta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }

        private void InsertarDetalleVenta(DetalleVenta detalle)
        {
            try
            {
                sqlConexion.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO DetalleVenta (id_venta, id_producto, cantidad, precio_unitario) VALUES (@idVenta, @idProducto, @cantidad, @precioUnitario);", sqlConexion);
                comando.Parameters.AddWithValue("@idVenta", detalle.IdVenta);
                comando.Parameters.AddWithValue("@idProducto", detalle.IdProducto);
                comando.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                comando.Parameters.AddWithValue("@precioUnitario", detalle.PrecioUnitario);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }
    }
}
