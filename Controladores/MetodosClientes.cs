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
    public class MetodosClientes
    {
        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();

        public DataTable ObtenerClientes()
        {
            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerClientes", sqlConexion);
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

        public string AgregarCliente(Cliente cliente)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("AgregarCliente", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nombre_cliente", MySqlDbType.VarChar).Value = cliente.nombre_cliente;
                comando.Parameters.Add("@telefono_cliente", MySqlDbType.VarChar).Value = cliente.telefono_cliente;
                comando.Parameters.Add("@direccion_cliente", MySqlDbType.VarChar).Value = cliente.direccion_cliente;
                comando.Parameters.Add("@correo_cliente", MySqlDbType.VarChar).Value = cliente.correo_cliente;
                comando.Parameters.Add("@nit_cliente", MySqlDbType.Int32).Value = cliente.nit_cliente;

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

        public DataTable BuscarCliente(string nombre)
        {
            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("BuscarCliente", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@cliente", MySqlDbType.VarChar).Value = nombre.Trim();
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

        public string EliminarCliente(int idCliente)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("EliminarCliente", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", MySqlDbType.Int32).Value = idCliente;

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

        public string ActualizarCliente(int idCliente, Cliente cliente)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ActualizarCliente", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", MySqlDbType.Int32).Value = idCliente;
                comando.Parameters.Add("@nombre_cliente", MySqlDbType.VarChar).Value = cliente.nombre_cliente;
                comando.Parameters.Add("@telefono_cliente", MySqlDbType.VarChar).Value = cliente.telefono_cliente;
                comando.Parameters.Add("@direccion_cliente", MySqlDbType.VarChar).Value = cliente.direccion_cliente;
                comando.Parameters.Add("@correo_cliente", MySqlDbType.VarChar).Value = cliente.correo_cliente;
                comando.Parameters.Add("@nit_cliente", MySqlDbType.VarChar).Value = cliente.nit_cliente;

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

        public string ValidarCliente(Cliente cliente)
        {
            string resultado = null;

            if (cliente.nombre_cliente.Equals("") || cliente.telefono_cliente.Equals("") || cliente.direccion_cliente.Equals("") || cliente.correo_cliente.Equals(""))
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
