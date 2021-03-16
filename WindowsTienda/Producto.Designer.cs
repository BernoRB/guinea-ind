
namespace WindowsTienda
{
    partial class Producto
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
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtCaracteristica = new System.Windows.Forms.TextBox();
            this.txtEstacion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtTalle = new System.Windows.Forms.TextBox();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.txtPrecioEfectivo = new System.Windows.Forms.TextBox();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.gridProds = new System.Windows.Forms.DataGridView();
            this.btnTraerTodos = new System.Windows.Forms.Button();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.btnTraerFilt = new System.Windows.Forms.Button();
            this.cbEstacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProds)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(19, 98);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(145, 22);
            this.txtCodigoProducto.TabIndex = 0;
            this.txtCodigoProducto.Text = "Masc/Fem";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(19, 154);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(145, 22);
            this.txtTipo.TabIndex = 2;
            this.txtTipo.Text = "Categoria";
            // 
            // txtCaracteristica
            // 
            this.txtCaracteristica.Location = new System.Drawing.Point(19, 182);
            this.txtCaracteristica.Name = "txtCaracteristica";
            this.txtCaracteristica.Size = new System.Drawing.Size(145, 22);
            this.txtCaracteristica.TabIndex = 3;
            this.txtCaracteristica.Text = "Tela";
            // 
            // txtEstacion
            // 
            this.txtEstacion.Location = new System.Drawing.Point(19, 126);
            this.txtEstacion.Name = "txtEstacion";
            this.txtEstacion.Size = new System.Drawing.Size(145, 22);
            this.txtEstacion.TabIndex = 1;
            this.txtEstacion.Text = "Estacion";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(19, 238);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(145, 22);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.Text = "Cantidad";
            // 
            // txtTalle
            // 
            this.txtTalle.Location = new System.Drawing.Point(19, 210);
            this.txtTalle.Name = "txtTalle";
            this.txtTalle.Size = new System.Drawing.Size(145, 22);
            this.txtTalle.TabIndex = 4;
            this.txtTalle.Text = "Talle";
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.AcceptsReturn = true;
            this.txtPrecioCosto.Location = new System.Drawing.Point(19, 266);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(145, 22);
            this.txtPrecioCosto.TabIndex = 6;
            this.txtPrecioCosto.Text = "Precio Costo";
            // 
            // txtPrecioEfectivo
            // 
            this.txtPrecioEfectivo.Location = new System.Drawing.Point(19, 294);
            this.txtPrecioEfectivo.Name = "txtPrecioEfectivo";
            this.txtPrecioEfectivo.Size = new System.Drawing.Size(145, 22);
            this.txtPrecioEfectivo.TabIndex = 7;
            this.txtPrecioEfectivo.Text = "Precio Venta";
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(19, 322);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(145, 22);
            this.txtNotas.TabIndex = 8;
            this.txtNotas.Text = "Notas";
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.Crimson;
            this.btnInsertar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsertar.Location = new System.Drawing.Point(47, 350);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(117, 32);
            this.btnInsertar.TabIndex = 9;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // gridProds
            // 
            this.gridProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProds.Location = new System.Drawing.Point(187, 98);
            this.gridProds.Name = "gridProds";
            this.gridProds.RowHeadersWidth = 51;
            this.gridProds.RowTemplate.Height = 24;
            this.gridProds.Size = new System.Drawing.Size(1271, 519);
            this.gridProds.TabIndex = 11;
            // 
            // btnTraerTodos
            // 
            this.btnTraerTodos.BackColor = System.Drawing.Color.Crimson;
            this.btnTraerTodos.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraerTodos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTraerTodos.Location = new System.Drawing.Point(12, 417);
            this.btnTraerTodos.Name = "btnTraerTodos";
            this.btnTraerTodos.Size = new System.Drawing.Size(152, 32);
            this.btnTraerTodos.TabIndex = 10;
            this.btnTraerTodos.Text = "Traer Productos (Todos)";
            this.btnTraerTodos.UseVisualStyleBackColor = false;
            this.btnTraerTodos.Click += new System.EventHandler(this.btnTraerTodos_Click);
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(12, 502);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(152, 24);
            this.cbSexo.TabIndex = 11;
            this.cbSexo.Text = "Filtrar sexo...";
            // 
            // btnTraerFilt
            // 
            this.btnTraerFilt.BackColor = System.Drawing.Color.Crimson;
            this.btnTraerFilt.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraerFilt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTraerFilt.Location = new System.Drawing.Point(12, 585);
            this.btnTraerFilt.Name = "btnTraerFilt";
            this.btnTraerFilt.Size = new System.Drawing.Size(152, 32);
            this.btnTraerFilt.TabIndex = 13;
            this.btnTraerFilt.Text = "Traer Filtrado";
            this.btnTraerFilt.UseVisualStyleBackColor = false;
            this.btnTraerFilt.Click += new System.EventHandler(this.btnTraerFilt_Click);
            // 
            // cbEstacion
            // 
            this.cbEstacion.FormattingEnabled = true;
            this.cbEstacion.Location = new System.Drawing.Point(12, 550);
            this.cbEstacion.Name = "cbEstacion";
            this.cbEstacion.Size = new System.Drawing.Size(152, 24);
            this.cbEstacion.TabIndex = 12;
            this.cbEstacion.Text = "Filtrar estacion...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(592, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 42);
            this.label1.TabIndex = 17;
            this.label1.Text = "PANEL ADMINISTRADOR";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1475, 81);
            this.panel1.TabIndex = 18;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = global::WindowsTienda.Properties.Resources.Logout__Custom_;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(1307, 12);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(141, 61);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Filtrar por sexo...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Filtrar por estación...";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1470, 668);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbEstacion);
            this.Controls.Add(this.btnTraerFilt);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.btnTraerTodos);
            this.Controls.Add(this.gridProds);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.txtPrecioEfectivo);
            this.Controls.Add(this.txtPrecioCosto);
            this.Controls.Add(this.txtTalle);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtEstacion);
            this.Controls.Add(this.txtCaracteristica);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtCodigoProducto);
            this.Name = "Producto";
            this.Text = "Guinea Indumentaria - Panel Administrador";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProds)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtCaracteristica;
        private System.Windows.Forms.TextBox txtEstacion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtTalle;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.TextBox txtPrecioEfectivo;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView gridProds;
        private System.Windows.Forms.Button btnTraerTodos;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Button btnTraerFilt;
        private System.Windows.Forms.ComboBox cbEstacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogout;
    }
}

