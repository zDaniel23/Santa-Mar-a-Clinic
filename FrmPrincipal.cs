using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ProyectoDaniel
{
    public partial class frmPrincipal : Form
    {
        bool salir = false;
        public frmPrincipal()
        {
            InitializeComponent();
           
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        private void btnAcceso_Click(object sender, EventArgs e)
        {
            salir = true;
            FrmLogear logear = new FrmLogear();
            logear.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                casoTableAdapter1.InsertQuery(txtSolicitante.Text, txtCorreo.Text, (int)cbCategoria.SelectedValue, txtDetalle.Text);
                MessageBox.Show("Caso registrado", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }//FIN IF
        }

        private void txtSolicitante_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtSolicitante.Text) && !salir)
            {
                e.Cancel = true;
                txtSolicitante.Focus();
                errorProvider1.SetError(txtSolicitante, "Por favor inserte su nombre de usuario !");
            }//FIN IF
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSolicitante,null);
            }//FIN ELSE
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtCorreo.Text) && !salir)
            {
                e.Cancel= true;
                txtCorreo.Focus();
                errorProvider1.SetError(txtCorreo, "Por favor inserte un correo electrónico !");
            }//FIN IF
            else
            {
                try
                {
                    var direction = new System.Net.Mail.MailAddress(txtCorreo.Text);
                    e.Cancel = false;
                    errorProvider1.SetError(txtCorreo, null);
                }
                catch (Exception ex)
                {
                    e.Cancel = true;
                    txtCorreo.Focus();
                    errorProvider1.SetError(txtCorreo, "Por favor inserte un correo electrónico válido !");
                }
                        
            }//FIN ELSE

        }//FIN txtCorreo_Validating

        private void txtDetalle_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtDetalle.Text) && !salir)
            {
                e.Cancel = true;
                txtDetalle.Focus();
                errorProvider1.SetError(txtDetalle, "Por favor inserte un detalle");
            }//FIN IF
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDetalle, null);
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.dataSet1.categoria);

        }

       
    }
}
