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
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet11.TopCasos' Puede moverla o quitarla según sea necesario.
            dgvTopCasos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCasosporTec.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.topCasosTableAdapter.Fill(this.dataSet11.TopCasos);
            this.usuarioTableAdapter.FillTecnico(this.dataSet11.usuario);

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.casoTableAdapter.FillCasosporTEC(this.dataSet11.caso, (int)cbTecnicos.SelectedValue);
            this.casoTableAdapter.FillByFechas(this.dataSet11.caso, DateTime.Parse(dtpDesde.Text + " 00:00:00"), DateTime.Parse(dtpHasta.Text + " 23:59:59"), (int)cbTecnicos.SelectedValue);
            lblCantidad.Text = dgvCasosporTec.Rows.Count.ToString();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                this.topCasosTableAdapter.Fill(this.dataSet11.TopCasos);
            }
            catch (Exception)
            {
                MessageBox.Show("Hay un registro repetido");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
