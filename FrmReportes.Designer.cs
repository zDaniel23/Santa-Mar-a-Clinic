namespace ProyectoDaniel
{
    partial class FrmReportes
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
            this.lblTec = new System.Windows.Forms.Label();
            this.cbTecnicos = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new ProyectoDaniel.DataSet1();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvCasosporTec = new System.Windows.Forms.DataGridView();
            this.casoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTop = new System.Windows.Forms.Label();
            this.lblCantidadCasos = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvTopCasos = new System.Windows.Forms.DataGridView();
            this.topCasosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casoTableAdapter = new ProyectoDaniel.DataSet1TableAdapters.casoTableAdapter();
            this.usuarioTableAdapter = new ProyectoDaniel.DataSet1TableAdapters.usuarioTableAdapter();
            this.topCasosTableAdapter = new ProyectoDaniel.DataSet1TableAdapters.TopCasosTableAdapter();
            this.btnSalir = new System.Windows.Forms.Button();
            this.idcasoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultadofechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcasoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecasoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correocasoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreestadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idestadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasosporTec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopCasos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCasosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTec
            // 
            this.lblTec.AutoSize = true;
            this.lblTec.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTec.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTec.Location = new System.Drawing.Point(16, 22);
            this.lblTec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTec.Name = "lblTec";
            this.lblTec.Size = new System.Drawing.Size(116, 20);
            this.lblTec.TabIndex = 0;
            this.lblTec.Text = "Técnico asignado:";
            // 
            // cbTecnicos
            // 
            this.cbTecnicos.DataSource = this.usuarioBindingSource;
            this.cbTecnicos.DisplayMember = "nombre_usuario";
            this.cbTecnicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTecnicos.FormattingEnabled = true;
            this.cbTecnicos.Location = new System.Drawing.Point(140, 19);
            this.cbTecnicos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTecnicos.Name = "cbTecnicos";
            this.cbTecnicos.Size = new System.Drawing.Size(160, 28);
            this.cbTecnicos.TabIndex = 1;
            this.cbTecnicos.ValueMember = "id_usuario";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDesde.Location = new System.Drawing.Point(28, 71);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(52, 20);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "DESDE:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(88, 67);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(265, 25);
            this.dtpDesde.TabIndex = 3;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHasta.Location = new System.Drawing.Point(361, 71);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(53, 20);
            this.lblHasta.TabIndex = 4;
            this.lblHasta.Text = "HASTA:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(422, 67);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(265, 25);
            this.dtpHasta.TabIndex = 5;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(196)))), ((int)(((byte)(217)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Location = new System.Drawing.Point(314, 15);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 35);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dgvCasosporTec
            // 
            this.dgvCasosporTec.AllowUserToAddRows = false;
            this.dgvCasosporTec.AllowUserToDeleteRows = false;
            this.dgvCasosporTec.AutoGenerateColumns = false;
            this.dgvCasosporTec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCasosporTec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcasoDataGridViewTextBoxColumn,
            this.nombrecasoDataGridViewTextBoxColumn,
            this.correocasoDataGridViewTextBoxColumn,
            this.idusuarioDataGridViewTextBoxColumn,
            this.detalleDataGridViewTextBoxColumn,
            this.resolucionDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.nombrecategoriaDataGridViewTextBoxColumn,
            this.nombreestadoDataGridViewTextBoxColumn,
            this.idcategoriaDataGridViewTextBoxColumn,
            this.idestadoDataGridViewTextBoxColumn});
            this.dgvCasosporTec.DataSource = this.casoBindingSource;
            this.dgvCasosporTec.Location = new System.Drawing.Point(20, 112);
            this.dgvCasosporTec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCasosporTec.Name = "dgvCasosporTec";
            this.dgvCasosporTec.ReadOnly = true;
            this.dgvCasosporTec.Size = new System.Drawing.Size(1257, 231);
            this.dgvCasosporTec.TabIndex = 7;
            // 
            // casoBindingSource
            // 
            this.casoBindingSource.DataMember = "caso";
            this.casoBindingSource.DataSource = this.dataSet11;
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTop.Location = new System.Drawing.Point(16, 381);
            this.lblTop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(270, 20);
            this.lblTop.TabIndex = 8;
            this.lblTop.Text = "Top casos que más tardaron en resolverse:";
            // 
            // lblCantidadCasos
            // 
            this.lblCantidadCasos.AutoSize = true;
            this.lblCantidadCasos.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadCasos.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCantidadCasos.Location = new System.Drawing.Point(28, 348);
            this.lblCantidadCasos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadCasos.Name = "lblCantidadCasos";
            this.lblCantidadCasos.Size = new System.Drawing.Size(123, 20);
            this.lblCantidadCasos.TabIndex = 9;
            this.lblCantidadCasos.Text = "Cantidad de casos:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCantidad.Location = new System.Drawing.Point(149, 348);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(17, 20);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "0";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(196)))), ((int)(((byte)(217)))));
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Location = new System.Drawing.Point(294, 374);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 35);
            this.btnGenerar.TabIndex = 11;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dgvTopCasos
            // 
            this.dgvTopCasos.AllowUserToAddRows = false;
            this.dgvTopCasos.AllowUserToDeleteRows = false;
            this.dgvTopCasos.AutoGenerateColumns = false;
            this.dgvTopCasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopCasos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcasoDataGridViewTextBoxColumn1,
            this.fechaDataGridViewTextBoxColumn1,
            this.resultadofechaDataGridViewTextBoxColumn});
            this.dgvTopCasos.DataSource = this.topCasosBindingSource;
            this.dgvTopCasos.Location = new System.Drawing.Point(20, 419);
            this.dgvTopCasos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTopCasos.Name = "dgvTopCasos";
            this.dgvTopCasos.ReadOnly = true;
            this.dgvTopCasos.Size = new System.Drawing.Size(677, 220);
            this.dgvTopCasos.TabIndex = 12;
            // 
            // topCasosBindingSource
            // 
            this.topCasosBindingSource.DataMember = "TopCasos";
            this.topCasosBindingSource.DataSource = this.dataSet11;
            // 
            // casoTableAdapter
            // 
            this.casoTableAdapter.ClearBeforeFill = true;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // topCasosTableAdapter
            // 
            this.topCasosTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(179)))), ((int)(((byte)(191)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(422, 15);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 35);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // idcasoDataGridViewTextBoxColumn1
            // 
            this.idcasoDataGridViewTextBoxColumn1.DataPropertyName = "id_caso";
            this.idcasoDataGridViewTextBoxColumn1.HeaderText = "# Caso";
            this.idcasoDataGridViewTextBoxColumn1.Name = "idcasoDataGridViewTextBoxColumn1";
            this.idcasoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn1
            // 
            this.fechaDataGridViewTextBoxColumn1.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn1.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn1.Name = "fechaDataGridViewTextBoxColumn1";
            this.fechaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // resultadofechaDataGridViewTextBoxColumn
            // 
            this.resultadofechaDataGridViewTextBoxColumn.DataPropertyName = "resultadofecha";
            this.resultadofechaDataGridViewTextBoxColumn.HeaderText = "Duración";
            this.resultadofechaDataGridViewTextBoxColumn.Name = "resultadofechaDataGridViewTextBoxColumn";
            this.resultadofechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcasoDataGridViewTextBoxColumn
            // 
            this.idcasoDataGridViewTextBoxColumn.DataPropertyName = "id_caso";
            this.idcasoDataGridViewTextBoxColumn.HeaderText = "# Caso";
            this.idcasoDataGridViewTextBoxColumn.Name = "idcasoDataGridViewTextBoxColumn";
            this.idcasoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrecasoDataGridViewTextBoxColumn
            // 
            this.nombrecasoDataGridViewTextBoxColumn.DataPropertyName = "nombre_caso";
            this.nombrecasoDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombrecasoDataGridViewTextBoxColumn.Name = "nombrecasoDataGridViewTextBoxColumn";
            this.nombrecasoDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.idusuarioDataGridViewTextBoxColumn.HeaderText = "# Usuario";
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
            // nombrecategoriaDataGridViewTextBoxColumn
            // 
            this.nombrecategoriaDataGridViewTextBoxColumn.DataPropertyName = "nombre_categoria";
            this.nombrecategoriaDataGridViewTextBoxColumn.HeaderText = "Categoría";
            this.nombrecategoriaDataGridViewTextBoxColumn.Name = "nombrecategoriaDataGridViewTextBoxColumn";
            this.nombrecategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreestadoDataGridViewTextBoxColumn
            // 
            this.nombreestadoDataGridViewTextBoxColumn.DataPropertyName = "nombre_estado";
            this.nombreestadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.nombreestadoDataGridViewTextBoxColumn.Name = "nombreestadoDataGridViewTextBoxColumn";
            this.nombreestadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcategoriaDataGridViewTextBoxColumn
            // 
            this.idcategoriaDataGridViewTextBoxColumn.DataPropertyName = "id_categoria";
            this.idcategoriaDataGridViewTextBoxColumn.HeaderText = "id_categoria";
            this.idcategoriaDataGridViewTextBoxColumn.Name = "idcategoriaDataGridViewTextBoxColumn";
            this.idcategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcategoriaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idestadoDataGridViewTextBoxColumn
            // 
            this.idestadoDataGridViewTextBoxColumn.DataPropertyName = "id_estado";
            this.idestadoDataGridViewTextBoxColumn.HeaderText = "id_estado";
            this.idestadoDataGridViewTextBoxColumn.Name = "idestadoDataGridViewTextBoxColumn";
            this.idestadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idestadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvTopCasos);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblCantidadCasos);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.dgvCasosporTec);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.cbTecnicos);
            this.Controls.Add(this.lblTec);
            this.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmReportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasosporTec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopCasos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCasosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTec;
        private System.Windows.Forms.ComboBox cbTecnicos;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgvCasosporTec;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblCantidadCasos;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvTopCasos;
        private DataSet1TableAdapters.casoTableAdapter casoTableAdapter;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.BindingSource casoBindingSource;
        private System.Windows.Forms.BindingSource topCasosBindingSource;
        private DataSet1TableAdapters.TopCasosTableAdapter topCasosTableAdapter;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcasoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultadofechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcasoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecasoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correocasoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreestadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idestadoDataGridViewTextBoxColumn;
    }
}