namespace ProyectoDaniel
{
    partial class FrmLogear
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
            this.lblInicie = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.usuarioTableAdapter1 = new ProyectoDaniel.DataSet1TableAdapters.usuarioTableAdapter();
            this.pbContrasena = new System.Windows.Forms.PictureBox();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogear = new System.Windows.Forms.Button();
            this.btnSalir = new FontAwesome.Sharp.IconPictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbContrasena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInicie
            // 
            this.lblInicie.AutoSize = true;
            this.lblInicie.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicie.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblInicie.Location = new System.Drawing.Point(405, 67);
            this.lblInicie.Name = "lblInicie";
            this.lblInicie.Size = new System.Drawing.Size(162, 38);
            this.lblInicie.TabIndex = 2;
            this.lblInicie.Text = "Inicie sesión";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUsuario.Location = new System.Drawing.Point(363, 138);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(67, 22);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblContrasena.Location = new System.Drawing.Point(363, 235);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(90, 22);
            this.lblContrasena.TabIndex = 4;
            this.lblContrasena.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(74)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtUsuario.Location = new System.Drawing.Point(382, 180);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(297, 18);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(74)))));
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtContrasena.Location = new System.Drawing.Point(382, 276);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '●';
            this.txtContrasena.Size = new System.Drawing.Size(297, 18);
            this.txtContrasena.TabIndex = 8;
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // pbContrasena
            // 
            this.pbContrasena.Image = global::ProyectoDaniel.Properties.Resources.azulbackground;
            this.pbContrasena.Location = new System.Drawing.Point(367, 260);
            this.pbContrasena.Name = "pbContrasena";
            this.pbContrasena.Size = new System.Drawing.Size(327, 50);
            this.pbContrasena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbContrasena.TabIndex = 6;
            this.pbContrasena.TabStop = false;
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = global::ProyectoDaniel.Properties.Resources.azulbackground;
            this.pbUsuario.Location = new System.Drawing.Point(367, 163);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(327, 50);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuario.TabIndex = 5;
            this.pbUsuario.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoDaniel.Properties.Resources.registro;
            this.pictureBox1.Location = new System.Drawing.Point(72, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogear
            // 
            this.btnLogear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(3)))), ((int)(((byte)(64)))));
            this.btnLogear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnLogear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogear.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogear.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogear.Location = new System.Drawing.Point(367, 333);
            this.btnLogear.Name = "btnLogear";
            this.btnLogear.Size = new System.Drawing.Size(327, 42);
            this.btnLogear.TabIndex = 9;
            this.btnLogear.Text = "Iniciar sesión";
            this.btnLogear.UseVisualStyleBackColor = false;
            this.btnLogear.Click += new System.EventHandler(this.btnLogear_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.XingSquare;
            this.btnSalir.IconColor = System.Drawing.Color.Red;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.Location = new System.Drawing.Point(756, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(32, 32);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 10;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(3)))), ((int)(((byte)(64)))));
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegresar.Location = new System.Drawing.Point(713, 405);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 33);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Volver";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmLogear
            // 
            this.AcceptButton = this.btnLogear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLogear);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pbContrasena);
            this.Controls.Add(this.pbUsuario);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblInicie);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbContrasena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblInicie;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.PictureBox pbContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private DataSet1TableAdapters.usuarioTableAdapter usuarioTableAdapter1;
        private System.Windows.Forms.Button btnLogear;
        private FontAwesome.Sharp.IconPictureBox btnSalir;
        private System.Windows.Forms.Button btnRegresar;
    }
}