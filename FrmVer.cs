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
    public partial class FrmVer : Form
    {
        public FrmVer()
        {
            InitializeComponent();
        }

        private void FrmVer_Load(object sender, EventArgs e)
        {
           
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.estados' Puede moverla o quitarla según sea necesario.
            this.estadosTableAdapter.Fill(this.dataSet1.estados);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.caso' Puede moverla o quitarla según sea necesario.
            

        }

       

     
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.casoTableAdapter.FillByEstado(this.dataSet1.caso, (int)cbEstados.SelectedValue);
        }
    }
}
