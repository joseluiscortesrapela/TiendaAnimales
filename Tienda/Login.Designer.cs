namespace Tienda
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelMensajeLogin = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(233, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 44;
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Uighur", 20F);
            this.buttonLogin.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonLogin.Location = new System.Drawing.Point(201, 343);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(125, 45);
            this.buttonLogin.TabIndex = 42;
            this.buttonLogin.Text = "Aceptar";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.login_Click);
            // 
            // labelMensajeLogin
            // 
            this.labelMensajeLogin.AutoSize = true;
            this.labelMensajeLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelMensajeLogin.Font = new System.Drawing.Font("Microsoft Uighur", 20F);
            this.labelMensajeLogin.ForeColor = System.Drawing.Color.Snow;
            this.labelMensajeLogin.Location = new System.Drawing.Point(172, 321);
            this.labelMensajeLogin.Name = "labelMensajeLogin";
            this.labelMensajeLogin.Size = new System.Drawing.Size(0, 36);
            this.labelMensajeLogin.TabIndex = 45;
            this.labelMensajeLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tbContraseña
            // 
            this.tbContraseña.BackColor = System.Drawing.Color.Coral;
            this.tbContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContraseña.Font = new System.Drawing.Font("Microsoft Uighur", 25F);
            this.tbContraseña.ForeColor = System.Drawing.SystemColors.Menu;
            this.tbContraseña.Location = new System.Drawing.Point(139, 269);
            this.tbContraseña.MaxLength = 12;
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(259, 37);
            this.tbContraseña.TabIndex = 38;
            this.tbContraseña.TabStop = false;
            this.tbContraseña.Text = "1234";
            this.tbContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbContraseña.UseSystemPasswordChar = true;
            // 
            // tbCorreo
            // 
            this.tbCorreo.BackColor = System.Drawing.Color.Coral;
            this.tbCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCorreo.Font = new System.Drawing.Font("Microsoft Uighur", 25F);
            this.tbCorreo.ForeColor = System.Drawing.Color.White;
            this.tbCorreo.Location = new System.Drawing.Point(139, 198);
            this.tbCorreo.MaxLength = 50;
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(259, 37);
            this.tbCorreo.TabIndex = 39;
            this.tbCorreo.TabStop = false;
            this.tbCorreo.Text = "admin@hotmail.es";
            this.tbCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(305, 12);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(30, 32);
            this.pbExit.TabIndex = 50;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click_1);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            this.error.Icon = ((System.Drawing.Icon)(resources.GetObject("error.Icon")));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 65F);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(224, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 113);
            this.label2.TabIndex = 51;
            this.label2.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 421);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.labelMensajeLogin);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelMensajeLogin;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label label2;
    }
}