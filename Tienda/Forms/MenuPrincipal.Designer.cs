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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdministradores = new System.Windows.Forms.Button();
            this.btnAgentes = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnPolizas = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnMisClientes = new System.Windows.Forms.Button();
            this.btnMisPolizas = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.paneLaterallNavegacion.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // paneLaterallNavegacion
            // 
            this.paneLaterallNavegacion.BackColor = System.Drawing.SystemColors.ControlText;
            this.paneLaterallNavegacion.Controls.Add(this.panelLogo);
            this.paneLaterallNavegacion.Controls.Add(this.btnAdministradores);
            this.paneLaterallNavegacion.Controls.Add(this.btnAgentes);
            this.paneLaterallNavegacion.Controls.Add(this.btnClientes);
            this.paneLaterallNavegacion.Controls.Add(this.btnPolizas);
            this.paneLaterallNavegacion.Controls.Add(this.btnInformes);
            this.paneLaterallNavegacion.Controls.Add(this.btnMisClientes);
            this.paneLaterallNavegacion.Controls.Add(this.btnMisPolizas);
            this.paneLaterallNavegacion.Controls.Add(this.btnCerrarSesion);
            this.paneLaterallNavegacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneLaterallNavegacion.Location = new System.Drawing.Point(0, 0);
            this.paneLaterallNavegacion.Name = "paneLaterallNavegacion";
            this.paneLaterallNavegacion.Size = new System.Drawing.Size(246, 704);
            this.paneLaterallNavegacion.TabIndex = 3;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.lbUsuario);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.lbTipo);
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(239, 113);
            this.panelLogo.TabIndex = 0;
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
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.ForeColor = System.Drawing.Color.Orange;
            this.lbTipo.Location = new System.Drawing.Point(71, 6);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(34, 13);
            this.lbTipo.TabIndex = 10;
            this.lbTipo.Text = "Tipo: ";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Snow;
            this.panelContenedor.Controls.Add(this.pbExit);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(246, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1127, 704);
            this.panelContenedor.TabIndex = 5;
            // 
            // pbExit
            // 
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1103, 3);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(21, 21);
            this.pbExit.TabIndex = 6;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 70);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdministradores
            // 
            this.btnAdministradores.FlatAppearance.BorderSize = 0;
            this.btnAdministradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministradores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministradores.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdministradores.Image = ((System.Drawing.Image)(resources.GetObject("btnAdministradores.Image")));
            this.btnAdministradores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministradores.Location = new System.Drawing.Point(3, 149);
            this.btnAdministradores.Name = "btnAdministradores";
            this.btnAdministradores.Size = new System.Drawing.Size(239, 45);
            this.btnAdministradores.TabIndex = 12;
            this.btnAdministradores.Text = "Administradores";
            this.btnAdministradores.UseVisualStyleBackColor = true;
            this.btnAdministradores.Visible = false;
            this.btnAdministradores.Click += new System.EventHandler(this.btnAdministradores_Click);
            // 
            // btnAgentes
            // 
            this.btnAgentes.FlatAppearance.BorderSize = 0;
            this.btnAgentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgentes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnAgentes.Image = ((System.Drawing.Image)(resources.GetObject("btnAgentes.Image")));
            this.btnAgentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgentes.Location = new System.Drawing.Point(3, 200);
            this.btnAgentes.Name = "btnAgentes";
            this.btnAgentes.Size = new System.Drawing.Size(239, 45);
            this.btnAgentes.TabIndex = 13;
            this.btnAgentes.Text = "Agentes";
            this.btnAgentes.UseVisualStyleBackColor = true;
            this.btnAgentes.Visible = false;
            this.btnAgentes.Click += new System.EventHandler(this.btnAgentes_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(3, 251);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(239, 45);
            this.btnClientes.TabIndex = 14;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Visible = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnPolizas
            // 
            this.btnPolizas.FlatAppearance.BorderSize = 0;
            this.btnPolizas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPolizas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolizas.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnPolizas.Image = ((System.Drawing.Image)(resources.GetObject("btnPolizas.Image")));
            this.btnPolizas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPolizas.Location = new System.Drawing.Point(3, 302);
            this.btnPolizas.Name = "btnPolizas";
            this.btnPolizas.Size = new System.Drawing.Size(239, 45);
            this.btnPolizas.TabIndex = 16;
            this.btnPolizas.Text = "Polizas";
            this.btnPolizas.UseVisualStyleBackColor = true;
            this.btnPolizas.Visible = false;
            this.btnPolizas.Click += new System.EventHandler(this.btnPolizas_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.FlatAppearance.BorderSize = 0;
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnInformes.Image = ((System.Drawing.Image)(resources.GetObject("btnInformes.Image")));
            this.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Location = new System.Drawing.Point(3, 353);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(239, 45);
            this.btnInformes.TabIndex = 15;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Visible = false;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnMisClientes
            // 
            this.btnMisClientes.FlatAppearance.BorderSize = 0;
            this.btnMisClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisClientes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnMisClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnMisClientes.Image")));
            this.btnMisClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisClientes.Location = new System.Drawing.Point(3, 404);
            this.btnMisClientes.Name = "btnMisClientes";
            this.btnMisClientes.Size = new System.Drawing.Size(239, 45);
            this.btnMisClientes.TabIndex = 18;
            this.btnMisClientes.Text = "Mis clientes";
            this.btnMisClientes.UseVisualStyleBackColor = true;
            this.btnMisClientes.Visible = false;
            this.btnMisClientes.Click += new System.EventHandler(this.btnMisClientes_Click);
            // 
            // btnMisPolizas
            // 
            this.btnMisPolizas.FlatAppearance.BorderSize = 0;
            this.btnMisPolizas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisPolizas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisPolizas.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnMisPolizas.Image = ((System.Drawing.Image)(resources.GetObject("btnMisPolizas.Image")));
            this.btnMisPolizas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisPolizas.Location = new System.Drawing.Point(3, 455);
            this.btnMisPolizas.Name = "btnMisPolizas";
            this.btnMisPolizas.Size = new System.Drawing.Size(239, 45);
            this.btnMisPolizas.TabIndex = 17;
            this.btnMisPolizas.Text = "Mis polizas";
            this.btnMisPolizas.UseVisualStyleBackColor = true;
            this.btnMisPolizas.Visible = false;
            this.btnMisPolizas.Click += new System.EventHandler(this.btnMisPolizas_Click);
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
            this.btnCerrarSesion.Location = new System.Drawing.Point(3, 673);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 170, 3, 20);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(239, 82);
            this.btnCerrarSesion.TabIndex = 15;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
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
            this.Load += new System.EventHandler(this.MenuAdministrador_Load);
            this.paneLaterallNavegacion.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel paneLaterallNavegacion;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Button btnAdministradores;
        private System.Windows.Forms.Button btnAgentes;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnPolizas;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnMisClientes;
        private System.Windows.Forms.Button btnMisPolizas;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Button btnInformes;
    }
}