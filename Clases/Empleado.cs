using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaComputadoras.Clases
{
    public class Empleado
    {
        public int id_empleado { get; set; }
        public string nombre_empleado { get; set; }
        public string telefono_empleado { get; set; }
        public string direccion_empleado { get; set; }
        public string correo_empleado { get; set; }
        public string ci_empleado { get; set; }

        public Empleado(int id_empleado, string nombre_empleado)
        {
            this.id_empleado = id_empleado;
            this.nombre_empleado = nombre_empleado;
        }

        public Empleado(int id_empleado, string nombre_empleado, string telefono_empleado, string direccion_empleado, string correo_empleado, string ci_empleado)
        {
            this.id_empleado = id_empleado;
            this.nombre_empleado = nombre_empleado;
            this.telefono_empleado = telefono_empleado;
            this.direccion_empleado = direccion_empleado;
            this.correo_empleado = correo_empleado;
            this.ci_empleado = ci_empleado;
        }

        public Empleado(string nombre_empleado, string telefono_empleado, string direccion_empleado, string correo_empleado, string ci_empleado)
        {
            this.nombre_empleado = nombre_empleado;
            this.telefono_empleado = telefono_empleado;
            this.direccion_empleado = direccion_empleado;
            this.correo_empleado = correo_empleado;
            this.ci_empleado = ci_empleado;
        }
    }
}
