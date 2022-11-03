namespace ProyectoDaniel
{
    partial class FrmVer
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbEstados = new System.Windows.Forms.ComboBox();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ProyectoDaniel.DataSet1();
            this.estadosTableAdapter = new ProyectoDaniel.DataSet1TableAdapters.estadosTableAdapter();
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
            this.casoTableAdapter = new ProyectoDaniel.DataSet1TableAdapters.casoTableAdapter();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(32, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado:";
            // 
            // cbEstados
            // 
            this.cbEstados.DataSource = this.estadosBindingSource;
            this.cbEstados.DisplayMember = "nombre_estado";
            this.cbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstados.FormattingEnabled = true;
            this.cbEstados.Location = new System.Drawing.Point(97, 49);
            this.cbEstados.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Size = new System.Drawing.Size(160, 28);
            this.cbEstados.TabIndex = 1;
            this.cbEstados.ValueMember = "id_estado";
          
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataMember = "estados";
            this.estadosBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadosTableAdapter
            // 
            this.estadosTableAdapter.ClearBeforeFill = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(36, 128);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(993, 411);
            this.dataGridView1.TabIndex = 2;
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
            this.correocasoDataGridViewTextBoxColumn.HeaderText = "Caso";
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
            this.nombreestadoDataGridViewTextBoxColumn.Width = 140;
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
            // casoTableAdapter
            // 
            this.casoTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(179)))), ((int)(((byte)(191)))));
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(929, 551);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 34);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(196)))), ((int)(((byte)(217)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(289, 46);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 34);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(1054, 691);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbEstados);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmVer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver casos";
            this.Load += new System.EventHandler(this.FrmVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEstados;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private DataSet1TableAdapters.estadosTableAdapter estadosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource casoBindingSource;
        private DataSet1TableAdapters.casoTableAdapter casoTableAdapter;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
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