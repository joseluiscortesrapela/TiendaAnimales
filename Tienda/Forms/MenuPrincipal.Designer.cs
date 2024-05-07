﻿namespace Tienda.Forms
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTipoUsuario = new System.Windows.Forms.Label();
            this.btnAdministradores = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnMisVentas = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.paneLaterallNavegacion.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // paneLaterallNavegacion
            // 
            this.paneLaterallNavegacion.BackColor = System.Drawing.SystemColors.ControlText;
            this.paneLaterallNavegacion.Controls.Add(this.pictureBox1);
            this.paneLaterallNavegacion.Controls.Add(this.panelLogo);
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
            this.paneLaterallNavegacion.Size = new System.Drawing.Size(45, 704);
            this.paneLaterallNavegacion.TabIndex = 3;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lbUsuario);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.lbTipoUsuario);
            this.panelLogo.Location = new System.Drawing.Point(3, 50);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(239, 113);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbUsuario.Location = new System.Drawing.Point(67, 50);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(79, 25);
            this.lbUsuario.TabIndex = 8;
            this.lbUsuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(65, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bienvenido/a";
            // 
            // lbTipoUsuario
            // 
            this.lbTipoUsuario.AutoSize = true;
            this.lbTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoUsuario.ForeColor = System.Drawing.Color.Orange;
            this.lbTipoUsuario.Location = new System.Drawing.Point(71, 6);
            this.lbTipoUsuario.Name = "lbTipoUsuario";
            this.lbTipoUsuario.Size = new System.Drawing.Size(34, 13);
            this.lbTipoUsuario.TabIndex = 10;
            this.lbTipoUsuario.Text = "Tipo: ";
            // 
            // btnAdministradores
            // 
            this.btnAdministradores.FlatAppearance.BorderSize = 0;
            this.btnAdministradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministradores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministradores.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdministradores.Image = ((System.Drawing.Image)(resources.GetObject("btnAdministradores.Image")));
            this.btnAdministradores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministradores.Location = new System.Drawing.Point(3, 196);
            this.btnAdministradores.Name = "btnAdministradores";
            this.btnAdministradores.Size = new System.Drawing.Size(239, 45);
            this.btnAdministradores.TabIndex = 18;
            this.btnAdministradores.Text = "Administradores";
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
            this.btnEmpleados.Location = new System.Drawing.Point(3, 247);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(239, 45);
            this.btnEmpleados.TabIndex = 17;
            this.btnEmpleados.Text = "Empleados";
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
            this.btnClientes.Location = new System.Drawing.Point(3, 298);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(239, 45);
            this.btnClientes.TabIndex = 14;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Visible = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.Image")));
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(3, 349);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(239, 45);
            this.btnInventario.TabIndex = 12;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Visible = false;
            this.btnInventario.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(3, 400);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(239, 45);
            this.btnVentas.TabIndex = 16;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Visible = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnMisVentas
            // 
            this.btnMisVentas.FlatAppearance.BorderSize = 0;
            this.btnMisVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisVentas.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnMisVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnMisVentas.Image")));
            this.btnMisVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisVentas.Location = new System.Drawing.Point(3, 451);
            this.btnMisVentas.Name = "btnMisVentas";
            this.btnMisVentas.Size = new System.Drawing.Size(239, 45);
            this.btnMisVentas.TabIndex = 17;
            this.btnMisVentas.Text = "Mis ventas";
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
            this.btnInformes.Location = new System.Drawing.Point(3, 502);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(239, 45);
            this.btnInformes.TabIndex = 15;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Visible = false;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(3, 670);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 120, 3, 20);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(239, 82);
            this.btnCerrarSesion.TabIndex = 15;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Snow;
            this.panelContenedor.Controls.Add(this.pbExit);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(45, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1328, 704);
            this.panelContenedor.TabIndex = 5;
            // 
            // pbExit
            // 
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1151, 3);
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
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel paneLaterallNavegacion;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
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
    }
}