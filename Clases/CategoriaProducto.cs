﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaComputadoras.Clases
{
    public class CategoriaProducto
    {
        public int id_categoria { get; set; }
        public string nombre_categoria { get; set; }

        public CategoriaProducto()
        {
            // Constructor sin parámetros
        }
        public CategoriaProducto(int id_categoria, string nombre_categoria)
        {
            this.id_categoria = id_categoria;
            this.nombre_categoria = nombre_categoria;
        }
    }
}
