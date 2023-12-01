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
    public partial class FormClientes : Form
    {
        MetodosClientes metodosClientes;
        DataTable datos;
        int idCliente = 0;

        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            this.MostrarClientes();
        }

        public void MostrarClientes()
        {
            metodosClientes = new MetodosClientes();
            datos = metodosClientes.ObtenerClientes();
            FormatoTablaClientes(datos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreCliente = tbCliente.Text;
            string telefonoCliente = tbNumero.Text;
            string direccionCliente = tbDireccion.Text;
            string correoCliente = tbEmail.Text;
            string nitCliente = tbNit.Text;

            Cliente nuevoCliente = new Cliente(nombreCliente, telefonoCliente, direccionCliente, correoCliente, nitCliente);

            string resultado = metodosClientes.ValidarCliente(nuevoCliente);
            if (resultado.Equals("OK"))
            {
                resultado = metodosClientes.AgregarCliente(nuevoCliente);
            }

            MessageBox.Show(resultado);
            LimpiarCampos();
            this.datos.Reset();
            this.MostrarClientes();
            nuevoCliente = null;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            this.datos.Reset();
            metodosClientes = new MetodosClientes();
            datos = metodosClientes.BuscarCliente(ttbBuscarCliente.Text.Trim());
            FormatoTablaClientes(datos);
            LimpiarCampos();
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            this.datos.Reset();
            this.MostrarClientes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombreCliente = tbActCliente.Text;
            string telefonoCliente = tbActNumero.Text;
            string direccionCliente = tbActDireccion.Text;
            string correoCliente = tbActEmail.Text;
            string nitCliente = tbActNit.Text;

            Cliente actualizarCliente = new Cliente(nombreCliente, telefonoCliente, direccionCliente, correoCliente, nitCliente);

            string resultado = metodosClientes.ValidarCliente(actualizarCliente);
            if (resultado.Equals("OK"))
            {
                resultado = metodosClientes.ActualizarCliente(idCliente, actualizarCliente);
            }

            MessageBox.Show(resultado);
            LimpiarCampos();
            this.datos.Reset();
            this.MostrarClientes();
            actualizarCliente = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idCliente != 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string resultado = metodosClientes.EliminarCliente(idCliente);
                    MessageBox.Show(resultado);

                    LimpiarCampos();
                    this.datos.Reset();
                    this.MostrarClientes();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un cliente antes de intentar eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FormatoTablaClientes(DataTable datos)
        {
            try
            {
                datos.Columns["id_cliente"].ColumnName = "ID";
                datos.Columns["nombre_cliente"].ColumnName = "CLIENTE";
                datos.Columns["telefono_cliente"].ColumnName = "NUMERO CONTACTO";
                datos.Columns["direccion_cliente"].ColumnName = "DIRECCION";
                datos.Columns["correo_cliente"].ColumnName = "CORREO";
                datos.Columns["nit_cliente"].ColumnName = "NIT";

                DGVClientes.DataSource = datos;
                DGVClientes.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVClientes.Columns["CLIENTE"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVClientes.Columns["NUMERO CONTACTO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVClientes.Columns["DIRECCION"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVClientes.Columns["CORREO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVClientes.Columns["NIT"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //txtTotalClientes.Text = "Total de clientes: " + datos.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            idCliente = 0;

            tbCliente.Text = "";
            tbNumero.Text = "";
            tbDireccion.Text = "";
            tbEmail.Text = "";
            tbNit.Text = "";

            tbActCliente.Text = "";
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

        private void DGVClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                LimpiarCampos();
            }
            else
            {
                idCliente = Convert.ToInt32(DGVClientes.Rows[e.RowIndex].Cells["ID"].Value.ToString().Trim());
                tbActCliente.Text = DGVClientes.Rows[e.RowIndex].Cells["CLIENTE"].Value.ToString().Trim();
                tbActNumero.Text = DGVClientes.Rows[e.RowIndex].Cells["NUMERO CONTACTO"].Value.ToString().Trim();
                tbActDireccion.Text = DGVClientes.Rows[e.RowIndex].Cells["DIRECCION"].Value.ToString().Trim();
                tbActEmail.Text = DGVClientes.Rows[e.RowIndex].Cells["CORREO"].Value.ToString().Trim();
                tbActNit.Text = DGVClientes.Rows[e.RowIndex].Cells["NIT"].Value.ToString().Trim();
            }
        }
    }
}
