namespace Tienda.UserControls
{
    partial class UC_CrudVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CrudVentas));
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.pbCrear = new System.Windows.Forms.PictureBox();
            this.pbEliminar = new System.Windows.Forms.PictureBox();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.panelFlSuperior = new System.Windows.Forms.FlowLayoutPanel();
            this.panelNavegacionSuperior = new System.Windows.Forms.Panel();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbInicio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            this.panelFlSuperior.SuspendLayout();
            this.panelNavegacionSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AllowUserToOrderColumns = true;
            this.dgvVentas.AllowUserToResizeColumns = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(34, 122);
            this.dgvVentas.Name = "dgvVentas";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.Size = new System.Drawing.Size(1046, 339);
            this.dgvVentas.TabIndex = 2;
            // 
            // pbCrear
            // 
            this.pbCrear.Image = ((System.Drawing.Image)(resources.GetObject("pbCrear.Image")));
            this.pbCrear.Location = new System.Drawing.Point(1085, 150);
            this.pbCrear.Name = "pbCrear";
            this.pbCrear.Size = new System.Drawing.Size(35, 35);
            this.pbCrear.TabIndex = 3;
            this.pbCrear.TabStop = false;
            this.pbCrear.Click += new System.EventHandler(this.pbCrear_Click);
            // 
            // pbEliminar
            // 
            this.pbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("pbEliminar.Image")));
            this.pbEliminar.Location = new System.Drawing.Point(1086, 235);
            this.pbEliminar.Name = "pbEliminar";
            this.pbEliminar.Size = new System.Drawing.Size(34, 36);
            this.pbEliminar.TabIndex = 4;
            this.pbEliminar.TabStop = false;
            this.pbEliminar.Click += new System.EventHandler(this.pbEliminar_Click);
            // 
            // pbEditar
            // 
            this.pbEditar.Image = ((System.Drawing.Image)(resources.GetObject("pbEditar.Image")));
            this.pbEditar.Location = new System.Drawing.Point(1086, 191);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(34, 38);
            this.pbEditar.TabIndex = 5;
            this.pbEditar.TabStop = false;
            this.pbEditar.Click += new System.EventHandler(this.pbEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(28, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ventas";
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.Location = new System.Drawing.Point(526, 631);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(0, 17);
            this.lbMensaje.TabIndex = 7;
            // 
            // panelFlSuperior
            // 
            this.panelFlSuperior.BackColor = System.Drawing.Color.Snow;
            this.panelFlSuperior.Controls.Add(this.panelNavegacionSuperior);
            this.panelFlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFlSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelFlSuperior.Name = "panelFlSuperior";
            this.panelFlSuperior.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelFlSuperior.Size = new System.Drawing.Size(1127, 55);
            this.panelFlSuperior.TabIndex = 8;
            // 
            // panelNavegacionSuperior
            // 
            this.panelNavegacionSuperior.BackColor = System.Drawing.Color.Snow;
            this.panelNavegacionSuperior.Controls.Add(this.pbExit);
            this.panelNavegacionSuperior.Controls.Add(this.pbInicio);
            this.panelNavegacionSuperior.Location = new System.Drawing.Point(13, 3);
            this.panelNavegacionSuperior.Name = "panelNavegacionSuperior";
            this.panelNavegacionSuperior.Size = new System.Drawing.Size(1114, 52);
            this.panelNavegacionSuperior.TabIndex = 5;
            // 
            // pbExit
            // 
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1090, 3);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(21, 21);
            this.pbExit.TabIndex = 7;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // pbInicio
            // 
            this.pbInicio.Image = global::Tienda.Properties.Resources.inicio;
            this.pbInicio.Location = new System.Drawing.Point(19, 15);
            this.pbInicio.Margin = new System.Windows.Forms.Padding(3, 3, 400, 3);
            this.pbInicio.Name = "pbInicio";
            this.pbInicio.Size = new System.Drawing.Size(41, 36);
            this.pbInicio.TabIndex = 1;
            this.pbInicio.TabStop = false;
            // 
            // UC_CrudVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.panelFlSuperior);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.pbEliminar);
            this.Controls.Add(this.pbCrear);
            this.Controls.Add(this.dgvVentas);
            this.Name = "UC_CrudVentas";
            this.Size = new System.Drawing.Size(1127, 732);
            this.Load += new System.EventHandler(this.UC_CrudAdministradores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            this.panelFlSuperior.ResumeLayout(false);
            this.panelNavegacionSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.PictureBox pbCrear;
        private System.Windows.Forms.PictureBox pbEliminar;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.FlowLayoutPanel panelFlSuperior;
        private System.Windows.Forms.Panel panelNavegacionSuperior;
        private System.Windows.Forms.PictureBox pbInicio;
        private System.Windows.Forms.PictureBox pbExit;
    }
}
