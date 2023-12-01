using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaComputadoras.Controladores;

namespace TiendaComputadoras.Vistas
{
    public partial class FormRegistros : Form
    {

        MetodosRegistros metodosRegistros;
        DataTable datos;
        int idProveedor = 0;

        public FormRegistros()
        {
            InitializeComponent();
        }

        private void FormRegistros_Load(object sender, EventArgs e)
        {
            this.MostrarRegistros();
        }

        public void MostrarRegistros()
        {
            metodosRegistros = new MetodosRegistros();
            datos = metodosRegistros.ObtenerRegistros();
            FormatoTablaRegistros(datos);
        }
        public void FormatoTablaRegistros(DataTable datos)
        {
            try
            {
                datos.Columns["id_evento"].ColumnName = "ID EVENTO";
                datos.Columns["tipo_evento"].ColumnName = "EVENTO";
                datos.Columns["fecha_registro"].ColumnName = "FECHA DE REGISTRO";
                datos.Columns["id_empleado"].ColumnName = "ID EMPLEADO";
                datos.Columns["id_cliente"].ColumnName = "ID CLIENTE";
                datos.Columns["id_proveedor"].ColumnName = "ID PROVEEDOR";
                datos.Columns["id_producto"].ColumnName = "ID PRODUCTO";

                DGVRegistros.DataSource = datos;
                DGVRegistros.Columns["ID EVENTO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVRegistros.Columns["EVENTO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVRegistros.Columns["FECHA DE REGISTRO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVRegistros.Columns["ID EMPLEADO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVRegistros.Columns["ID CLIENTE"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVRegistros.Columns["ID PROVEEDOR"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVRegistros.Columns["ID PRODUCTO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
