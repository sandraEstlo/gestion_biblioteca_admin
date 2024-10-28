using GestionBilioteca.Class;
using GestionBilioteca.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace GestionBilioteca.View
{
    public partial class Frm_Registro_Usuario : Form
    {
        private Usuario usuarioRegistro = new Usuario();
        private string rutaImagenOrigen = string.Empty;
        private ErrorProvider errorProvider = new ErrorProvider();

        bool verClave1;
        bool verClave2;

        public Frm_Registro_Usuario()
        {
            InitializeComponent();
        }

        private void Frm_Registro_Usuario_Load(object sender, EventArgs e)
        {
            dniComboBox.SelectedIndex = 0;
            verClave1 = false;
            verClave2 = false;
        }

        private int ValidarCampos()
        {
            int contCamposCorrectos = 0;

            if (nombreTextBox.Text == string.Empty || string.IsNullOrWhiteSpace(nombreTextBox.Text))
                 { MostrarError(nombrePanel, "El campo nombre es requerido"); }
            else { usuarioRegistro.Nombre = nombreTextBox.Text;  contCamposCorrectos++; QuitarError(nombrePanel); }

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

            if (!Controlador_ComprobacionesUsuarios.comprobarCorreo(correoTextBox.Text)) 
                 { MostrarError(correoPanel, "El campo del correo es requerido"); }
            else { usuarioRegistro.Correo = correoTextBox.Text; contCamposCorrectos++; QuitarError(correoPanel); }

            if (!Controlador_ComprobacionesUsuarios.ComprobarClaves(claveTextBox.Text, confiClaveTextBox.Text) )
                 { MostrarError(clave1Panel, "El campo clave es requerido");
                   MostrarError(clave2Panel, "Los dos campos deven ser iguales"); }
            else { usuarioRegistro.Contrasenia = claveTextBox.Text; contCamposCorrectos++; contCamposCorrectos++;
                   QuitarError(clave1Panel); QuitarError(clave2Panel); }
            
            return contCamposCorrectos;
        }

        private void MostrarError(Panel panel, string mensajeError)
        {
            Icon iconoPersonalizado = Icon.FromHandle(Properties.Resources.error_icon.GetHicon());
            errorProvider.Icon = iconoPersonalizado;
            errorProvider.SetIconPadding(panel, -30);
            errorProvider.SetIconAlignment(panel, ErrorIconAlignment.MiddleRight);
            errorProvider.SetError(panel, mensajeError);
        }

        private void QuitarError(Panel panel)
        {
            errorProvider.SetError(panel, "");
        }

        private void avatarPictureBox_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"***** EJECUTANDO PICTURE BOX ONCLICK");
            var rutaArchivo = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image files (*.bmp; *.gif; *.jpg; *.png)|*.bmp; *.gif; *.jpg; *.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivo = openFileDialog.FileName;
                    avatarPictureBox.Image = Image.FromFile(rutaArchivo);
                    rutaImagenOrigen = rutaArchivo; 
                }
            }
        }

        private void crearBtn_Click(object sender, EventArgs e)
        {
            int camposRequeridos = Controls.OfType<Panel>().Count() - 1;
            int camposCorrectos = ValidarCampos();

            Console.WriteLine($"***** RESULTADO: CAMPOS REQUERIDOS {camposRequeridos} | CAMPOS CORRECTOS {camposCorrectos}");

            if (camposCorrectos == (camposRequeridos))
            {
                usuarioRegistro.IdUsuario = Controlador_GestionBiblioteca.GenerarIdComun();
                usuarioRegistro.NumTarjeta = Controlador_GestionBiblioteca.GenerarCodigoTarjeta();

                // Copiar el archivo seleccionado por el usuario en la carpeta Resource
                if (rutaImagenOrigen != string.Empty)
                {
                    string nombreArchivo = $"{usuarioRegistro.NumTarjeta}{usuarioRegistro.Nombre}.png";
                    string rutaImagenDestino = Path.Combine("..", "..", "Resources", nombreArchivo);

                    try
                    {
                        File.Copy(rutaImagenOrigen, rutaImagenDestino, true);
                        Console.WriteLine($"Imagen copiada exitosamente a la carpeta Resources con la ruta relativa: {rutaImagenDestino}");

                        usuarioRegistro.Imagen = rutaImagenDestino;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al copiar la imagen: {ex.Message}");
                    }
                }

                usuarioRegistro.Administrador = false;
                Console.WriteLine($"Datos usuarios: " + usuarioRegistro.ToStringUsuario());
                _= Controlador_GestionUsuario.InsertarUsuario(usuarioRegistro);
                LimpiarContenidoTextBox();
                this.Close();
            }
            else
            {
                MessageBox.Show("Deve completar todos los campos requeridos para efectuar el registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            if (!verClave1)
            {
                claveTextBox.UseSystemPasswordChar = false;
                pictureBox2.Image = Properties.Resources.visibility_FILL0_wght400_GRAD0_opsz241;
                verClave1 = true;
            }
            else
            {
                claveTextBox.UseSystemPasswordChar = true;
                pictureBox2.Image = Properties.Resources.visibility_off_FILL0_wght400_GRAD0_opsz24;
                verClave1 = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!verClave2)
            {
                confiClaveTextBox.UseSystemPasswordChar = false;
                pictureBox3.Image = Properties.Resources.visibility_FILL0_wght400_GRAD0_opsz241;
                verClave2 = true;
            }
            else
            {
                confiClaveTextBox.UseSystemPasswordChar = true;
                pictureBox3.Image = Properties.Resources.visibility_off_FILL0_wght400_GRAD0_opsz24;
                verClave2 = false;
            }
        }
    }
}
