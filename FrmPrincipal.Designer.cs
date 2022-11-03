namespace ProyectoDaniel
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSolicitante = new System.Windows.Forms.Label();
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAcceso = new System.Windows.Forms.Button();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ProyectoDaniel.DataSet1();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.casoTableAdapter1 = new ProyectoDaniel.DataSet1TableAdapters.casoTableAdapter();
            this.categoriaTableAdapter = new ProyectoDaniel.DataSet1TableAdapters.categoriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSolicitante
            // 
            this.lblSolicitante.AutoSize = true;
            this.lblSolicitante.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitante.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSolicitante.Location = new System.Drawing.Point(24, 35);
            this.lblSolicitante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSolicitante.Name = "lblSolicitante";
            this.lblSolicitante.Size = new System.Drawing.Size(74, 19);
            this.lblSolicitante.TabIndex = 2;
            this.lblSolicitante.Text = "Solicitante:";
            
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.BackColor = System.Drawing.SystemColors.Window;
            this.txtSolicitante.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolicitante.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSolicitante.Location = new System.Drawing.Point(103, 32);
            this.txtSolicitante.Margin = new System.Windows.Forms.Padding(4);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.Size = new System.Drawing.Size(116, 25);
            this.txtSolicitante.TabIndex = 3;
            
            this.txtSolicitante.Validating += new System.ComponentModel.CancelEventHandler(this.txtSolicitante_Validating);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCorreo.Location = new System.Drawing.Point(225, 35);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(51, 19);
            this.lblCorreo.TabIndex = 4;
            this.lblCorreo.Text = "Correo:";
            
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(279, 32);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(259, 25);
            this.txtCorreo.TabIndex = 5;
            this.txtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCorreo_Validating);
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDetalle.Location = new System.Drawing.Point(29, 80);
            this.lblDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(55, 19);
            this.lblDetalle.TabIndex = 6;
            this.lblDetalle.Text = "Detalle:";
            
            // 
            // txtDetalle
            // 
            this.txtDetalle.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.Location = new System.Drawing.Point(91, 77);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(456, 27);
            this.txtDetalle.TabIndex = 7;
            this.txtDetalle.Validating += new System.ComponentModel.CancelEventHandler(this.txtDetalle_Validating);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCategoria.Location = new System.Drawing.Point(29, 131);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 19);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoría:";
            
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(196)))), ((int)(((byte)(217)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Location = new System.Drawing.Point(357, 224);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(88, 34);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(179)))), ((int)(((byte)(191)))));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(452, 224);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 34);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            
            // 
            // btnAcceso
            // 
            this.btnAcceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(196)))), ((int)(((byte)(217)))));
            this.btnAcceso.CausesValidation = false;
            this.btnAcceso.FlatAppearance.BorderSize = 2;
            this.btnAcceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceso.ForeColor = System.Drawing.Color.Black;
            this.btnAcceso.Location = new System.Drawing.Point(32, 224);
            this.btnAcceso.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcceso.Name = "btnAcceso";
            this.btnAcceso.Size = new System.Drawing.Size(132, 34);
            this.btnAcceso.TabIndex = 12;
            this.btnAcceso.Text = "Acceso avanzado";
            this.btnAcceso.UseVisualStyleBackColor = false;
            this.btnAcceso.Click += new System.EventHandler(this.btnAcceso_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DataSource = this.categoriaBindingSource;
            this.cbCategoria.DisplayMember = "nombre_categoria";
            this.cbCategoria.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(103, 124);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(140, 28);
            this.cbCategoria.TabIndex = 13;
            this.cbCategoria.ValueMember = "id_categoria";
            
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "categoria";
            this.categoriaBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // casoTableAdapter1
            // 
            this.casoTableAdapter1.ClearBeforeFill = true;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // frmPrincipal
            // 
            this.AcceptButton = this.btnEnviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(560, 268);
            this.ControlBox = false;
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.btnAcceso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtSolicitante);
            this.Controls.Add(this.lblSolicitante);
            this.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSolicitante;
        private System.Windows.Forms.TextBox txtSolicitante;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAcceso;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DataSet1TableAdapters.casoTableAdapter casoTableAdapter1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private DataSet1TableAdapters.categoriaTableAdapter categoriaTableAdapter;
    }
}

