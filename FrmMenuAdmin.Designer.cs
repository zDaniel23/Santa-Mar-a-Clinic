namespace ProyectoDaniel
{
    partial class FrmMenuAdmin
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnGenerar = new FontAwesome.Sharp.IconButton();
            this.btnBitacora = new FontAwesome.Sharp.IconButton();
            this.btnVer = new FontAwesome.Sharp.IconButton();
            this.btnAsignar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTituloFormularioHijo = new System.Windows.Forms.Label();
            this.iconHijoActual = new FontAwesome.Sharp.IconPictureBox();
            this.panelSombra = new System.Windows.Forms.Panel();
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHijoActual)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnGenerar);
            this.panelMenu.Controls.Add(this.btnBitacora);
            this.panelMenu.Controls.Add(this.btnVer);
            this.panelMenu.Controls.Add(this.btnAsignar);
            this.panelMenu.Controls.Add(this.btnModificar);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGenerar.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnGenerar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGenerar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerar.IconSize = 32;
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.Location = new System.Drawing.Point(0, 380);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGenerar.Size = new System.Drawing.Size(220, 60);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar reportes";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnBitacora
            // 
            this.btnBitacora.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBitacora.FlatAppearance.BorderSize = 0;
            this.btnBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitacora.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBitacora.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnBitacora.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBitacora.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBitacora.IconSize = 32;
            this.btnBitacora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBitacora.Location = new System.Drawing.Point(0, 320);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBitacora.Size = new System.Drawing.Size(220, 60);
            this.btnBitacora.TabIndex = 4;
            this.btnBitacora.Text = "Bitácora";
            this.btnBitacora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBitacora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBitacora.UseVisualStyleBackColor = true;
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // btnVer
            // 
            this.btnVer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVer.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnVer.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVer.IconSize = 32;
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(0, 260);
            this.btnVer.Name = "btnVer";
            this.btnVer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnVer.Size = new System.Drawing.Size(220, 60);
            this.btnVer.TabIndex = 3;
            this.btnVer.Text = "Ver casos";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsignar.FlatAppearance.BorderSize = 0;
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAsignar.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnAsignar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAsignar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAsignar.IconSize = 32;
            this.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignar.Location = new System.Drawing.Point(0, 200);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAsignar.Size = new System.Drawing.Size(220, 60);
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.Text = "Asignar casos";
            this.btnAsignar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnModificar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 32;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(0, 140);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnModificar.Size = new System.Drawing.Size(220, 60);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar usuarios";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnInicio);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.Image = global::ProyectoDaniel.Properties.Resources.clinica;
            this.btnInicio.Location = new System.Drawing.Point(12, 31);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(189, 80);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelBarraTitulo.Controls.Add(this.btnCerrarSesion);
            this.panelBarraTitulo.Controls.Add(this.btnSalir);
            this.panelBarraTitulo.Controls.Add(this.lblTituloFormularioHijo);
            this.panelBarraTitulo.Controls.Add(this.iconHijoActual);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(220, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(580, 65);
            this.panelBarraTitulo.TabIndex = 1;
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.BlueViolet;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(493, 17);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTituloFormularioHijo
            // 
            this.lblTituloFormularioHijo.AutoSize = true;
            this.lblTituloFormularioHijo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTituloFormularioHijo.Location = new System.Drawing.Point(61, 22);
            this.lblTituloFormularioHijo.Name = "lblTituloFormularioHijo";
            this.lblTituloFormularioHijo.Size = new System.Drawing.Size(32, 13);
            this.lblTituloFormularioHijo.TabIndex = 1;
            this.lblTituloFormularioHijo.Text = "Inicio";
            // 
            // iconHijoActual
            // 
            this.iconHijoActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconHijoActual.ForeColor = System.Drawing.Color.BlueViolet;
            this.iconHijoActual.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.iconHijoActual.IconColor = System.Drawing.Color.BlueViolet;
            this.iconHijoActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHijoActual.IconSize = 37;
            this.iconHijoActual.Location = new System.Drawing.Point(18, 12);
            this.iconHijoActual.Name = "iconHijoActual";
            this.iconHijoActual.Size = new System.Drawing.Size(37, 37);
            this.iconHijoActual.TabIndex = 0;
            this.iconHijoActual.TabStop = false;
            // 
            // panelSombra
            // 
            this.panelSombra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelSombra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSombra.Location = new System.Drawing.Point(220, 65);
            this.panelSombra.Name = "panelSombra";
            this.panelSombra.Size = new System.Drawing.Size(580, 10);
            this.panelSombra.TabIndex = 2;
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(220, 75);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(580, 375);
            this.panelEscritorio.TabIndex = 3;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.BlueViolet;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrarSesion.Location = new System.Drawing.Point(395, 17);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(92, 23);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // FrmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panelSombra);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelMenu);
            this.Name = "FrmMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenuAdmin_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHijoActual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnModificar;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnGenerar;
        private FontAwesome.Sharp.IconButton btnBitacora;
        private FontAwesome.Sharp.IconButton btnVer;
        private FontAwesome.Sharp.IconButton btnAsignar;
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private FontAwesome.Sharp.IconPictureBox iconHijoActual;
        private System.Windows.Forms.Label lblTituloFormularioHijo;
        private System.Windows.Forms.Panel panelSombra;
        private System.Windows.Forms.Panel panelEscritorio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}