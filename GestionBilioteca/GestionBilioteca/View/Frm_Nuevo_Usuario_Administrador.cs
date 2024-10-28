using GestionBilioteca.Class;
using GestionBilioteca.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace GestionBilioteca.View
{
    public partial class Frm_Nuevo_Usuario_Administrador : Form
    {
        private Usuario usuarioRegistro;
        private bool verClave;
        public Frm_Nuevo_Usuario_Administrador()
        {
            InitializeComponent();
            usuarioRegistro = new Usuario();
            dniComboBox.SelectedIndex= 0;
            verClave = false;
        }

        private void Frm_Nuevo_Usuario_Administrador_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(correoTextBox, "El correo se genera automaticamente al validar el registro.");
            toolTip1.SetToolTip(claveTextBox, "La contraseña se genera automaticamente al validar el registro.");
        }

        private void crearBtn_Click(object sender, EventArgs e)
        {
            if (validarCampos() == 4)
            {
                if (crearBtn.Text == "crear")
                {
                    Frm_Validando_Datos frmValidandoDatos = new Frm_Validando_Datos();
                    crearBtn.Text = "procesando...";
                    frmValidandoDatos.ShowDialog();
                    crearBtn.Text = "validar";
                    correoTextBox.Text = Controlador_GestionBiblioteca.CrearCorreoAdministrador(usuarioRegistro.Nombre, usuarioRegistro.Apellidos);
                    claveTextBox.Text = Controlador_GestionBiblioteca.GenerarContrasenaAleatoria(); 
                }
                else if (crearBtn.Text == "validar")
                {
                    usuarioRegistro.IdUsuario = Controlador_GestionBiblioteca.GenerarIdAdministrador();
                    usuarioRegistro.Correo = correoTextBox.Text;
                    usuarioRegistro.Contrasenia = correoTextBox.Text;
                    usuarioRegistro.Administrador = true;

                    if (Controlador_GestionUsuario.InsertarUsuario(usuarioRegistro))
                    {
                        LimpiarContenidoTextBox();
                        crearBtn.Text = "creado";
                        DialogResult res = MessageBox.Show("¿Quieres registrar otro usuario?", "Confirmar crear otro registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (res == DialogResult.OK)
                        {
                            crearBtn.Text = "crear";
                        }
                        else
                        {
                            this.Close();
                        }
                    }   
                }
            }
            else
            {
                MessageBox.Show("Deben estar todos los campos cumplimentados\npara poder continuar.", "Error validacion",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private int validarCampos()
        {
            int contCamposCorrectos = 0;

            if (nombreTextBox.Text == string.Empty || string.IsNullOrWhiteSpace(nombreTextBox.Text))
            { MostrarError(nombrePanel, "El campo nombre es requerido"); }
            else { usuarioRegistro.Nombre = nombreTextBox.Text; contCamposCorrectos++; QuitarError(nombrePanel); }

            if (apellidosTextBox.Text == string.Empty || string.IsNullOrWhiteSpace(apellidosTextBox.Text))
            { MostrarError(apellidoPanel, "El campo apellido es requerido"); }
            else { usuarioRegistro.Apellidos = apellidosTextBox.Text; contCamposCorrectos++; QuitarError(apellidoPanel); }

            if (dniComboBox.SelectedItem != null)
            {
                bool correcto;

                String valorSeleccionado = dniComboBox.SelectedItem.ToString();
                if (valorSeleccionado == "DNI")
                { correcto = Controlador_ComprobacionesUsuarios.comprobarDni(dniTextBox.Text.ToUpper()); }
                else { correcto = Controlador_ComprobacionesUsuarios.comprobarNie(dniTextBox.Text.ToUpper()); }

                if (!correcto)
                { MostrarError(dniPanel, "El campo del dni o nie es requerido"); }
                else { usuarioRegistro.Dni = dniTextBox.Text; contCamposCorrectos++; QuitarError(dniPanel); }
            }

            if (!Controlador_ComprobacionesUsuarios.comprobarTelefono(telefonoTextBox.Text))
            { MostrarError(telefonoPanel, "El campo del telefono es requerido"); }
            else { usuarioRegistro.Telefono = int.Parse(telefonoTextBox.Text); contCamposCorrectos++; QuitarError(telefonoPanel); }

            return contCamposCorrectos;
        }
        private void MostrarError(Panel panel, string mensajeError)
        {
            Icon iconoPersonalizado = Icon.FromHandle(Properties.Resources.error_icon.GetHicon());
            errorProvider1.Icon = iconoPersonalizado;
            errorProvider1.SetIconPadding(panel, -30);
            errorProvider1.SetIconAlignment(panel, ErrorIconAlignment.MiddleRight);
            errorProvider1.SetError(panel, mensajeError);
        }

        private void QuitarError(Panel panel)
        {
            errorProvider1.SetError(panel, "");
        }

        private void LimpiarContenidoTextBox()
        {
            foreach (Control control in Controls)
            {
                if (control is Panel panel)
                {
                    foreach (Control c in panel.Controls)
                    {
                        if (c is TextBox tb)
                        {
                            tb.Text = string.Empty;
                        }
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!verClave)
            {
                claveTextBox.UseSystemPasswordChar = false;
                pictureBox2.Image = Properties.Resources.visibility_FILL0_wght400_GRAD0_opsz241;
                verClave = true;
            }
            else
            {
                claveTextBox.UseSystemPasswordChar = true;
                pictureBox2.Image = Properties.Resources.visibility_off_FILL0_wght400_GRAD0_opsz24;
                verClave = false;
            }
        }
    }
}
