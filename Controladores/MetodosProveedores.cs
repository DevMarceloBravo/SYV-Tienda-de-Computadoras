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
    public class MetodosProveedores
    {
        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();

        public DataTable ObtenerProveedores()
        {
            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerProveedores", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
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

        public string AgregarProveedor(Proveedor proveedor)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("AgregarProveedor", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nombre_proveedor", MySqlDbType.VarChar).Value = proveedor.nombre_proveedor;
                comando.Parameters.Add("@telefono_proveedor", MySqlDbType.VarChar).Value = proveedor.telefono_proveedor;
                comando.Parameters.Add("@direccion_proveedor", MySqlDbType.VarChar).Value = proveedor.direccion_proveedor;
                comando.Parameters.Add("@correo_proveedor", MySqlDbType.VarChar).Value = proveedor.correo_proveedor;
                comando.Parameters.Add("@nit_proveedor", MySqlDbType.Int32).Value = proveedor.nit_proveedor;

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

        public DataTable BuscarProveedor(string nombre)
        {
            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("BuscarProveedor", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@proveedor", MySqlDbType.VarChar).Value = nombre.Trim();
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

        public string EliminarProveedor(int idProveedor)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("EliminarProveedor", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", MySqlDbType.Int32).Value = idProveedor;

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
        public string ActualizarProveedor(int idProveedor, Proveedor proveedor)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ActualizarProveedor", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", MySqlDbType.Int32).Value = idProveedor;
                comando.Parameters.Add("@nombre_proveedor", MySqlDbType.VarChar).Value = proveedor.nombre_proveedor;
                comando.Parameters.Add("@telefono_proveedor", MySqlDbType.VarChar).Value = proveedor.telefono_proveedor;
                comando.Parameters.Add("@direccion_proveedor", MySqlDbType.VarChar).Value = proveedor.direccion_proveedor;
                comando.Parameters.Add("@correo_proveedor", MySqlDbType.VarChar).Value = proveedor.correo_proveedor;
                comando.Parameters.Add("@nit_proveedor", MySqlDbType.VarChar).Value = proveedor.nit_proveedor; // Agregado atributo nit_proveedor

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

        public string ValidarProveedor(Proveedor proveedor)
        {
            string resultado = null;

            if (proveedor.nombre_proveedor.Equals("") || proveedor.telefono_proveedor.Equals("") || proveedor.direccion_proveedor.Equals("") || proveedor.correo_proveedor.Equals(""))
            {
                resultado = "TE FALTA LLENAR Y/O SELECCIONAR UN CAMPO";
            }
            else
            {
                resultado = "OK";
            }

            return resultado;
        }
    }
}
