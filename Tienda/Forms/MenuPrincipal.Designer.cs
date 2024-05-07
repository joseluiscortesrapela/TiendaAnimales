namespace Tienda.Forms
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.paneLaterallNavegacion = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnAdministradores = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnMisVentas = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbTipoUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.paneLaterallNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // paneLaterallNavegacion
            // 
            this.paneLaterallNavegacion.BackColor = System.Drawing.Color.AliceBlue;
            this.paneLaterallNavegacion.Controls.Add(this.btnHome);
            this.paneLaterallNavegacion.Controls.Add(this.btnAdministradores);
            this.paneLaterallNavegacion.Controls.Add(this.btnEmpleados);
            this.paneLaterallNavegacion.Controls.Add(this.btnClientes);
            this.paneLaterallNavegacion.Controls.Add(this.btnInventario);
            this.paneLaterallNavegacion.Controls.Add(this.btnVentas);
            this.paneLaterallNavegacion.Controls.Add(this.btnMisVentas);
            this.paneLaterallNavegacion.Controls.Add(this.btnInformes);
            this.paneLaterallNavegacion.Controls.Add(this.btnCerrarSesion);
            this.paneLaterallNavegacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneLaterallNavegacion.Location = new System.Drawing.Point(0, 0);
            this.paneLaterallNavegacion.Name = "paneLaterallNavegacion";
            this.paneLaterallNavegacion.Size = new System.Drawing.Size(49, 704);
            this.paneLaterallNavegacion.TabIndex = 3;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 3, 3, 70);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(46, 59);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 7;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAdministradores
            // 
            this.btnAdministradores.FlatAppearance.BorderSize = 0;
            this.btnAdministradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministradores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministradores.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdministradores.Image = ((System.Drawing.Image)(resources.GetObject("btnAdministradores.Image")));
            this.btnAdministradores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministradores.Location = new System.Drawing.Point(3, 135);
            this.btnAdministradores.Name = "btnAdministradores";
            this.btnAdministradores.Size = new System.Drawing.Size(46, 45);
            this.btnAdministradores.TabIndex = 18;
            this.btnAdministradores.Tag = "Administradores";
            this.btnAdministradores.UseVisualStyleBackColor = true;
            this.btnAdministradores.Visible = false;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(3, 186);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(46, 45);
            this.btnEmpleados.TabIndex = 17;
            this.btnEmpleados.Tag = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Visible = false;
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(3, 237);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(46, 45);
            this.btnClientes.TabIndex = 14;
            this.btnClientes.Tag = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Visible = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            this.btnClientes.MouseHover += new System.EventHandler(this.btnClientes_MouseHover);
            // 
            // btnInventario
            // 
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.Image")));
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(3, 288);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(46, 45);
            this.btnInventario.TabIndex = 12;
            this.btnInventario.Tag = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Visible = false;
            this.btnInventario.Click += new System.EventHandler(this.btnProductos_Click);
            this.btnInventario.MouseHover += new System.EventHandler(this.btnInventario_MouseHover);
            // 
            // btnVentas
            // 
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(3, 339);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(46, 45);
            this.btnVentas.TabIndex = 16;
            this.btnVentas.Tag = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Visible = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            this.btnVentas.MouseHover += new System.EventHandler(this.btnVentas_MouseHover);
            // 
            // btnMisVentas
            // 
            this.btnMisVentas.FlatAppearance.BorderSize = 0;
            this.btnMisVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisVentas.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnMisVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnMisVentas.Image")));
            this.btnMisVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisVentas.Location = new System.Drawing.Point(3, 390);
            this.btnMisVentas.Name = "btnMisVentas";
            this.btnMisVentas.Size = new System.Drawing.Size(46, 45);
            this.btnMisVentas.TabIndex = 17;
            this.btnMisVentas.Tag = "Mis ventas";
            this.btnMisVentas.UseVisualStyleBackColor = true;
            this.btnMisVentas.Visible = false;
            // 
            // btnInformes
            // 
            this.btnInformes.FlatAppearance.BorderSize = 0;
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnInformes.Image = ((System.Drawing.Image)(resources.GetObject("btnInformes.Image")));
            this.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Location = new System.Drawing.Point(3, 441);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(46, 45);
            this.btnInformes.TabIndex = 15;
            this.btnInformes.Tag = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Visible = false;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            this.btnInformes.MouseHover += new System.EventHandler(this.btnInformes_MouseHover);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(3, 609);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 120, 3, 20);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(36, 52);
            this.btnCerrarSesion.TabIndex = 15;
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Controls.Add(this.lbTipoUsuario);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.lbUsuario);
            this.panelLogo.Location = new System.Drawing.Point(1077, 4);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(208, 61);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // lbTipoUsuario
            // 
            this.lbTipoUsuario.AutoSize = true;
            this.lbTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoUsuario.ForeColor = System.Drawing.Color.Orange;
            this.lbTipoUsuario.Location = new System.Drawing.Point(64, 46);
            this.lbTipoUsuario.Name = "lbTipoUsuario";
            this.lbTipoUsuario.Size = new System.Drawing.Size(34, 13);
            this.lbTipoUsuario.TabIndex = 10;
            this.lbTipoUsuario.Text = "Tipo: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(61, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bienvenido/a";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbUsuario.Location = new System.Drawing.Point(63, 29);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(57, 17);
            this.lbUsuario.TabIndex = 8;
            this.lbUsuario.Text = "Usuario";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Snow;
            this.panelContenedor.Controls.Add(this.pbExit);
            this.panelContenedor.Controls.Add(this.panelLogo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(49, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1324, 704);
            this.panelContenedor.TabIndex = 5;
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1291, 4);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(21, 21);
            this.pbExit.TabIndex = 6;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click_1);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1373, 704);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.paneLaterallNavegacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdministrador";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.paneLaterallNavegacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel paneLaterallNavegacion;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnMisVentas;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Label lbTipoUsuario;
        private System.Windows.Forms.Button btnAdministradores;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}