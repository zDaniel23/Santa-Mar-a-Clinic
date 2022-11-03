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
    public partial class FrmLogear : Form
    {
        public FrmLogear()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }



       

        private void btnLogear_Click_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length == 0 || txtContrasena.Text.Length == 0) //Si el usuario o la contraseña está vacío
            {
                MessageBox.Show("Favor colocar credenciales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Tirar este error

            } //FIN IF

            if (txtUsuario.Text != "" && txtContrasena.Text != "") //SI USUARIO Y CONTRASEÑA SON DIFERENTES A ""
            {
                DataTable login = new DataTable();
                login = usuarioTableAdapter1.GetDataBy2(txtUsuario.Text, txtContrasena.Text); //TRAER LOS DATOS DE USUARIO TABLE ADAPTER
                if (login.Rows.Count > 0) // SI LA CUENTA DE REGISTROS ES MAYOR A 0 ENTONCES
                {
                    String rol = login.Rows[0][1].ToString();
                    String activo = login.Rows[0][5].ToString();
                    String logeoTec = login.Rows[0][0].ToString();
                    if (rol == "1" && activo == "True") // SI EL ROL ES IGUAL A ADMINISTRADOR Y EL USUARIO SE ENCUENTRA ACTIVO ENTONCES ABRIR EL MENÚ ADMINISTRATIVO
                    {
                        FrmMenuAdmin ventanaAdmin = new FrmMenuAdmin();
                        ventanaAdmin.Show();
                        this.Close();
                    } //FIN IF ROL 1
                    else if (rol == "1" && activo == "False") // SINO SE CUMPLE, SI EL ROL ES IGUAL A ADMINISTRADOR Y EL USUARIO NO SE ENCUENTRA ACTIVO ENTONCES 
                    {
                        MessageBox.Show("Usuario deshabilitado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //SE TIRA EL SIGUIENTE ERROR
                    }
                    else
                    {
                        if (rol == "2" && activo == "True") // SI EL ROL ES IGUAL A TÉCNICO Y EL USUARIO SE ENCUENTRA ACTIVO, ENTONCES ABRE EL MENÚ DEL TÉCNICO LOGEADO
                        {
                            FrmTecnico ventanaTecnico = new FrmTecnico();
                            ventanaTecnico.logeoTec(logeoTec);
                            ventanaTecnico.Show();
                            this.Close();
                        } //FIN IF ROL 2
                    else if (rol == "2" && activo == "False") // SINO SE CUMPLE, SI EL ROL ES IGUAL A TÉCNICO Y EL USUARIO SE ENCUENTRA DESHABILITADO, ENTONCES
                    {
                        MessageBox.Show("Usuario deshabilitado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //APARECE EL SIGUIENTE ERROR
                    }
                    else
                        {
                         if (rol == "3" && activo == "True") //SI EL ROL ES IGUAL A EXTERNO Y EL USUARIO SE ENCUENTRA ACTIVO ENTONCES
                         {
                          MessageBox.Show("Usted no tiene permisos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // APARECERÁ EL SIGUIENTE ERROR
                         } // FIN IF ROL 3
                   
                        } // FIN ELSE ROL 3
                    } // FIN ELSE ROL 2 - 3
                }//FIN LOGIN ROWS COUNT
                else //SI NINGUNA DE LAS CONDICIONES SE CUMPLEN, ENTONCES LAS CREDENCIALES SON INCORRECTAS, APARECERÁ EL SIGUIENTE ERROR
                {
                    MessageBox.Show("Usuario o clave incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                } // FIN ELSE USUARIO O CLAVE INCORRECTOS

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
                Application.Exit();
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmPrincipal volverPrincipal = new frmPrincipal();
            volverPrincipal.Show();
            this.Close();
        }
    }
}
