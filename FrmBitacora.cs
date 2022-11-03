using System;
using System.Windows.Forms;

namespace ProyectoDaniel
{
    public partial class FrmBitacora : Form
    {
        public FrmBitacora()
        {
            InitializeComponent();
        }

        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            //CENTRA LOS ATRIBUTOS EN EL DATAGRIED VIEW
            dgvBitacora.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //SE CARGAN LOS DATOS EN EL DATAGRIED VIEW
            this.bitacoraTableAdapter.Fill(this.dataSet1.bitacora);
            this.bitacoraTableAdapter.Fill(this.dataSet1.bitacora);

        }

     

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
