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
    public partial class FormProveedores : Form
    {
        MetodosProveedores metodosProveedores;
        DataTable datos;
        int idProveedor = 0;

        public FormProveedores()
        {
            InitializeComponent();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            this.MostrarProveedores();
        }

        public void MostrarProveedores()
        {
            metodosProveedores = new MetodosProveedores();
            datos = metodosProveedores.ObtenerProveedores();
            FormatoTablaProveedores(datos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreProveedor = tbProveedor.Text;
            string telefonoProveedor = tbNumero.Text;
            string direccionProveedor = tbDireccion.Text;
            string correoProveedor = tbEmail.Text;
            string nitProveedor = tbNit.Text;  

            Proveedor nuevoProveedor = new Proveedor(nombreProveedor, telefonoProveedor, direccionProveedor, correoProveedor, nitProveedor);

            string resultado = metodosProveedores.ValidarProveedor(nuevoProveedor);
            if (resultado.Equals("OK"))
            {
                resultado = metodosProveedores.AgregarProveedor(nuevoProveedor);
            }

            MessageBox.Show(resultado);
            LimpiarCampos();
            this.datos.Reset();
            this.MostrarProveedores();
            nuevoProveedor = null;
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            this.datos.Reset();
            metodosProveedores = new MetodosProveedores();
            datos = metodosProveedores.BuscarProveedor(tbBuscarProveedor.Text.Trim());
            FormatoTablaProveedores(datos);
            LimpiarCampos();
        }

        private void btnMostrarProveedores_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            this.datos.Reset();
            this.MostrarProveedores();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombreProveedor = tbActProveedor.Text;
            string telefonoProveedor = tbActNumero.Text;
            string direccionProveedor = tbActDireccion.Text;
            string correoProveedor = tbActEmail.Text;
            string nitProveedor = tbActNit.Text;

            Proveedor actualizarProveedor = new Proveedor(nombreProveedor, telefonoProveedor, direccionProveedor, correoProveedor, nitProveedor);

            string resultado = metodosProveedores.ValidarProveedor(actualizarProveedor);
            if (resultado.Equals("OK"))
            {
                resultado = metodosProveedores.ActualizarProveedor(idProveedor, actualizarProveedor);
            }

            MessageBox.Show(resultado);
            LimpiarCampos();
            this.datos.Reset();
            this.MostrarProveedores();
            actualizarProveedor = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idProveedor != 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar este proveedor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string resultado = metodosProveedores.EliminarProveedor(idProveedor);
                    MessageBox.Show(resultado);

                    LimpiarCampos();
                    this.datos.Reset();
                    this.MostrarProveedores();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un proveedor antes de intentar eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FormatoTablaProveedores(DataTable datos)
        {
            try
            {
                datos.Columns["id_proveedor"].ColumnName = "ID";
                datos.Columns["nombre_proveedor"].ColumnName = "PROVEEDOR";
                datos.Columns["telefono_proveedor"].ColumnName = "NUMERO CONTACTO";
                datos.Columns["direccion_proveedor"].ColumnName = "DIRECCION";
                datos.Columns["correo_proveedor"].ColumnName = "CORREO";
                datos.Columns["nit_proveedor"].ColumnName = "NIT";

                DGVProveedores.DataSource = datos;
                DGVProveedores.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProveedores.Columns["PROVEEDOR"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProveedores.Columns["NUMERO CONTACTO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProveedores.Columns["DIRECCION"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProveedores.Columns["CORREO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVProveedores.Columns["NIT"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //txtTotalProveedores.Text = "Total de proveedores: " + datos.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            idProveedor = 0;

            tbProveedor.Text = "";
            tbNumero.Text = "";
            tbDireccion.Text = "";
            tbEmail.Text = "";
            tbNit.Text = "";

            tbActProveedor.Text = "";
            tbActNumero.Text = "";
            tbActDireccion.Text = "";
            tbActEmail.Text = "";
            tbActNit.Text = "";
        }

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Solo permitir un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void DGVProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                LimpiarCampos();
            }
            else
            {
                idProveedor = Convert.ToInt32(DGVProveedores.Rows[e.RowIndex].Cells["ID"].Value.ToString().Trim());
                tbActProveedor.Text = DGVProveedores.Rows[e.RowIndex].Cells["PROVEEDOR"].Value.ToString().Trim();
                tbActNumero.Text = DGVProveedores.Rows[e.RowIndex].Cells["NUMERO CONTACTO"].Value.ToString().Trim();
                tbActDireccion.Text = DGVProveedores.Rows[e.RowIndex].Cells["DIRECCION"].Value.ToString().Trim();
                tbActEmail.Text = DGVProveedores.Rows[e.RowIndex].Cells["CORREO"].Value.ToString().Trim();
                tbActNit.Text = DGVProveedores.Rows[e.RowIndex].Cells["NIT"].Value.ToString().Trim();
            }
        }
    }
}
