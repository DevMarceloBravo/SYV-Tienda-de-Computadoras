namespace TiendaComputadoras.Vistas
{
    partial class FormEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.N = new System.Windows.Forms.Button();
            this.DGVEmpleados = new System.Windows.Forms.DataGridView();
            this.tbActCi = new System.Windows.Forms.TextBox();
            this.tbCi = new System.Windows.Forms.TextBox();
            this.tbActEmail = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbActDireccion = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbActNumero = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbActEmpleado = new System.Windows.Forms.TextBox();
            this.tbBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.tbEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(221, 636);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 34);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 34);
            this.button1.TabIndex = 33;
            this.button1.Text = "ACTUALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1150, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 34);
            this.button3.TabIndex = 32;
            this.button3.Text = "MOSTRAR TODOS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnMostrarEmpleados_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1036, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 34);
            this.button2.TabIndex = 31;
            this.button2.Text = "BUSCAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(221, 19);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(91, 34);
            this.N.TabIndex = 30;
            this.N.Text = "AGREGAR";
            this.N.UseVisualStyleBackColor = true;
            this.N.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // DGVEmpleados
            // 
            this.DGVEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmpleados.Location = new System.Drawing.Point(374, 73);
            this.DGVEmpleados.Name = "DGVEmpleados";
            this.DGVEmpleados.Size = new System.Drawing.Size(867, 645);
            this.DGVEmpleados.TabIndex = 29;
            this.DGVEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEmpleados_CellClick);
            // 
            // tbActCi
            // 
            this.tbActCi.Location = new System.Drawing.Point(30, 555);
            this.tbActCi.Name = "tbActCi";
            this.tbActCi.Size = new System.Drawing.Size(282, 20);
            this.tbActCi.TabIndex = 27;
            // 
            // tbCi
            // 
            this.tbCi.Location = new System.Drawing.Point(30, 259);
            this.tbCi.Name = "tbCi";
            this.tbCi.Size = new System.Drawing.Size(282, 20);
            this.tbCi.TabIndex = 26;
            // 
            // tbActEmail
            // 
            this.tbActEmail.Location = new System.Drawing.Point(30, 505);
            this.tbActEmail.Name = "tbActEmail";
            this.tbActEmail.Size = new System.Drawing.Size(282, 20);
            this.tbActEmail.TabIndex = 25;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(30, 209);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(282, 20);
            this.tbEmail.TabIndex = 24;
            // 
            // tbActDireccion
            // 
            this.tbActDireccion.Location = new System.Drawing.Point(30, 455);
            this.tbActDireccion.Name = "tbActDireccion";
            this.tbActDireccion.Size = new System.Drawing.Size(282, 20);
            this.tbActDireccion.TabIndex = 23;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(30, 159);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(282, 20);
            this.tbDireccion.TabIndex = 22;
            // 
            // tbActNumero
            // 
            this.tbActNumero.Location = new System.Drawing.Point(30, 406);
            this.tbActNumero.Name = "tbActNumero";
            this.tbActNumero.Size = new System.Drawing.Size(282, 20);
            this.tbActNumero.TabIndex = 21;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(30, 110);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(282, 20);
            this.tbNumero.TabIndex = 20;
            // 
            // tbActEmpleado
            // 
            this.tbActEmpleado.Location = new System.Drawing.Point(30, 366);
            this.tbActEmpleado.Name = "tbActEmpleado";
            this.tbActEmpleado.Size = new System.Drawing.Size(282, 20);
            this.tbActEmpleado.TabIndex = 28;
            // 
            // tbBuscarEmpleado
            // 
            this.tbBuscarEmpleado.Location = new System.Drawing.Point(528, 23);
            this.tbBuscarEmpleado.Name = "tbBuscarEmpleado";
            this.tbBuscarEmpleado.Size = new System.Drawing.Size(478, 20);
            this.tbBuscarEmpleado.TabIndex = 19;
            // 
            // tbEmpleado
            // 
            this.tbEmpleado.Location = new System.Drawing.Point(30, 70);
            this.tbEmpleado.Name = "tbEmpleado";
            this.tbEmpleado.Size = new System.Drawing.Size(282, 20);
            this.tbEmpleado.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 636);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "ELIMINAR EMPLEADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 319);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 14);
            this.label2.TabIndex = 15;
            this.label2.Text = "MODIFICAR EMPLEADO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 539);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "CI:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 243);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "CI:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 489);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "CORREO ELECTRONICO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 193);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "CORREO ELECTRONICO:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 439);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "DIRECCION:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "DIRECCION:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 392);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "TELEFONO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "TELEFONO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 350);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "NOMBRE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "NOMBRE:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(371, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 14);
            this.label14.TabIndex = 17;
            this.label14.Text = "BUSCAR EMPLEADO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "AGREGAR EMPLEADO";
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 742);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.N);
            this.Controls.Add(this.DGVEmpleados);
            this.Controls.Add(this.tbActCi);
            this.Controls.Add(this.tbCi);
            this.Controls.Add(this.tbActEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbActDireccion);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbActNumero);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.tbActEmpleado);
            this.Controls.Add(this.tbBuscarEmpleado);
            this.Controls.Add(this.tbEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Name = "FormEmpleados";
            this.Text = "EMPLEADOS";
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button N;
        private System.Windows.Forms.DataGridView DGVEmpleados;
        private System.Windows.Forms.TextBox tbActCi;
        private System.Windows.Forms.TextBox tbCi;
        private System.Windows.Forms.TextBox tbActEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbActDireccion;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbActNumero;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbActEmpleado;
        private System.Windows.Forms.TextBox tbBuscarEmpleado;
        private System.Windows.Forms.TextBox tbEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
    }
}