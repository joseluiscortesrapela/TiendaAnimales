namespace Tienda.Forms
{
    partial class BuscadorProductosModal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscadorProductosModal));
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.pbBuscador = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panelBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscador)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(29, 132);
            this.dgvProductos.Name = "dgvProductos";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.Size = new System.Drawing.Size(739, 268);
            this.dgvProductos.TabIndex = 39;
            // 
            // panelBuscador
            // 
            this.panelBuscador.BackColor = System.Drawing.Color.Transparent;
            this.panelBuscador.Controls.Add(this.tbBuscar);
            this.panelBuscador.Controls.Add(this.pbBuscador);
            this.panelBuscador.Location = new System.Drawing.Point(196, 5);
            this.panelBuscador.Name = "panelBuscador";
            this.panelBuscador.Size = new System.Drawing.Size(431, 47);
            this.panelBuscador.TabIndex = 40;
            this.panelBuscador.Visible = false;
            // 
            // tbBuscar
            // 
            this.tbBuscar.BackColor = System.Drawing.Color.Snow;
            this.tbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbBuscar.Location = new System.Drawing.Point(76, 14);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(248, 19);
            this.tbBuscar.TabIndex = 3;
            this.tbBuscar.Text = "Buscar productos...";
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // pbBuscador
            // 
            this.pbBuscador.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscador.Image")));
            this.pbBuscador.Location = new System.Drawing.Point(10, 5);
            this.pbBuscador.Margin = new System.Windows.Forms.Padding(0);
            this.pbBuscador.Name = "pbBuscador";
            this.pbBuscador.Size = new System.Drawing.Size(409, 39);
            this.pbBuscador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBuscador.TabIndex = 2;
            this.pbBuscador.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label21.Location = new System.Drawing.Point(25, 62);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 20);
            this.label21.TabIndex = 134;
            this.label21.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.AliceBlue;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbNombre.Location = new System.Drawing.Point(29, 84);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(406, 26);
            this.tbNombre.TabIndex = 132;
            this.tbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(693, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 130;
            this.label5.Text = "Stock";
            // 
            // tbStock
            // 
            this.tbStock.BackColor = System.Drawing.Color.AliceBlue;
            this.tbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStock.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbStock.Location = new System.Drawing.Point(692, 84);
            this.tbStock.Name = "tbStock";
            this.tbStock.ReadOnly = true;
            this.tbStock.Size = new System.Drawing.Size(76, 26);
            this.tbStock.TabIndex = 128;
            this.tbStock.Text = "0";
            this.tbStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label41.Location = new System.Drawing.Point(587, 61);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(59, 20);
            this.label41.TabIndex = 122;
            this.label41.Text = "Precio";
            // 
            // tbPrecio
            // 
            this.tbPrecio.BackColor = System.Drawing.Color.AliceBlue;
            this.tbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecio.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbPrecio.Location = new System.Drawing.Point(582, 84);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(76, 26);
            this.tbPrecio.TabIndex = 120;
            this.tbPrecio.Text = "0";
            this.tbPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(471, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 137;
            this.label1.Text = "Cantidad";
            // 
            // tbCantidad
            // 
            this.tbCantidad.BackColor = System.Drawing.Color.AliceBlue;
            this.tbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbCantidad.Location = new System.Drawing.Point(475, 84);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(76, 26);
            this.tbCantidad.TabIndex = 135;
            this.tbCantidad.Text = "0";
            this.tbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BuscadorProductosModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(799, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.panelBuscador);
            this.Controls.Add(this.dgvProductos);
            this.Name = "BuscadorProductosModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscadorProductosModal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.PictureBox pbBuscador;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCantidad;
    }
}