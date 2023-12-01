using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaComputadoras.Clases;
using TiendaComputadoras.Controladores;



namespace TiendaComputadoras.Vistas
{
    public partial class FormProductos : Form
    {
        MetodosProductos metodosProductos;
        MetodosCategorias metodosCategorias;
        DataTable datos;
        int idProducto = 0;

        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            this.MostrarProductos();
            this.MostrarProveedores(cbProveedores);
            this.MostrarProveedores(cbActProveedores);
            this.MostrarCategorias(cbCategorias);
            this.MostrarCategorias(cbActCategorias);


            tbIdProducto.Enabled = false;
            tbActIdProducto.Enabled = false;
        }

        public void MostrarProductos()
        {
            metodosProductos = new MetodosProductos();
            datos = metodosProductos.ObtenerProductos();
            FormatoTablaProductos(datos);
        }


        public void FormatoTablaProductos(DataTable datos)
        {
            try
            {
                datos.Columns["id_producto"].ColumnName = "ID PRODUCTO";
                datos.Columns["nombre_producto"].ColumnName = "PRODUCTO";
                datos.Columns["marca_producto"].ColumnName = "MARCA";
                datos.Columns["descripcion_producto"].ColumnName = "DESCRIPCION";
                datos.Columns["stock_producto"].ColumnName = "STOCK";
                datos.Columns["precio_producto"].ColumnName = "PRECIO";
                datos.Columns["id_proveedor"].ColumnName = "ID PROVEEDOR";
                datos.Columns["id_categoria"].ColumnName = "ID CATEGORIA";

                DGVProductos.DataSource = datos;
                DGVProductos.Columns["ID PRODUCTO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProductos.Columns["PRODUCTO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProductos.Columns["MARCA"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProductos.Columns["DESCRIPCION"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProductos.Columns["STOCK"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProductos.Columns["PRECIO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProductos.Columns["ID PROVEEDOR"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProductos.Columns["ID CATEGORIA"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //txtTotalProductos.Text = "Total de productos: " + datos.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MostrarProveedores(ComboBox cbProveedores)
        {
            List<Proveedor> datos = metodosProductos.ObtenerProveedores();
            cbProveedores.Items.Add("Selecciona una opción");
            foreach (Proveedor dato in datos)
            {
                cbProveedores.Items.Add(dato.id_proveedor + "," + dato.nombre_proveedor);
            }
            cbProveedores.SelectedIndex = 0;
        }

        private void MostrarCategorias(ComboBox cbCategorias)
        {
            List<CategoriaProducto> datos = metodosProductos.ObtenerCategorias();
            cbCategorias.Items.Add("Selecciona una opción");
            foreach (CategoriaProducto dato in datos)
            {
                cbCategorias.Items.Add(dato.id_categoria + "," + dato.nombre_categoria);
            }
            cbCategorias.SelectedIndex = 0;
        }
        
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //string idProducto = tbIdProducto.Text.Trim();
            string nomProducto = tbNomProducto.Text.Trim();
            string stock = tbStock.Text.Trim();
            string marca = tbMarca.Text.Trim();
            string precio = tbPrecio.Text.Trim();
            string descripcion = tbDescripcion.Text.Trim();

            string cadenaProveedores = cbProveedores.SelectedItem.ToString();
            string cadenaCategorias = cbCategorias.SelectedItem.ToString();

            if (cbProveedores.SelectedIndex == 0)
            {
                MessageBox.Show("TIENES QUE SELECCIONAR UN PROVEEDOR");
            }
            else
            {
                string[] valoresProveedores = cadenaProveedores.Split(',');
                string idProveedor = valoresProveedores[0].Trim();

                string[] valoresCategorias = cadenaCategorias.Split(',');
                string idCategoria = valoresCategorias[0].Trim();

                Producto nuevoProducto = new Producto("", nomProducto, stock, marca, precio, descripcion, idProveedor, idCategoria);

                string resultado = metodosProductos.ValidarProducto(nuevoProducto);

                if (resultado.Equals("OK"))
                {
                    resultado = metodosProductos.AgregarProducto(nuevoProducto);
                }

                MessageBox.Show(resultado);
                LimpiarCampos();
                this.datos.Reset();
                this.MostrarProductos();
                nuevoProducto = null;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idProducto != 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string resultado = metodosProductos.EliminarProducto(idProducto);
                    MessageBox.Show(resultado);

                    LimpiarCampos();
                    this.datos.Reset();
                    this.MostrarProductos();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto antes de intentar eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string idProducto = tbActIdProducto.Text.Trim();
            string nomProducto = tbActNomProducto.Text.Trim();
            string stock = tbActStock.Text.Trim();
            string marca = tbActMarca.Text.Trim();
            string precio = tbActPrecio.Text.Trim();
            string descripcion = tbActDescripcion.Text.Trim();

            string cadenaProveedores = cbActProveedores.SelectedItem.ToString();
            string cadenaCategorias = cbActCategorias.SelectedItem.ToString();

            if (cbActProveedores.SelectedIndex == 0)
            {
                MessageBox.Show("TIENES QUE SELECCIONAR UN PROVEEDOR");
            }
            if (cbActCategorias.SelectedIndex == 0)
            {
                MessageBox.Show("TIENES QUE SELECCIONAR UN PROVEEDOR");
            }
            else
            {
                string[] valoresProveedores = cadenaProveedores.Split(',');
                string idProveedor = valoresProveedores[0].Trim();

                string[] valoresCategorias = cadenaCategorias.Split(',');
                string idCategoria = valoresCategorias[0].Trim();

                Producto actualizarProducto = new Producto(idProducto, nomProducto, stock, marca, precio, descripcion, idProveedor, idCategoria);
                string resultado = metodosProductos.ValidarProducto(actualizarProducto);
                if (resultado.Equals("OK"))
                {
                    resultado = metodosProductos.ActualizarProducto(actualizarProducto);
                }

                MessageBox.Show(resultado);
                LimpiarCampos();
                this.datos.Reset();
                this.MostrarProductos();
                actualizarProducto = null;
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            this.datos.Reset();
            metodosProductos = new MetodosProductos();
            datos = metodosProductos.BuscarProducto(tbBuscarProducto.Text.Trim());
            FormatoTablaProductos(datos);
            LimpiarCampos();
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            this.datos.Reset();
            this.MostrarProductos();
        }

        private void LimpiarCampos()
        {
            idProducto = 0;

            tbIdProducto.Text = "";
            tbNomProducto.Text = "";
            tbStock.Text = "";
            tbPrecio.Text = "";
            tbDescripcion.Text = "";
            cbProveedores.SelectedIndex = 0;
        }

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void DGVProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                LimpiarCampos();
            }
            else
            {
                idProducto = Convert.ToInt32(DGVProductos.Rows[e.RowIndex].Cells["ID PRODUCTO"].Value.ToString().Trim());
                tbActIdProducto.Text = DGVProductos.Rows[e.RowIndex].Cells["ID PRODUCTO"].Value.ToString().Trim();
                tbActNomProducto.Text = DGVProductos.Rows[e.RowIndex].Cells["PRODUCTO"].Value.ToString().Trim();
                tbActStock.Text = DGVProductos.Rows[e.RowIndex].Cells["STOCK"].Value.ToString().Trim();
                tbActMarca.Text = DGVProductos.Rows[e.RowIndex].Cells["MARCA"].Value.ToString().Trim();
                tbActPrecio.Text = DGVProductos.Rows[e.RowIndex].Cells["PRECIO"].Value.ToString().Trim();
                tbActDescripcion.Text = DGVProductos.Rows[e.RowIndex].Cells["DESCRIPCION"].Value.ToString().Trim();
                cbActProveedores.SelectedIndex = Convert.ToInt32(DGVProductos.Rows[e.RowIndex].Cells["ID PROVEEDOR"].Value.ToString().Trim());
                cbActCategorias.SelectedIndex = Convert.ToInt32(DGVProductos.Rows[e.RowIndex].Cells["ID CATEGORIA"].Value.ToString().Trim());
            }
        }

        private void cbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}