using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaComputadoras.Clases
{
    public class Cliente
    {
        public int id_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public string telefono_cliente { get; set; }
        public string direccion_cliente { get; set; }
        public string correo_cliente { get; set; }
        public string nit_cliente { get; set; }

        public Cliente(int id_cliente, string nombre_cliente)
        {
            this.id_cliente = id_cliente;
            this.nombre_cliente = nombre_cliente;
        }

        public Cliente(int id_cliente, string nombre_cliente, string telefono_cliente, string direccion_cliente, string correo_cliente, string nit_cliente)
        {
            this.id_cliente = id_cliente;
            this.nombre_cliente = nombre_cliente;
            this.telefono_cliente = telefono_cliente;
            this.direccion_cliente = direccion_cliente;
            this.correo_cliente = correo_cliente;
            this.nit_cliente = nit_cliente;
        }

        public Cliente(string nombre_cliente, string telefono_cliente, string direccion_cliente, string correo_cliente, string nit_cliente)
        {
            this.nombre_cliente = nombre_cliente;
            this.telefono_cliente = telefono_cliente;
            this.direccion_cliente = direccion_cliente;
            this.correo_cliente = correo_cliente;
            this.nit_cliente = nit_cliente;
        }
    }
}