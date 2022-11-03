using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
namespace ProyectoDaniel
{
    public partial class FrmMenuAdmin : Form
    {
        //CAMPOS
        private IconButton currentBtn; // BOTÓN ACTUAL
        private Panel leftBorderBtn; // BOTÓN 'DOCK' A LA IZQUIERDA
        private Form currentChildForm; // FORMULARIO HIJO ACTUAL
        
        //CONSTRUCTOR
        public FrmMenuAdmin()
        {
            InitializeComponent();
            leftBorderBtn = new Panel(); // CREAR 'leftBorderBtn' COMO UN PANEL
            leftBorderBtn.Size = new Size(7,60); // EL TAMAÑO DEL PANEL EN PIXELES, ANCHO Y ALTURA.
            panelMenu.Controls.Add(leftBorderBtn); // SE AÑADEN LOS CONTROLES
            // FORMULARIO
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Estructuras
        private struct RGBColors
        {
            public static Color rosado = Color.FromArgb(242, 179, 191);
            public static Color morado = Color.FromArgb(217, 160, 187);
            public static Color celeste = Color.FromArgb(167, 203, 217);
            public static Color celesteoscuro = Color.FromArgb(106, 196, 217);
            public static Color crema = Color.FromArgb(242, 198, 182);
        }
        //MÉTODOS
        private void ActivarBoton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DeshabilitarBoton(); 
                // BOTÓN
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                 
                // BOTÓN DEL BORDE IZQUIERDO
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // ICONO ACTUAL FORMULARIO HIJO
                iconHijoActual.IconChar = currentBtn.IconChar;
                iconHijoActual.IconColor = color;

            }
        }
        private void DeshabilitarBoton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void AbrirFormularioHijo(Form childForm)
        {
            if(currentChildForm != null)
            {
                //ABRIR UN SOLO FORMULARIO
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(childForm);
            panelEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTituloFormularioHijo.Text = childForm.Text;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.rosado);
            AbrirFormularioHijo(new FrmModificar());
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.morado);
            AbrirFormularioHijo(new FrmAsignar());
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.celeste);
            AbrirFormularioHijo(new FrmVer());
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.celesteoscuro);
            AbrirFormularioHijo(new FrmBitacora());
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.crema);
            AbrirFormularioHijo(new FrmReportes());
            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
        private void Reset()
        {
            DeshabilitarBoton();
            leftBorderBtn.Visible = false;
            iconHijoActual.IconChar = IconChar.HouseUser;
            iconHijoActual.IconColor = Color.BlueViolet;
            lblTituloFormularioHijo.Text = "Inicio";
        }
        //ARRASTRAR FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmMenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
