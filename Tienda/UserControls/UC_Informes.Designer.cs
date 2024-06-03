namespace Tienda.UserControls
{
    partial class UC_Informes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Informes));
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label39 = new System.Windows.Forms.Label();
            this.dtpFechaDetalle = new System.Windows.Forms.DateTimePicker();
            this.label46 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.idCliente2 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.idCliente1 = new System.Windows.Forms.NumericUpDown();
            this.btnGenerarInformeClientes = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cbEstadosInforme = new System.Windows.Forms.ComboBox();
            this.reportViewerGeneral = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGenerarInformeProductos = new System.Windows.Forms.Button();
            this.pbExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCliente2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCliente1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(328, 135);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(32, 32);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox11.TabIndex = 136;
            this.pictureBox11.TabStop = false;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label39.Location = new System.Drawing.Point(324, 112);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(182, 20);
            this.label39.TabIndex = 135;
            this.label39.Text = "desde fecha de venta";
            // 
            // dtpFechaDetalle
            // 
            this.dtpFechaDetalle.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtpFechaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDetalle.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDetalle.Location = new System.Drawing.Point(367, 135);
            this.dtpFechaDetalle.Name = "dtpFechaDetalle";
            this.dtpFechaDetalle.Size = new System.Drawing.Size(139, 27);
            this.dtpFechaDetalle.TabIndex = 134;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.SteelBlue;
            this.label46.Location = new System.Drawing.Point(22, 15);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(149, 39);
            this.label46.TabIndex = 132;
            this.label46.Text = "Informes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(565, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.TabIndex = 139;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(561, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 138;
            this.label1.Text = "hasta fecha de venta";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtpFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(604, 136);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(135, 27);
            this.dtpFechaHasta.TabIndex = 137;
            // 
            // idCliente2
            // 
            this.idCliente2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.idCliente2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCliente2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.idCliente2.Location = new System.Drawing.Point(834, 135);
            this.idCliente2.Name = "idCliente2";
            this.idCliente2.Size = new System.Drawing.Size(103, 26);
            this.idCliente2.TabIndex = 140;
            this.idCliente2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(803, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 26);
            this.pictureBox2.TabIndex = 141;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(799, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 142;
            this.label2.Text = "Desde id cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(115, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 145;
            this.label3.Text = "Desde id cliente";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(119, 138);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 26);
            this.pictureBox3.TabIndex = 144;
            this.pictureBox3.TabStop = false;
            // 
            // idCliente1
            // 
            this.idCliente1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.idCliente1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCliente1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.idCliente1.Location = new System.Drawing.Point(147, 138);
            this.idCliente1.Name = "idCliente1";
            this.idCliente1.Size = new System.Drawing.Size(106, 26);
            this.idCliente1.TabIndex = 143;
            this.idCliente1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idCliente1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGenerarInformeClientes
            // 
            this.btnGenerarInformeClientes.BackColor = System.Drawing.Color.DimGray;
            this.btnGenerarInformeClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarInformeClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarInformeClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerarInformeClientes.Location = new System.Drawing.Point(690, 630);
            this.btnGenerarInformeClientes.Name = "btnGenerarInformeClientes";
            this.btnGenerarInformeClientes.Size = new System.Drawing.Size(287, 35);
            this.btnGenerarInformeClientes.TabIndex = 148;
            this.btnGenerarInformeClientes.Text = "Generar informe clientes";
            this.btnGenerarInformeClientes.UseVisualStyleBackColor = false;
            this.btnGenerarInformeClientes.Click += new System.EventHandler(this.btnGenerarInformeClientes_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(1008, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 151;
            this.label5.Text = "Estados";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1012, 132);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 32);
            this.pictureBox4.TabIndex = 150;
            this.pictureBox4.TabStop = false;
            // 
            // cbEstadosInforme
            // 
            this.cbEstadosInforme.BackColor = System.Drawing.Color.CadetBlue;
            this.cbEstadosInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadosInforme.ForeColor = System.Drawing.SystemColors.Info;
            this.cbEstadosInforme.FormattingEnabled = true;
            this.cbEstadosInforme.Location = new System.Drawing.Point(1049, 135);
            this.cbEstadosInforme.Name = "cbEstadosInforme";
            this.cbEstadosInforme.Size = new System.Drawing.Size(155, 28);
            this.cbEstadosInforme.TabIndex = 149;
            this.cbEstadosInforme.Text = "Todas";
            // 
            // reportViewerGeneral
            // 
            this.reportViewerGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportViewerGeneral.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewerGeneral.DocumentMapWidth = 1;
            this.reportViewerGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportViewerGeneral.ForeColor = System.Drawing.Color.RoyalBlue;
            this.reportViewerGeneral.LocalReport.ReportEmbeddedResource = "Tienda.ReportIProductos.rdlc";
            this.reportViewerGeneral.Location = new System.Drawing.Point(19, 193);
            this.reportViewerGeneral.Name = "reportViewerGeneral";
            this.reportViewerGeneral.ServerReport.BearerToken = null;
            this.reportViewerGeneral.Size = new System.Drawing.Size(1289, 411);
            this.reportViewerGeneral.TabIndex = 152;
            // 
            // btnGenerarInformeProductos
            // 
            this.btnGenerarInformeProductos.BackColor = System.Drawing.Color.DimGray;
            this.btnGenerarInformeProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarInformeProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarInformeProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerarInformeProductos.Location = new System.Drawing.Point(304, 630);
            this.btnGenerarInformeProductos.Name = "btnGenerarInformeProductos";
            this.btnGenerarInformeProductos.Size = new System.Drawing.Size(287, 35);
            this.btnGenerarInformeProductos.TabIndex = 153;
            this.btnGenerarInformeProductos.Text = "Generar informe productos";
            this.btnGenerarInformeProductos.UseVisualStyleBackColor = false;
            this.btnGenerarInformeProductos.Click += new System.EventHandler(this.btnGenerarInformeProductos_Click);
            // 
            // pbExit
            // 
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1300, 3);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(21, 21);
            this.pbExit.TabIndex = 154;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click_1);
            // 
            // UC_Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.btnGenerarInformeProductos);
            this.Controls.Add(this.reportViewerGeneral);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.cbEstadosInforme);
            this.Controls.Add(this.btnGenerarInformeClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.idCliente1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.idCliente2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.dtpFechaDetalle);
            this.Name = "UC_Informes";
            this.Size = new System.Drawing.Size(1324, 704);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCliente2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCliente1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.DateTimePicker dtpFechaDetalle;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.NumericUpDown idCliente2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NumericUpDown idCliente1;
        private System.Windows.Forms.Button btnGenerarInformeClientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox cbEstadosInforme;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerGeneral;
        private System.Windows.Forms.Button btnGenerarInformeProductos;
        private System.Windows.Forms.PictureBox pbExit;
    }
}
