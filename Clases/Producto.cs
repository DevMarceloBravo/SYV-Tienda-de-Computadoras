using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaComputadoras.Clases
{
    public class Producto
    {
        public string id_producto { get; set; }
        public string nombre_producto { get; set; }
        public string stock_producto { get; set; }
        public string precio_producto { get; set; }
        public string descripcion_producto { get; set; }
        public string id_proveedor { get; set; }
        public string nom_proveedor { get; set; }
        public string marca_producto { get; set; }
        public string id_categoria { get; set; }
        public int cantidadVendida { get; set; }

        public Producto(string id_producto, string nombre_producto, string stock_producto, string marca_producto, string precio_producto, string descripcion_producto, string id_proveedor, string id_categoria)
        {
            this.id_producto = id_producto;
            this.nombre_producto = nombre_producto;
            this.stock_producto = stock_producto;
            this.marca_producto = marca_producto;
            this.precio_producto = precio_producto;
            this.descripcion_producto = descripcion_producto;
            this.id_proveedor = id_proveedor;
            this.id_categoria = id_categoria;
        }
            
        public Producto(string id_producto, string nombre_producto, string stock_producto, string precio_producto, string descripcion_producto, string id_proveedor, string nom_proveedor)
        {
            this.id_producto = id_producto;
            this.nombre_producto = nombre_producto;
            this.stock_producto = stock_producto;
            this.precio_producto = precio_producto;
            this.descripcion_producto = descripcion_producto;
            this.id_proveedor = id_proveedor;
            this.nom_proveedor = nom_proveedor;
        }

        public Producto(string id_producto, string nombre_producto, string stock_producto, string precio_producto, string descripcion_producto, string id_proveedor)
        {
            this.id_producto = id_producto;
            this.nombre_producto = nombre_producto;
            this.stock_producto = stock_producto;
            this.precio_producto = precio_producto;
            this.descripcion_producto = descripcion_producto;
            this.id_proveedor = id_proveedor;
        }

        public Producto(string id_producto, string nombre_producto, string stock_producto, string precio_producto, string descripcion_producto)
        {
            this.id_producto = id_producto;
            this.nombre_producto = nombre_producto;
            this.stock_producto = stock_producto;
            this.precio_producto = precio_producto;
            this.descripcion_producto = descripcion_producto;
        }

        public Producto(string id_producto, string nombre_producto, int cantidadVendida)
        {
            this.id_producto = id_producto;
            this.nombre_producto = nombre_producto;
            this.cantidadVendida = cantidadVendida;
        }
    }
}
