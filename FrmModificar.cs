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
    public partial class FrmModificar : Form
    {
        public FrmModificar()
        {
            InitializeComponent();
        }

        private void FrmModificar_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
   
            // TODO: esta línea de código carga datos en la tabla 'dataSet11.rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.dataSet11.rol);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.dataSet1.usuario);
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.usuarioTableAdapter.AgregarUsuarios((int)cbRol.SelectedValue, txtNombre.Text, txtCorreo.Text, txtContrasena.Text);
            cargar();
        }
        private void cargar()
        {
            this.lblUsuarioId.Text = "0";
            this.usuarioTableAdapter.Fill(this.dataSet1.usuario);
            cbRol.SelectedIndex = 0;
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtContrasena.Text = "";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0){
                this.lblUsuarioId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(lblUsuarioId.Text != "0")
            {
                this.usuarioTableAdapter.ModificarUsuarios((int)cbRol.SelectedValue, txtNombre.Text, txtCorreo.Text, txtContrasena.Text, (Int32.Parse(lblUsuarioId.Text)));
                cargar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            this.usuarioTableAdapter.UpdateActivo(false, Int32.Parse(lblUsuarioId.Text));
            cargar();
        }

       

        private void btnActivar_Click(object sender, EventArgs e)
        {
            this.usuarioTableAdapter.UpdateActivo(true, Int32.Parse(lblUsuarioId.Text));
            cargar();
        }

    }
}
