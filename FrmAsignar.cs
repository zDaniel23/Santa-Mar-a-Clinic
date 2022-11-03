using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDaniel
{
    public partial class FrmAsignar : Form
    {
        public FrmAsignar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAsignar_Load(object sender, EventArgs e)
        {
            //CENTRA LOS ATRIBUTOS EN EL DATAGRIED VIEW
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; 

            // CARGA Y SE TRAE LO QUE NECESITO DEL DATASET
            this.casoTableAdapter.Fill(this.dataSet1.caso);
            this.usuarioTableAdapter.FillTecnico(this.dataSet1.usuario);

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            //ACTUALIZA EL NÚMERO 0 PORRR
            if (lblCasoId.Text !="0")
            {
                this.casoTableAdapter.AsignarTec((int)cbTec.SelectedValue,2,(Int32.Parse(lblCasoId.Text)));
                cargar();
            }
        }
        private void cargar()
        {
            //CARGA LOS LBL 'POR DEFECTO', CARGA EL COMBO BOX Y RELLENA LOS DATOS.
            this.lblCasoId.Text = "0";
            this.lblTec.Text = "0";
            this.casoTableAdapter.Fill(this.dataSet1.caso);
            cbTec.SelectedIndex = 0;

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //EL ID DE CASO Y EL TÉCNICO CAMBIAN CON EL CLICK EN LA CELDA.
            if (e.RowIndex >= 0)
            {
                this.lblCasoId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.lblTec.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void cbTec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTec_Click(object sender, EventArgs e)
        {

        }
    }
}
