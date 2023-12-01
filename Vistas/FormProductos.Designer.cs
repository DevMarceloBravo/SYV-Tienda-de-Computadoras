namespace TiendaComputadoras.Vistas
{
    partial class FormProductos
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
            this.DGVProductos = new System.Windows.Forms.DataGridView();
            this.tbActDescripcion = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbActPrecio = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbActStock = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.tbActNomProducto = new System.Windows.Forms.TextBox();
            this.tbNomProducto = new System.Windows.Forms.TextBox();
            this.tbActIdProducto = new System.Windows.Forms.TextBox();
            this.tbBuscarProducto = new System.Windows.Forms.TextBox();
            this.tbIdProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            this.cbActProveedores = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbActMarca = new System.Windows.Forms.TextBox();
            this.cbActCategorias = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(213, 720);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 34);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 34);
            this.button1.TabIndex = 33;
            this.button1.Text = "ACTUALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1141, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 34);
            this.button3.TabIndex = 32;
            this.button3.Text = "MOSTRAR TODOS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnMostrarProductos_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1027, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 34);
            this.button2.TabIndex = 31;
            this.button2.Text = "BUSCAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(212, 12);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(91, 34);
            this.N.TabIndex = 30;
            this.N.Text = "AGREGAR";
            this.N.UseVisualStyleBackColor = true;
            this.N.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // DGVProductos
            // 
            this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductos.Location = new System.Drawing.Point(365, 76);
            this.DGVProductos.Name = "DGVProductos";
            this.DGVProductos.Size = new System.Drawing.Size(867, 645);
            this.DGVProductos.TabIndex = 29;
            this.DGVProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProductos_CellClick);
            // 
            // tbActDescripcion
            // 
            this.tbActDescripcion.Location = new System.Drawing.Point(22, 614);
            this.tbActDescripcion.Name = "tbActDescripcion";
            this.tbActDescripcion.Size = new System.Drawing.Size(282, 20);
            this.tbActDescripcion.TabIndex = 27;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(21, 252);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(282, 20);
            this.tbDescripcion.TabIndex = 26;
            // 
            // tbActPrecio
            // 
            this.tbActPrecio.Location = new System.Drawing.Point(21, 569);
            this.tbActPrecio.Name = "tbActPrecio";
            this.tbActPrecio.Size = new System.Drawing.Size(282, 20);
            this.tbActPrecio.TabIndex = 25;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(21, 213);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(282, 20);
            this.tbPrecio.TabIndex = 24;
            // 
            // tbActStock
            // 
            this.tbActStock.Location = new System.Drawing.Point(21, 526);
            this.tbActStock.Name = "tbActStock";
            this.tbActStock.Size = new System.Drawing.Size(282, 20);
            this.tbActStock.TabIndex = 23;
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(21, 174);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(282, 20);
            this.tbStock.TabIndex = 22;
            // 
            // tbActNomProducto
            // 
            this.tbActNomProducto.Location = new System.Drawing.Point(21, 442);
            this.tbActNomProducto.Name = "tbActNomProducto";
            this.tbActNomProducto.Size = new System.Drawing.Size(282, 20);
            this.tbActNomProducto.TabIndex = 21;
            // 
            // tbNomProducto
            // 
            this.tbNomProducto.Location = new System.Drawing.Point(21, 92);
            this.tbNomProducto.Name = "tbNomProducto";
            this.tbNomProducto.Size = new System.Drawing.Size(282, 20);
            this.tbNomProducto.TabIndex = 20;
            // 
            // tbActIdProducto
            // 
            this.tbActIdProducto.Location = new System.Drawing.Point(21, 402);
            this.tbActIdProducto.Name = "tbActIdProducto";
            this.tbActIdProducto.Size = new System.Drawing.Size(282, 20);
            this.tbActIdProducto.TabIndex = 28;
            // 
            // tbBuscarProducto
            // 
            this.tbBuscarProducto.Location = new System.Drawing.Point(523, 24);
            this.tbBuscarProducto.Name = "tbBuscarProducto";
            this.tbBuscarProducto.Size = new System.Drawing.Size(478, 20);
            this.tbBuscarProducto.TabIndex = 19;
            // 
            // tbIdProducto
            // 
            this.tbIdProducto.Location = new System.Drawing.Point(21, 53);
            this.tbIdProducto.Name = "tbIdProducto";
            this.tbIdProducto.Size = new System.Drawing.Size(282, 20);
            this.tbIdProducto.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 730);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "ELIMINAR PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 355);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 14);
            this.label2.TabIndex = 15;
            this.label2.Text = "MODIFICAR PRODUCTO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 236);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "DESCRIPCION:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 197);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "PRECIO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "STOCK:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "PRODUCTO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID PRODUCTO:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(362, 26);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 14);
            this.label14.TabIndex = 17;
            this.label14.Text = "BUSCAR PRODUCTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "AGREGAR PRODUCTO";
            // 
            // cbProveedores
            // 
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.Location = new System.Drawing.Point(182, 278);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(121, 21);
            this.cbProveedores.TabIndex = 35;
            this.cbProveedores.SelectedIndexChanged += new System.EventHandler(this.cbProveedores_SelectedIndexChanged);
            // 
            // cbActProveedores
            // 
            this.cbActProveedores.FormattingEnabled = true;
            this.cbActProveedores.Location = new System.Drawing.Point(183, 640);
            this.cbActProveedores.Name = "cbActProveedores";
            this.cbActProveedores.Size = new System.Drawing.Size(121, 21);
            this.cbActProveedores.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 648);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "SELECCIONAR PROVEEDOR:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 286);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(156, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "SELECCIONAR PROVEEDOR:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 386);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "ID PRODUCTO:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 428);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "PRODUCTO:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 510);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "STOCK:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 553);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "PRECIO:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 598);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "DESCRIPCION:";
            // 
            // cbCategorias
            // 
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(182, 314);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(121, 21);
            this.cbCategorias.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 317);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(150, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "SELECCIONAR CATEGORIA:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 119);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "MARCA:";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(21, 135);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(282, 20);
            this.tbMarca.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 468);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "MARCA:";
            // 
            // tbActMarca
            // 
            this.tbActMarca.Location = new System.Drawing.Point(23, 484);
            this.tbActMarca.Name = "tbActMarca";
            this.tbActMarca.Size = new System.Drawing.Size(282, 20);
            this.tbActMarca.TabIndex = 20;
            // 
            // cbActCategorias
            // 
            this.cbActCategorias.FormattingEnabled = true;
            this.cbActCategorias.Location = new System.Drawing.Point(182, 677);
            this.cbActCategorias.Name = "cbActCategorias";
            this.cbActCategorias.Size = new System.Drawing.Size(121, 21);
            this.cbActCategorias.TabIndex = 35;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 685);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(153, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "SELECCIONAR CATEGORIA::";
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 766);
            this.Controls.Add(this.cbActCategorias);
            this.Controls.Add(this.cbActProveedores);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.cbProveedores);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.N);
            this.Controls.Add(this.DGVProductos);
            this.Controls.Add(this.tbActDescripcion);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbActPrecio);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbActStock);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.tbActNomProducto);
            this.Controls.Add(this.tbActMarca);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.tbNomProducto);
            this.Controls.Add(this.tbActIdProducto);
            this.Controls.Add(this.tbBuscarProducto);
            this.Controls.Add(this.tbIdProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Name = "FormProductos";
            this.Text = "PRODUCTOS";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button N;
        private System.Windows.Forms.DataGridView DGVProductos;
        private System.Windows.Forms.TextBox tbActDescripcion;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbActPrecio;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbActStock;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.TextBox tbActNomProducto;
        private System.Windows.Forms.TextBox tbNomProducto;
        private System.Windows.Forms.TextBox tbActIdProducto;
        private System.Windows.Forms.TextBox tbBuscarProducto;
        private System.Windows.Forms.TextBox tbIdProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProveedores;
        private System.Windows.Forms.ComboBox cbActProveedores;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbActMarca;
        private System.Windows.Forms.ComboBox cbActCategorias;
        private System.Windows.Forms.Label label20;
    }
}