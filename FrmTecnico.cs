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
    public partial class FrmTecnico : Form
    {
        public FrmTecnico()
        {
            InitializeComponent();
        }

        private void FrmTecnico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.estados' Puede moverla o quitarla según sea necesario.
            this.estadosTableAdapter.FillBy(this.dataSet1.estados);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.caso' Puede moverla o quitarla según sea necesario.
            this.casoTableAdapter.FillTecnicoAsig(this.dataSet1.caso, Int32.Parse(lblUsuario.Text));


        }
        public void logeoTec(String tecnico)
        {
            lblUsuario.Text = tecnico;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void cargar()
        {
            this.casoTableAdapter.FillTecnicoAsig(this.dataSet1.caso, Int32.Parse(lblUsuario.Text));
            this.lblNumCaso.Text = "0";
            this.lblUsuario.Text = "0";
            txtResolucion.Text = "";

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(lblNumCaso.Text != "0")
            {
                this.casoTableAdapter.UpdateResolucion(txtResolucion.Text, (Int32.Parse(lblNumCaso.Text)));
                cargar();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if(lblNumCaso.Text != "0")
            {
                this.casoTableAdapter.UpdateEstadoFinalizar(4,(Int32.Parse(lblNumCaso.Text)));
                cargar();

                System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
                mmsg.To.Add(lblCorreoUsuario.Text);
                mmsg.Subject = "Correo prueba";
                mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
                mmsg.Bcc.Add("proyectoprogra23@gmail.com");


                mmsg.Body = "Este correo ha sido enviado desde C# para el Proyecto de Programación de Daniel de la 11-8";
                mmsg.BodyEncoding = System.Text.Encoding.UTF8;
                mmsg.IsBodyHtml = true;
                mmsg.From = new System.Net.Mail.MailAddress("proyectoprogra23@gmail.com");


                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

                cliente.Credentials = new System.Net.NetworkCredential("proyectoprogra23@gmail.com", "infernape23");


                cliente.Port = 587;
                cliente.EnableSsl = true;

                cliente.Host = "smtp@gmail.com"; //mail.dominio.com

                try
                {
                    cliente.Send(mmsg);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al enviar el correo electrónico");
                }
            }
        }

        private void dgvCasosTec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.lblNumCaso.Text = dgvCasosTec.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.lblCorreoUsuario.Text = dgvCasosTec.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de querer cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                FrmLogear ventanaCerrarSesion = new FrmLogear();
                ventanaCerrarSesion.Show();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("No cerró sesión", "Cerrar sesión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
