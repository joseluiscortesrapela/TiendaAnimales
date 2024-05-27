namespace Tienda.UserControls
{
    partial class UC_Ventas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Ventas));
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnMostrarBuscadorProductosModal = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTotalAPagar = new System.Windows.Forms.Label();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbMensajeGeneral = new System.Windows.Forms.Label();
            this.timerMensaje = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrarBuscadorProductosModal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVenta
            // 
            this.dgvVenta.AllowUserToAddRows = false;
            this.dgvVenta.AllowUserToDeleteRows = false;
            this.dgvVenta.AllowUserToResizeRows = false;
            this.dgvVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVenta.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvVenta.ColumnHeadersHeight = 35;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.Categoria,
            this.Cantidad,
            this.Precio,
            this.iva,
            this.Descuento,
            this.Subtotal,
            this.Total});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVenta.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvVenta.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvVenta.Location = new System.Drawing.Point(31, 153);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.ReadOnly = true;
            this.dgvVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvVenta.RowHeadersVisible = false;
            this.dgvVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVenta.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenta.ShowCellErrors = false;
            this.dgvVenta.ShowCellToolTips = false;
            this.dgvVenta.ShowEditingIcon = false;
            this.dgvVenta.ShowRowErrors = false;
            this.dgvVenta.Size = new System.Drawing.Size(1258, 404);
            this.dgvVenta.TabIndex = 10;
            this.dgvVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenta_CellClick);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "Id";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.FillWeight = 593.4009F;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cantidad.FillWeight = 17.76652F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 106;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Precio.FillWeight = 17.76652F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 84;
            // 
            // iva
            // 
            this.iva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iva.FillWeight = 17.76652F;
            this.iva.HeaderText = "IVA";
            this.iva.Name = "iva";
            this.iva.ReadOnly = true;
            this.iva.Width = 64;
            // 
            // Descuento
            // 
            this.Descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Descuento.FillWeight = 17.76652F;
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            this.Descuento.Width = 121;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Subtotal.FillWeight = 17.76652F;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 102;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cliente";
            // 
            // cbClientes
            // 
            this.cbClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbClientes.BackColor = System.Drawing.Color.Snow;
            this.cbClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClientes.ForeColor = System.Drawing.Color.SlateGray;
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(97, 66);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(280, 28);
            this.cbClientes.TabIndex = 13;
            this.cbClientes.SelectedIndexChanged += new System.EventHandler(this.cbClientes_SelectedIndexChanged);
            this.cbClientes.TextChanged += new System.EventHandler(this.cbClientes_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(1093, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Agregar un producto";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.CustomFormat = "\"yyyy-MM-dd \"";
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(1174, 70);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(115, 26);
            this.dtpFecha.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1170, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fecha de venta";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbTitulo.Location = new System.Drawing.Point(25, 19);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(101, 31);
            this.lbTitulo.TabIndex = 20;
            this.lbTitulo.Text = "Vender";
            // 
            // btnMostrarBuscadorProductosModal
            // 
            this.btnMostrarBuscadorProductosModal.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarBuscadorProductosModal.Image")));
            this.btnMostrarBuscadorProductosModal.Location = new System.Drawing.Point(1254, 116);
            this.btnMostrarBuscadorProductosModal.Name = "btnMostrarBuscadorProductosModal";
            this.btnMostrarBuscadorProductosModal.Size = new System.Drawing.Size(36, 36);
            this.btnMostrarBuscadorProductosModal.TabIndex = 21;
            this.btnMostrarBuscadorProductosModal.TabStop = false;
            this.btnMostrarBuscadorProductosModal.Click += new System.EventHandler(this.btnMostrarBuscadorProductosModal_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1140, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 32);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1300, 3);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(21, 21);
            this.pbExit.TabIndex = 22;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(1080, 653);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Violet;
            this.label7.Location = new System.Drawing.Point(1080, 618);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Subtotal";
            // 
            // lbTotalAPagar
            // 
            this.lbTotalAPagar.AutoSize = true;
            this.lbTotalAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAPagar.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbTotalAPagar.Location = new System.Drawing.Point(1228, 653);
            this.lbTotalAPagar.Name = "lbTotalAPagar";
            this.lbTotalAPagar.Size = new System.Drawing.Size(19, 20);
            this.lbTotalAPagar.TabIndex = 26;
            this.lbTotalAPagar.Text = "0";
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.AutoSize = true;
            this.lbSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtotal.ForeColor = System.Drawing.Color.Violet;
            this.lbSubtotal.Location = new System.Drawing.Point(1228, 618);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(18, 20);
            this.lbSubtotal.TabIndex = 27;
            this.lbSubtotal.Text = "0";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(1290, 172);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(36, 36);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptar.Location = new System.Drawing.Point(570, 653);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(192, 35);
            this.btnAceptar.TabIndex = 37;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lbMensajeGeneral
            // 
            this.lbMensajeGeneral.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbMensajeGeneral.AutoSize = true;
            this.lbMensajeGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensajeGeneral.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbMensajeGeneral.Location = new System.Drawing.Point(500, 580);
            this.lbMensajeGeneral.Name = "lbMensajeGeneral";
            this.lbMensajeGeneral.Size = new System.Drawing.Size(0, 24);
            this.lbMensajeGeneral.TabIndex = 38;
            // 
            // timerMensaje
            // 
            this.timerMensaje.Interval = 5000;
            this.timerMensaje.Tick += new System.EventHandler(this.timerMensaje_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SlateGray;
            this.label4.Location = new System.Drawing.Point(27, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Lista de productos añadidos";
            // 
            // UC_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbMensajeGeneral);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lbSubtotal);
            this.Controls.Add(this.lbTotalAPagar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.btnMostrarBuscadorProductosModal);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvVenta);
            this.Name = "UC_Ventas";
            this.Size = new System.Drawing.Size(1324, 704);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrarBuscadorProductosModal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox btnMostrarBuscadorProductosModal;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label lbTotalAPagar;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.PictureBox btnEliminar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lbMensajeGeneral;
        private System.Windows.Forms.Timer timerMensaje;
        private System.Windows.Forms.Label label4;
    }
}
