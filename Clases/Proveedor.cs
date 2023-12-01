using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaComputadoras.Clases
{
    public class Proveedor
    {
        public int id_proveedor { get; set; }
        public string nombre_proveedor { get; set; }
        public string telefono_proveedor { get; set; }
        public string direccion_proveedor { get; set; }
        public string correo_proveedor { get; set; }
        public string nit_proveedor { get; set; }

        public Proveedor(int id_proveedor, string nombre_proveedor)
        {
            this.id_proveedor = id_proveedor;
            this.nombre_proveedor = nombre_proveedor;
        }

        public Proveedor(int id_proveedor, string nombre_proveedor, string telefono_proveedor, string direccion_proveedor, string correo_proveedor, string nit_proveedor)
        {
            this.id_proveedor = id_proveedor;
            this.nombre_proveedor = nombre_proveedor;
            this.telefono_proveedor = telefono_proveedor;
            this.direccion_proveedor = direccion_proveedor;
            this.correo_proveedor = correo_proveedor;
            this.nit_proveedor = nit_proveedor;
        }

        public Proveedor(string nombre_proveedor, string telefono_proveedor, string direccion_proveedor, string correo_proveedor, string nit_proveedor)
        {
            this.nombre_proveedor = nombre_proveedor;
            this.telefono_proveedor = telefono_proveedor;
            this.direccion_proveedor = direccion_proveedor;
            this.correo_proveedor = correo_proveedor;
            this.nit_proveedor = nit_proveedor;
        }
    }
}
