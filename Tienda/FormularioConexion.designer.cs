using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda
{
    partial class FormularioConexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioConexion));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbDatabase = new System.Windows.Forms.TextBox();
            this.lbMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-14, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(860, 465);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 35F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(172, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(537, 59);
            this.label5.TabIndex = 20;
            this.label5.Text = "Conexion base datos";
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Showcard Gothic", 20F);
            this.btnConectar.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnConectar.Location = new System.Drawing.Point(334, 367);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(187, 53);
            this.btnConectar.TabIndex = 19;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(276, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(95, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(625, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(470, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Usuario";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(811, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 31);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.cerrar);
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUser.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold);
            this.tbUser.ForeColor = System.Drawing.Color.Lime;
            this.tbUser.Location = new System.Drawing.Point(450, 220);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(134, 28);
            this.tbUser.TabIndex = 22;
            this.tbUser.Text = "root";
            this.tbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold);
            this.tbPassword.ForeColor = System.Drawing.Color.Lime;
            this.tbPassword.Location = new System.Drawing.Point(630, 220);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(134, 28);
            this.tbPassword.TabIndex = 23;
            this.tbPassword.Text = "1234";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbServer
            // 
            this.tbServer.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbServer.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold);
            this.tbServer.ForeColor = System.Drawing.Color.Lime;
            this.tbServer.Location = new System.Drawing.Point(87, 220);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(134, 28);
            this.tbServer.TabIndex = 24;
            this.tbServer.Text = "localhost";
            this.tbServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDatabase
            // 
            this.tbDatabase.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbDatabase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDatabase.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold);
            this.tbDatabase.ForeColor = System.Drawing.Color.Lime;
            this.tbDatabase.Location = new System.Drawing.Point(266, 218);
            this.tbDatabase.Name = "tbDatabase";
            this.tbDatabase.Size = new System.Drawing.Size(134, 28);
            this.tbDatabase.TabIndex = 25;
            this.tbDatabase.Text = "Tienda";
            this.tbDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.ForeColor = System.Drawing.Color.Tomato;
            this.lbMensaje.Location = new System.Drawing.Point(110, 430);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(0, 24);
            this.lbMensaje.TabIndex = 26;
            // 
            // FormularioConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(858, 473);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.tbDatabase);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioConexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioConexion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private Label label5;
        private Button btnConectar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox tbUser;
        private TextBox tbPassword;
        private TextBox tbServer;
        private TextBox tbDatabase;
        private Label lbMensaje;
    }
}
