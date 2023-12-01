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
    public partial class FormEmpleados : Form 
    {
        MetodosEmpleados metodosEmpleados; 
        DataTable datos;
        int idEmpleado = 0; 

        public FormEmpleados() 
        {
            InitializeComponent();
        }

        private void FormEmpleados_Load(object sender, EventArgs e) 
        {
            this.MostrarEmpleados(); 
        }

        public void MostrarEmpleados() 
        {
            metodosEmpleados = new MetodosEmpleados();
            datos = metodosEmpleados.ObtenerEmpleados(); 
            FormatoTablaEmpleados(datos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreEmpleado = tbEmpleado.Text; 
            string telefonoEmpleado = tbNumero.Text; 
            string direccionEmpleado = tbDireccion.Text; 
            string correoEmpleado = tbEmail.Text;
            string ciEmpleado = tbCi.Text;

            Empleado nuevoEmpleado = new Empleado(nombreEmpleado, telefonoEmpleado, direccionEmpleado, correoEmpleado, ciEmpleado);

            string resultado = metodosEmpleados.ValidarEmpleado(nuevoEmpleado);
            {
                resultado = metodosEmpleados.AgregarEmpleado(nuevoEmpleado); 
            }

            MessageBox.Show(resultado);
            LimpiarCampos();
            this.datos.Reset();
            this.MostrarEmpleados(); 
            nuevoEmpleado = null;
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e) 
        {
            this.datos.Reset();
            metodosEmpleados = new MetodosEmpleados();
            datos = metodosEmpleados.BuscarEmpleado(tbBuscarEmpleado.Text.Trim());
            FormatoTablaEmpleados(datos); 
            LimpiarCampos();
        }

        private void btnMostrarEmpleados_Click(object sender, EventArgs e) 
        {
            this.LimpiarCampos();
            this.datos.Reset();
            this.MostrarEmpleados(); 
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombreEmpleado = tbActEmpleado.Text; 
            string telefonoEmpleado = tbActNumero.Text; 
            string direccionEmpleado = tbActDireccion.Text; 
            string correoEmpleado = tbActEmail.Text;
            string ciEmpleado = tbActCi.Text; 

            Empleado actualizarEmpleado = new Empleado(nombreEmpleado, telefonoEmpleado, direccionEmpleado, correoEmpleado, ciEmpleado);

            string resultado = metodosEmpleados.ValidarEmpleado(actualizarEmpleado);
            if (resultado.Equals("OK"))
            {
                resultado = metodosEmpleados.ActualizarEmpleado(idEmpleado, actualizarEmpleado); 
            }

            MessageBox.Show(resultado);
            LimpiarCampos();
            this.datos.Reset();
            this.MostrarEmpleados(); 
            actualizarEmpleado = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idEmpleado != 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar este empleado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string resultado = metodosEmpleados.EliminarEmpleado(idEmpleado);
                    MessageBox.Show(resultado);

                    LimpiarCampos();
                    this.datos.Reset();
                    this.MostrarEmpleados(); 
                }
            }
            else
            {
                MessageBox.Show("Selecciona un empleado antes de intentar eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FormatoTablaEmpleados(DataTable datos) 
        {
            try
            {
                datos.Columns["id_empleado"].ColumnName = "ID"; 
                datos.Columns["nombre_empleado"].ColumnName = "EMPLEADO"; 
                datos.Columns["telefono_empleado"].ColumnName = "NUMERO CONTACTO";
                datos.Columns["direccion_empleado"].ColumnName = "DIRECCION";
                datos.Columns["correo_empleado"].ColumnName = "CORREO"; 
                datos.Columns["ci_empleado"].ColumnName = "CI";

                DGVEmpleados.DataSource = datos; 
                DGVEmpleados.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVEmpleados.Columns["EMPLEADO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVEmpleados.Columns["NUMERO CONTACTO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVEmpleados.Columns["DIRECCION"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVEmpleados.Columns["CORREO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGVEmpleados.Columns["CI"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //txtTotalProveedores.Text = "Total de proveedores: " + datos.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            idEmpleado = 0;

            tbEmpleado.Text = "";
            tbNumero.Text = "";
            tbDireccion.Text = "";
            tbEmail.Text = "";
            tbCi.Text = "";

            tbActEmpleado.Text = "";
            tbActNumero.Text = "";
            tbActDireccion.Text = "";
            tbActEmail.Text = "";
            tbActCi.Text = "";
        }

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

         
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void DGVEmpleados_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex == -1)
            {
                LimpiarCampos();
            }
            else
            {
                idEmpleado = Convert.ToInt32(DGVEmpleados.Rows[e.RowIndex].Cells["ID"].Value.ToString().Trim()); 
                tbActEmpleado.Text = DGVEmpleados.Rows[e.RowIndex].Cells["EMPLEADO"].Value.ToString().Trim(); 
                tbActNumero.Text = DGVEmpleados.Rows[e.RowIndex].Cells["NUMERO CONTACTO"].Value.ToString().Trim(); 
                tbActDireccion.Text = DGVEmpleados.Rows[e.RowIndex].Cells["DIRECCION"].Value.ToString().Trim();
                tbActEmail.Text = DGVEmpleados.Rows[e.RowIndex].Cells["CORREO"].Value.ToString().Trim(); 
                tbActCi.Text = DGVEmpleados.Rows[e.RowIndex].Cells["CI"].Value.ToString().Trim();
            }
        }
    }
}
