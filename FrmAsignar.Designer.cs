namespace ProyectoDaniel
{
    partial class FrmAsignar
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
            this.lblAsignar = new System.Windows.Forms.Label();
            this.lblCasoId = new System.Windows.Forms.Label();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.cbTec = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ProyectoDaniel.DataSet1();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.casoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new ProyectoDaniel.DataSet1TableAdapters.usuarioTableAdapter();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.casoTableAdapter = new ProyectoDaniel.DataSet1TableAdapters.casoTableAdapter();
            this.lblTec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAsignar
            // 
            this.lblAsignar.AutoSize = true;
            this.lblAsignar.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAsignar.Location = new System.Drawing.Point(29, 14);
            this.lblAsignar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsignar.Name = "lblAsignar";
            this.lblAsignar.Size = new System.Drawing.Size(102, 20);
            this.lblAsignar.TabIndex = 0;
            this.lblAsignar.Text = "Asignar técnico";
            // 
            // lblCasoId
            // 
            this.lblCasoId.AutoSize = true;
            this.lblCasoId.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCasoId.Location = new System.Drawing.Point(75, 49);
            this.lblCasoId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCasoId.Name = "lblCasoId";
            this.lblCasoId.Size = new System.Drawing.Size(17, 20);
            this.lblCasoId.TabIndex = 1;
            this.lblCasoId.Text = "0";
            // 
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTecnico.Location = new System.Drawing.Point(27, 83);
            this.lblTecnico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(55, 20);
            this.lblTecnico.TabIndex = 2;
            this.lblTecnico.Text = "Técnico:";
            this.lblTecnico.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbTec
            // 
            this.cbTec.DataSource = this.usuarioBindingSource;
            this.cbTec.DisplayMember = "nombre_usuario";
            this.cbTec.FormattingEnabled = true;
            this.cbTec.Location = new System.Drawing.Point(100, 79);
            this.cbTec.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbTec.Name = "cbTec";
            this.cbTec.Size = new System.Drawing.Size(160, 28);
            this.cbTec.TabIndex = 3;
            this.cbTec.ValueMember = "id_usuario";
            this.cbTec.SelectedIndexChanged += new System.EventHandler(this.cbTec_SelectedIndexChanged);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(196)))), ((int)(((byte)(217)))));
            this.btnAsignar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAsignar.Location = new System.Drawing.Point(301, 76);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(100, 34);
            this.btnAsignar.TabIndex = 5;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(179)))), ((int)(((byte)(191)))));
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(942, 590);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 34);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.casoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(48, 149);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(994, 429);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idcasoDataGridViewTextBoxColumn
            // 
            this.idcasoDataGridViewTextBoxColumn.DataPropertyName = "id_caso";
            this.idcasoDataGridViewTextBoxColumn.HeaderText = "ID Caso";
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
            this.nombreestadoDataGridViewTextBoxColumn.Width = 150;
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
            // casoBindingSource
            // 
            this.casoBindingSource.DataMember = "caso";
            this.casoBindingSource.DataSource = this.dataSet1;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "usuario";
            this.usuarioBindingSource1.DataSource = this.dataSet1;
            // 
            // casoTableAdapter
            // 
            this.casoTableAdapter.ClearBeforeFill = true;
            // 
            // lblTec
            // 
            this.lblTec.AutoSize = true;
            this.lblTec.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTec.Location = new System.Drawing.Point(144, 14);
            this.lblTec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTec.Name = "lblTec";
            this.lblTec.Size = new System.Drawing.Size(17, 20);
            this.lblTec.TabIndex = 9;
            this.lblTec.Text = "0";
            this.lblTec.Click += new System.EventHandler(this.lblTec_Click);
            // 
            // FrmAsignar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(1370, 693);
            this.ControlBox = false;
            this.Controls.Add(this.lblTec);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.cbTec);
            this.Controls.Add(this.lblTecnico);
            this.Controls.Add(this.lblCasoId);
            this.Controls.Add(this.lblAsignar);
            this.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmAsignar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar";
            this.Load += new System.EventHandler(this.FrmAsignar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsignar;
        private System.Windows.Forms.Label lblCasoId;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.ComboBox cbTec;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DataSet1TableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource casoBindingSource;
        private DataSet1TableAdapters.casoTableAdapter casoTableAdapter;
        private System.Windows.Forms.Label lblTec;
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