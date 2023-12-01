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
    public class MetodosEmpleados
    {
        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();

        public DataTable ObtenerEmpleados()
        {
            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerEmpleados", sqlConexion); // Cambiado a "ObtenerEmpleados"
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

        public string AgregarEmpleado(Empleado empleado) // Cambiado a "AgregarEmpleado"
        {
            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("AgregarEmpleado", sqlConexion); // Cambiado a "AgregarEmpleado"
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nombre_empleado", MySqlDbType.VarChar).Value = empleado.nombre_empleado;
                comando.Parameters.Add("@telefono_empleado", MySqlDbType.VarChar).Value = empleado.telefono_empleado;
                comando.Parameters.Add("@direccion_empleado", MySqlDbType.VarChar).Value = empleado.direccion_empleado;
                comando.Parameters.Add("@correo_empleado", MySqlDbType.VarChar).Value = empleado.correo_empleado;
                comando.Parameters.Add("@ci_empleado", MySqlDbType.VarChar).Value = empleado.ci_empleado; // Cambiado a "ci_empleado"

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

        public DataTable BuscarEmpleado(string nombre) // Cambiado a "BuscarEmpleado"
        {
            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("BuscarEmpleado", sqlConexion); // Cambiado a "BuscarEmpleado"
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@empleado", MySqlDbType.VarChar).Value = nombre.Trim();
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

        public string EliminarEmpleado(int idEmpleado) // Cambiado a "EliminarEmpleado"
        {
            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("EliminarEmpleado", sqlConexion); // Cambiado a "EliminarEmpleado"
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", MySqlDbType.Int32).Value = idEmpleado;

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

        public string ActualizarEmpleado(int idEmpleado, Empleado empleado) // Cambiado a "ActualizarEmpleado"
        {
            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ActualizarEmpleado", sqlConexion); // Cambiado a "ActualizarEmpleado"
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", MySqlDbType.Int32).Value = idEmpleado;
                comando.Parameters.Add("@nombre_empleado", MySqlDbType.VarChar).Value = empleado.nombre_empleado;
                comando.Parameters.Add("@telefono_empleado", MySqlDbType.VarChar).Value = empleado.telefono_empleado;
                comando.Parameters.Add("@direccion_empleado", MySqlDbType.VarChar).Value = empleado.direccion_empleado;
                comando.Parameters.Add("@correo_empleado", MySqlDbType.VarChar).Value = empleado.correo_empleado;
                comando.Parameters.Add("@ci_empleado", MySqlDbType.VarChar).Value = empleado.ci_empleado; // Cambiado a "ci_empleado"

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

        public string ValidarEmpleado(Empleado empleado) // Cambiado a "ValidarEmpleado"
        {
            string resultado = null;

            if (empleado.nombre_empleado.Equals("") || empleado.telefono_empleado.Equals("") || empleado.direccion_empleado.Equals("") || empleado.correo_empleado.Equals(""))
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
