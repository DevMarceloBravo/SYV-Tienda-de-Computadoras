using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TiendaComputadoras.Clases;

namespace TiendaComputadoras.Controladores
{
    public class MetodosProductos
    {
        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();
        Producto producto;
        string nomProducto;

        public DataTable ObtenerProductos()
        {
            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM Productos", sqlConexion);
                sqlConexion.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
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

        public List<Proveedor> ObtenerProveedores()
        {
            List<Proveedor> listaProveedores = new List<Proveedor>();

            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM Proveedor", sqlConexion);
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaProveedores.Add(
                        new Proveedor(
                            resultado.GetInt32(0),
                            resultado.GetString(1)
                        )
                    );
                }

                return listaProveedores;
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

        public List<CategoriaProducto> ObtenerCategorias()
        {
            List<CategoriaProducto> listaCategorias = new List<CategoriaProducto>();

            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM CategoriaProductos", sqlConexion);
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaCategorias.Add(
                        new CategoriaProducto(
                            resultado.GetInt32(0),
                            resultado.GetString(1)
                        )
                    );
                }

                return listaCategorias;
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

        public string ValidarProducto(Producto producto)
        {
            string resultado = null;

            if (producto.nombre_producto.Equals("") || producto.stock_producto.Equals("") || producto.precio_producto.Equals("") || producto.descripcion_producto.Equals(""))
            {
                resultado = "TE FALTA LLENAR Y/O SELECCIONAR UN CAMPO";
            }
            else
            {
                resultado = "OK";
            }

            return resultado;
        }

        public string AgregarProducto(Producto producto)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("InsertarProducto", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nombre_producto", MySqlDbType.VarChar).Value = producto.nombre_producto;
                comando.Parameters.Add("@marca_producto", MySqlDbType.VarChar).Value = producto.marca_producto;
                comando.Parameters.Add("@descripcion_producto", MySqlDbType.VarChar).Value = producto.descripcion_producto;
                comando.Parameters.Add("@precio_producto", MySqlDbType.Decimal).Value = producto.precio_producto;
                comando.Parameters.Add("@stock_producto", MySqlDbType.Int32).Value = producto.stock_producto;
                comando.Parameters.Add("@id_categoria", MySqlDbType.Int32).Value = producto.id_categoria;
                comando.Parameters.Add("@id_proveedor", MySqlDbType.Int32).Value = producto.id_proveedor;

                sqlConexion.Open();
                if (comando.ExecuteNonQuery() > 1)
                {
                    respuesta = "SE INSERTÓ CORRECTAMENTE";
                }
                else
                {
                    respuesta = "NO SE PUDO INSERTAR EL REGISTRO";
                }

                return respuesta;
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

        public string ActualizarProducto(Producto producto)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ActualizarProducto", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_producto_actualizar", MySqlDbType.Int32).Value = Convert.ToInt32(producto.id_producto);
                comando.Parameters.Add("@nombre_producto", MySqlDbType.VarChar).Value = producto.nombre_producto;
                comando.Parameters.Add("@stock_producto", MySqlDbType.Int32).Value = Convert.ToInt32(producto.stock_producto);
                comando.Parameters.Add("@marca_producto", MySqlDbType.VarChar).Value = producto.marca_producto;
                comando.Parameters.Add("@precio_producto", MySqlDbType.Double).Value = Convert.ToDouble(producto.precio_producto);
                comando.Parameters.Add("@descripcion_producto", MySqlDbType.Text).Value = producto.descripcion_producto;
                comando.Parameters.Add("@id_proveedor", MySqlDbType.Int32).Value = Convert.ToInt32(producto.id_proveedor);
                comando.Parameters.Add("@id_categoria", MySqlDbType.Int32).Value = Convert.ToInt32(producto.id_categoria);

                sqlConexion.Open();
                if (comando.ExecuteNonQuery() > 1)
                {
                    respuesta = "SE ACTUALIZÓ CORRECTAMENTE";
                }
                else
                {
                    respuesta = "NO SE PUDO ACTUALIZAR EL REGISTRO";
                }

                return respuesta;
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

        public string EliminarProducto(int idProducto)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("EliminarProducto", sqlConexion); // Asegúrate de que el procedimiento almacenado sea el correcto
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", MySqlDbType.Int32).Value = idProducto;

                sqlConexion.Open();
                if (comando.ExecuteNonQuery() > 1)
                {
                    respuesta = "SE ELIMINÓ CORRECTAMENTE";
                }
                else
                {
                    respuesta = "NO SE PUDO ELIMINAR EL REGISTRO";
                }

                return respuesta;
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
        public DataTable BuscarProducto(string nombreProducto)
        {
            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("BuscarProducto", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@producto", MySqlDbType.VarChar).Value = nombreProducto.Trim();
                comando.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = nombreProducto.Trim();
                sqlConexion.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
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

        public Producto BuscarProductoVenta(string codigo)
        {
            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("BuscarProductoVenta", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = codigo.Trim();
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    producto = new Producto(
                        resultado.GetString(0),
                        resultado.GetString(1),
                        resultado.GetString(2),
                        resultado.GetString(3),
                        resultado.GetString(4),
                        resultado.GetString(5),
                        resultado.GetString(6)
                    );
                }

                return producto;
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

        public string ObtenerNombreProducto(string codigo)
        {
            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerNombreProducto", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = codigo.Trim();
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    nomProducto = resultado.GetString(0);
                }

                return nomProducto;
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
