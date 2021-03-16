
namespace WindowsTienda
{
    partial class VENDEDOR
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.cbFormaPago = new System.Windows.Forms.ComboBox();
            this.cbCuotas = new System.Windows.Forms.ComboBox();
            this.txtPorcCuotas = new System.Windows.Forms.TextBox();
            this.txtValorCuotas = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCargarVenta = new System.Windows.Forms.Button();
            this.btnCalcularTotal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbRecibo = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecioUnit = new System.Windows.Forms.TextBox();
            this.btnTraerRecibo = new System.Windows.Forms.Button();
            this.tbIdRecibo = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnListarProd = new System.Windows.Forms.Button();
            this.btnListarVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(141, 217);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(167, 22);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.Text = "Cantidad";
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(141, 159);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(167, 24);
            this.cbProducto.TabIndex = 3;
            this.cbProducto.Text = "Producto...";
            this.cbProducto.SelectedIndexChanged += new System.EventHandler(this.cbProducto_SelectedIndexChanged);
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.AutoCompleteCustomSource.AddRange(new string[] {
            "Tarjeta",
            "Efectivo"});
            this.cbFormaPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbFormaPago.FormattingEnabled = true;
            this.cbFormaPago.Location = new System.Drawing.Point(141, 245);
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Size = new System.Drawing.Size(167, 24);
            this.cbFormaPago.TabIndex = 6;
            this.cbFormaPago.Text = "Tarjeta o Efectivo...";
            this.cbFormaPago.SelectedIndexChanged += new System.EventHandler(this.cbFormaPago_SelectedIndexChanged);
            // 
            // cbCuotas
            // 
            this.cbCuotas.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "6"});
            this.cbCuotas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbCuotas.FormattingEnabled = true;
            this.cbCuotas.Location = new System.Drawing.Point(141, 275);
            this.cbCuotas.Name = "cbCuotas";
            this.cbCuotas.Size = new System.Drawing.Size(167, 24);
            this.cbCuotas.TabIndex = 9;
            this.cbCuotas.Text = "Cantidad cuotas...";
            // 
            // txtPorcCuotas
            // 
            this.txtPorcCuotas.Location = new System.Drawing.Point(141, 305);
            this.txtPorcCuotas.Name = "txtPorcCuotas";
            this.txtPorcCuotas.ReadOnly = true;
            this.txtPorcCuotas.Size = new System.Drawing.Size(167, 22);
            this.txtPorcCuotas.TabIndex = 10;
            this.txtPorcCuotas.Text = "CFT Cuotas (autocomp)";
            // 
            // txtValorCuotas
            // 
            this.txtValorCuotas.Location = new System.Drawing.Point(141, 333);
            this.txtValorCuotas.Name = "txtValorCuotas";
            this.txtValorCuotas.ReadOnly = true;
            this.txtValorCuotas.Size = new System.Drawing.Size(167, 22);
            this.txtValorCuotas.TabIndex = 11;
            this.txtValorCuotas.Text = "Valor cuotas... (autocomp)";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(142, 360);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(167, 22);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.Text = "TOTAL";
            // 
            // btnCargarVenta
            // 
            this.btnCargarVenta.BackColor = System.Drawing.Color.Crimson;
            this.btnCargarVenta.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarVenta.ForeColor = System.Drawing.Color.White;
            this.btnCargarVenta.Location = new System.Drawing.Point(143, 427);
            this.btnCargarVenta.Name = "btnCargarVenta";
            this.btnCargarVenta.Size = new System.Drawing.Size(166, 33);
            this.btnCargarVenta.TabIndex = 14;
            this.btnCargarVenta.Text = "Cargar Venta";
            this.btnCargarVenta.UseVisualStyleBackColor = false;
            this.btnCargarVenta.Click += new System.EventHandler(this.btnCargarVenta_Click);
            // 
            // btnCalcularTotal
            // 
            this.btnCalcularTotal.BackColor = System.Drawing.Color.Crimson;
            this.btnCalcularTotal.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularTotal.ForeColor = System.Drawing.Color.White;
            this.btnCalcularTotal.Location = new System.Drawing.Point(143, 388);
            this.btnCalcularTotal.Name = "btnCalcularTotal";
            this.btnCalcularTotal.Size = new System.Drawing.Size(166, 33);
            this.btnCalcularTotal.TabIndex = 17;
            this.btnCalcularTotal.Text = "Calcular total";
            this.btnCalcularTotal.UseVisualStyleBackColor = false;
            this.btnCalcularTotal.Click += new System.EventHandler(this.btnCalcularTotal_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cargar Venta";
            // 
            // gridProductos
            // 
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Location = new System.Drawing.Point(395, 159);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.RowHeadersWidth = 51;
            this.gridProductos.RowTemplate.Height = 24;
            this.gridProductos.Size = new System.Drawing.Size(1072, 644);
            this.gridProductos.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Id Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(36, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Medio pago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(36, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Cuotas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(36, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Porc Interes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(36, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Interes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1476, 98);
            this.panel1.TabIndex = 29;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = global::WindowsTienda.Properties.Resources.Logout__Custom_;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(1325, 13);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(141, 61);
            this.btnLogout.TabIndex = 31;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 19.8F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(575, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(273, 42);
            this.label10.TabIndex = 30;
            this.label10.Text = "PANEL VENDEDOR";
            // 
            // tbRecibo
            // 
            this.tbRecibo.Location = new System.Drawing.Point(34, 468);
            this.tbRecibo.Name = "tbRecibo";
            this.tbRecibo.Size = new System.Drawing.Size(335, 303);
            this.tbRecibo.TabIndex = 30;
            this.tbRecibo.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Precio Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(36, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Precio Unit";
            // 
            // txtPrecioUnit
            // 
            this.txtPrecioUnit.Location = new System.Drawing.Point(141, 189);
            this.txtPrecioUnit.Name = "txtPrecioUnit";
            this.txtPrecioUnit.ReadOnly = true;
            this.txtPrecioUnit.Size = new System.Drawing.Size(167, 22);
            this.txtPrecioUnit.TabIndex = 33;
            // 
            // btnTraerRecibo
            // 
            this.btnTraerRecibo.BackColor = System.Drawing.Color.Crimson;
            this.btnTraerRecibo.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraerRecibo.ForeColor = System.Drawing.Color.White;
            this.btnTraerRecibo.Location = new System.Drawing.Point(124, 777);
            this.btnTraerRecibo.Name = "btnTraerRecibo";
            this.btnTraerRecibo.Size = new System.Drawing.Size(129, 33);
            this.btnTraerRecibo.TabIndex = 34;
            this.btnTraerRecibo.Text = "Traer Recibo";
            this.btnTraerRecibo.UseVisualStyleBackColor = false;
            this.btnTraerRecibo.Click += new System.EventHandler(this.btnTraerRecibo_Click);
            // 
            // tbIdRecibo
            // 
            this.tbIdRecibo.Location = new System.Drawing.Point(34, 783);
            this.tbIdRecibo.Name = "tbIdRecibo";
            this.tbIdRecibo.Size = new System.Drawing.Size(84, 22);
            this.tbIdRecibo.TabIndex = 35;
            this.tbIdRecibo.Text = "Id Venta...";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Crimson;
            this.btnImprimir.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(259, 777);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(110, 33);
            this.btnImprimir.TabIndex = 36;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnListarProd
            // 
            this.btnListarProd.BackColor = System.Drawing.Color.Crimson;
            this.btnListarProd.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarProd.ForeColor = System.Drawing.Color.White;
            this.btnListarProd.Location = new System.Drawing.Point(395, 114);
            this.btnListarProd.Name = "btnListarProd";
            this.btnListarProd.Size = new System.Drawing.Size(145, 33);
            this.btnListarProd.TabIndex = 37;
            this.btnListarProd.Text = "Listar Productos";
            this.btnListarProd.UseVisualStyleBackColor = false;
            this.btnListarProd.Click += new System.EventHandler(this.btnListarProd_Click);
            // 
            // btnListarVentas
            // 
            this.btnListarVentas.BackColor = System.Drawing.Color.Crimson;
            this.btnListarVentas.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarVentas.ForeColor = System.Drawing.Color.White;
            this.btnListarVentas.Location = new System.Drawing.Point(546, 114);
            this.btnListarVentas.Name = "btnListarVentas";
            this.btnListarVentas.Size = new System.Drawing.Size(147, 33);
            this.btnListarVentas.TabIndex = 38;
            this.btnListarVentas.Text = "Listar Ventas";
            this.btnListarVentas.UseVisualStyleBackColor = false;
            this.btnListarVentas.Click += new System.EventHandler(this.btnListarVentas_Click);
            // 
            // VENDEDOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1479, 839);
            this.Controls.Add(this.btnListarVentas);
            this.Controls.Add(this.btnListarProd);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.tbIdRecibo);
            this.Controls.Add(this.btnTraerRecibo);
            this.Controls.Add(this.txtPrecioUnit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRecibo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcularTotal);
            this.Controls.Add(this.btnCargarVenta);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtValorCuotas);
            this.Controls.Add(this.txtPorcCuotas);
            this.Controls.Add(this.cbCuotas);
            this.Controls.Add(this.cbFormaPago);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.txtCantidad);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "VENDEDOR";
            this.Text = "Tienda Infantil - Panel Vendedor";
            this.Load += new System.EventHandler(this.Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.ComboBox cbFormaPago;
        private System.Windows.Forms.ComboBox cbCuotas;
        private System.Windows.Forms.TextBox txtPorcCuotas;
        private System.Windows.Forms.TextBox txtValorCuotas;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCargarVenta;
        private System.Windows.Forms.Button btnCalcularTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.RichTextBox tbRecibo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrecioUnit;
        private System.Windows.Forms.Button btnTraerRecibo;
        private System.Windows.Forms.TextBox tbIdRecibo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnListarProd;
        private System.Windows.Forms.Button btnListarVentas;
    }
}