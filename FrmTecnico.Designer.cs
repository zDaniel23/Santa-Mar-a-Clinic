namespace ProyectoDaniel
{
    partial class FrmTecnico
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
            this.lblNumCaso = new System.Windows.Forms.Label();
            this.lblCaso = new System.Windows.Forms.Label();
            this.dgvCasosTec = new System.Windows.Forms.DataGridView();
            this.idcasoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecasoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correocasoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreestadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ProyectoDaniel.DataSet1();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblResolucion = new System.Windows.Forms.Label();
            this.txtResolucion = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.casoTableAdapter = new ProyectoDaniel.DataSet1TableAdapters.casoTableAdapter();
            this.estadosTableAdapter = new ProyectoDaniel.DataSet1TableAdapters.estadosTableAdapter();
            this.estadosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblCorreoUsuario = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasosTec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumCaso
            // 
            this.lblNumCaso.AutoSize = true;
            this.lblNumCaso.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNumCaso.Location = new System.Drawing.Point(69, 34);
            this.lblNumCaso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumCaso.Name = "lblNumCaso";
            this.lblNumCaso.Size = new System.Drawing.Size(17, 20);
            this.lblNumCaso.TabIndex = 0;
            this.lblNumCaso.Text = "0";
            // 
            // lblCaso
            // 
            this.lblCaso.AutoSize = true;
            this.lblCaso.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCaso.Location = new System.Drawing.Point(20, 34);
            this.lblCaso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaso.Name = "lblCaso";
            this.lblCaso.Size = new System.Drawing.Size(37, 20);
            this.lblCaso.TabIndex = 1;
            this.lblCaso.Text = "Caso";
            // 
            // dgvCasosTec
            // 
            this.dgvCasosTec.AllowUserToAddRows = false;
            this.dgvCasosTec.AllowUserToDeleteRows = false;
            this.dgvCasosTec.AutoGenerateColumns = false;
            this.dgvCasosTec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCasosTec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcasoDataGridViewTextBoxColumn,
            this.nombrecasoDataGridViewTextBoxColumn,
            this.nombrecategoriaDataGridViewTextBoxColumn,
            this.correocasoDataGridViewTextBoxColumn,
            this.idusuarioDataGridViewTextBoxColumn,
            this.detalleDataGridViewTextBoxColumn,
            this.resolucionDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.nombreestadoDataGridViewTextBoxColumn});
            this.dgvCasosTec.DataSource = this.casoBindingSource;
            this.dgvCasosTec.Location = new System.Drawing.Point(24, 183);
            this.dgvCasosTec.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgvCasosTec.Name = "dgvCasosTec";
            this.dgvCasosTec.ReadOnly = true;
            this.dgvCasosTec.Size = new System.Drawing.Size(1213, 381);
            this.dgvCasosTec.TabIndex = 4;
            this.dgvCasosTec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCasosTec_CellClick);
            // 
            // idcasoDataGridViewTextBoxColumn
            // 
            this.idcasoDataGridViewTextBoxColumn.DataPropertyName = "id_caso";
            this.idcasoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idcasoDataGridViewTextBoxColumn.Name = "idcasoDataGridViewTextBoxColumn";
            this.idcasoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrecasoDataGridViewTextBoxColumn
            // 
            this.nombrecasoDataGridViewTextBoxColumn.DataPropertyName = "nombre_caso";
            this.nombrecasoDataGridViewTextBoxColumn.HeaderText = "Solicitante";
            this.nombrecasoDataGridViewTextBoxColumn.Name = "nombrecasoDataGridViewTextBoxColumn";
            this.nombrecasoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrecategoriaDataGridViewTextBoxColumn
            // 
            this.nombrecategoriaDataGridViewTextBoxColumn.DataPropertyName = "nombre_categoria";
            this.nombrecategoriaDataGridViewTextBoxColumn.HeaderText = "Categoría";
            this.nombrecategoriaDataGridViewTextBoxColumn.Name = "nombrecategoriaDataGridViewTextBoxColumn";
            this.nombrecategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correocasoDataGridViewTextBoxColumn
            // 
            this.correocasoDataGridViewTextBoxColumn.DataPropertyName = "correo_caso";
            this.correocasoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correocasoDataGridViewTextBoxColumn.Name = "correocasoDataGridViewTextBoxColumn";
            this.correocasoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idusuarioDataGridViewTextBoxColumn
            // 
            this.idusuarioDataGridViewTextBoxColumn.DataPropertyName = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.HeaderText = "ID User";
            this.idusuarioDataGridViewTextBoxColumn.Name = "idusuarioDataGridViewTextBoxColumn";
            this.idusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detalleDataGridViewTextBoxColumn
            // 
            this.detalleDataGridViewTextBoxColumn.DataPropertyName = "detalle";
            this.detalleDataGridViewTextBoxColumn.HeaderText = "Detalle";
            this.detalleDataGridViewTextBoxColumn.Name = "detalleDataGridViewTextBoxColumn";
            this.detalleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resolucionDataGridViewTextBoxColumn
            // 
            this.resolucionDataGridViewTextBoxColumn.DataPropertyName = "resolucion";
            this.resolucionDataGridViewTextBoxColumn.HeaderText = "Resolución";
            this.resolucionDataGridViewTextBoxColumn.Name = "resolucionDataGridViewTextBoxColumn";
            this.resolucionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreestadoDataGridViewTextBoxColumn
            // 
            this.nombreestadoDataGridViewTextBoxColumn.DataPropertyName = "nombre_estado";
            this.nombreestadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.nombreestadoDataGridViewTextBoxColumn.Name = "nombreestadoDataGridViewTextBoxColumn";
            this.nombreestadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // casoBindingSource
            // 
            this.casoBindingSource.DataMember = "caso";
            this.casoBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(179)))), ((int)(((byte)(191)))));
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(1137, 589);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 34);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(179)))), ((int)(((byte)(191)))));
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Location = new System.Drawing.Point(225, 123);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(100, 34);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblResolucion
            // 
            this.lblResolucion.AutoSize = true;
            this.lblResolucion.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblResolucion.Location = new System.Drawing.Point(20, 86);
            this.lblResolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResolucion.Name = "lblResolucion";
            this.lblResolucion.Size = new System.Drawing.Size(76, 20);
            this.lblResolucion.TabIndex = 7;
            this.lblResolucion.Text = "Resolución:";
            // 
            // txtResolucion
            // 
            this.txtResolucion.Location = new System.Drawing.Point(112, 80);
            this.txtResolucion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtResolucion.Name = "txtResolucion";
            this.txtResolucion.Size = new System.Drawing.Size(276, 25);
            this.txtResolucion.TabIndex = 8;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(203)))), ((int)(((byte)(217)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(24, 123);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(193, 34);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar resolución";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUsuario.Location = new System.Drawing.Point(1220, 51);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(17, 20);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "0";
            // 
            // casoTableAdapter
            // 
            this.casoTableAdapter.ClearBeforeFill = true;
            // 
            // estadosTableAdapter
            // 
            this.estadosTableAdapter.ClearBeforeFill = true;
            // 
            // estadosBindingSource1
            // 
            this.estadosBindingSource1.DataMember = "estados";
            this.estadosBindingSource1.DataSource = this.dataSet1;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCorreo.Location = new System.Drawing.Point(396, 34);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(121, 20);
            this.lblCorreo.TabIndex = 11;
            this.lblCorreo.Text = "Correo electrónico:";
            // 
            // lblCorreoUsuario
            // 
            this.lblCorreoUsuario.AutoSize = true;
            this.lblCorreoUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCorreoUsuario.Location = new System.Drawing.Point(525, 34);
            this.lblCorreoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreoUsuario.Name = "lblCorreoUsuario";
            this.lblCorreoUsuario.Size = new System.Drawing.Size(13, 20);
            this.lblCorreoUsuario.TabIndex = 12;
            this.lblCorreoUsuario.Text = " ";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(179)))), ((int)(((byte)(191)))));
            this.btnCerrarSesion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Location = new System.Drawing.Point(1011, 589);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(118, 34);
            this.btnCerrarSesion.TabIndex = 13;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // FrmTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.CancelButton = this.btnSalir;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1364, 706);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblCorreoUsuario);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtResolucion);
            this.Controls.Add(this.lblResolucion);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvCasosTec);
            this.Controls.Add(this.lblCaso);
            this.Controls.Add(this.lblNumCaso);
            this.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTecnico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Técnico";
            this.Load += new System.EventHandler(this.FrmTecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasosTec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumCaso;
        private System.Windows.Forms.Label lblCaso;
        private System.Windows.Forms.DataGridView dgvCasosTec;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource casoBindingSource;
        private DataSet1TableAdapters.casoTableAdapter casoTableAdapter;
        private System.Windows.Forms.Button btnSalir;
        private DataSet1TableAdapters.estadosTableAdapter estadosTableAdapter;
        private System.Windows.Forms.BindingSource estadosBindingSource1;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblResolucion;
        private System.Windows.Forms.TextBox txtResolucion;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblCorreoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcasoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecasoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correocasoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreestadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}