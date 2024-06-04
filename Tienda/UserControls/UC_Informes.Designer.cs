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
            this.label46 = new System.Windows.Forms.Label();
            this.btnGenerarInformeClientes = new System.Windows.Forms.Button();
            this.reportViewerGeneral = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGenerarInformeProductos = new System.Windows.Forms.Button();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.btnGenerarInformeVentasDeTodosLosClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.Snow;
            this.label46.Location = new System.Drawing.Point(854, 12);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(280, 39);
            this.label46.TabIndex = 132;
            this.label46.Text = "Generar informes";
            // 
            // btnGenerarInformeClientes
            // 
            this.btnGenerarInformeClientes.BackColor = System.Drawing.Color.DarkViolet;
            this.btnGenerarInformeClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarInformeClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarInformeClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerarInformeClientes.Location = new System.Drawing.Point(573, 649);
            this.btnGenerarInformeClientes.Name = "btnGenerarInformeClientes";
            this.btnGenerarInformeClientes.Size = new System.Drawing.Size(222, 35);
            this.btnGenerarInformeClientes.TabIndex = 148;
            this.btnGenerarInformeClientes.Text = "Lista de clientes";
            this.btnGenerarInformeClientes.UseVisualStyleBackColor = false;
            this.btnGenerarInformeClientes.Click += new System.EventHandler(this.btnGenerarInformeClientes_Click);
            // 
            // reportViewerGeneral
            // 
            this.reportViewerGeneral.BackColor = System.Drawing.Color.Snow;
            this.reportViewerGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportViewerGeneral.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewerGeneral.DocumentMapWidth = 1;
            this.reportViewerGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportViewerGeneral.ForeColor = System.Drawing.Color.RoyalBlue;
            this.reportViewerGeneral.LocalReport.ReportEmbeddedResource = "Tienda.ReportVentas.rdlc";
            this.reportViewerGeneral.Location = new System.Drawing.Point(0, 92);
            this.reportViewerGeneral.Name = "reportViewerGeneral";
            this.reportViewerGeneral.ServerReport.BearerToken = null;
            this.reportViewerGeneral.Size = new System.Drawing.Size(1321, 494);
            this.reportViewerGeneral.TabIndex = 152;
            // 
            // btnGenerarInformeProductos
            // 
            this.btnGenerarInformeProductos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGenerarInformeProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarInformeProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarInformeProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerarInformeProductos.Location = new System.Drawing.Point(285, 649);
            this.btnGenerarInformeProductos.Name = "btnGenerarInformeProductos";
            this.btnGenerarInformeProductos.Size = new System.Drawing.Size(222, 35);
            this.btnGenerarInformeProductos.TabIndex = 153;
            this.btnGenerarInformeProductos.Text = "Lista de productos";
            this.btnGenerarInformeProductos.UseVisualStyleBackColor = false;
            this.btnGenerarInformeProductos.Click += new System.EventHandler(this.btnGenerarInformeProductos_Click);
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1300, 3);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(21, 21);
            this.pbExit.TabIndex = 154;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click_1);
            // 
            // btnGenerarInformeVentasDeTodosLosClientes
            // 
            this.btnGenerarInformeVentasDeTodosLosClientes.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGenerarInformeVentasDeTodosLosClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarInformeVentasDeTodosLosClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarInformeVentasDeTodosLosClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerarInformeVentasDeTodosLosClientes.Location = new System.Drawing.Point(861, 649);
            this.btnGenerarInformeVentasDeTodosLosClientes.Name = "btnGenerarInformeVentasDeTodosLosClientes";
            this.btnGenerarInformeVentasDeTodosLosClientes.Size = new System.Drawing.Size(222, 35);
            this.btnGenerarInformeVentasDeTodosLosClientes.TabIndex = 155;
            this.btnGenerarInformeVentasDeTodosLosClientes.Text = "Lista de ventas";
            this.btnGenerarInformeVentasDeTodosLosClientes.UseVisualStyleBackColor = false;
            this.btnGenerarInformeVentasDeTodosLosClientes.Click += new System.EventHandler(this.btnGenerarInformeVentasDeTodosLosClientes_Click);
            // 
            // UC_Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnGenerarInformeVentasDeTodosLosClientes);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.btnGenerarInformeProductos);
            this.Controls.Add(this.reportViewerGeneral);
            this.Controls.Add(this.btnGenerarInformeClientes);
            this.Controls.Add(this.label46);
            this.DoubleBuffered = true;
            this.Name = "UC_Informes";
            this.Size = new System.Drawing.Size(1324, 704);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Button btnGenerarInformeClientes;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerGeneral;
        private System.Windows.Forms.Button btnGenerarInformeProductos;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Button btnGenerarInformeVentasDeTodosLosClientes;
    }
}
