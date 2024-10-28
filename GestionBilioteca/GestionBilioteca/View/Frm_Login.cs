using GestionBilioteca.Class;
using GestionBilioteca.Controller;
using GestionBilioteca.View;
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

namespace GestionBilioteca
{
    public partial class Frm_Login : Form
    {
        private bool verClave;
        public static Frm_Registro_Usuario frm_Registro_usuario = new Frm_Registro_Usuario();
        public Frm_Login()
        {
            InitializeComponent();
            verClave = false;
        }
        private void Frm_Login_Load(object sender, EventArgs e)
        {
            cargarDatos(); 
            
            Console.WriteLine("\n***** LISTA DE USUARIOS CARGADOS");
            Usuario.usuarios.ForEach(u => { Console.WriteLine(u.ToString()); });
        }

        private void cargarDatos()
        {
            Console.WriteLine("\n***** EJECUTANDO CARGAR USUARIOS");

            Usuario.usuarios = Controlador_GestionUsuario.ObtenerUsuariosDesdeFuenteDatos();
            if (Usuario.usuarios.Count == 0)
            {
                // Usuario.usuarios = Controlador_GestionarUsuarios.LeerDatosUsuarios();
                Console.WriteLine("***** LISTA VACIA: CARGANDO USUARIOS POR DEFECTO");
                Controlador_GestionUsuario.cargarUsuariosPorDefecto();

                Usuario.usuarios.ForEach(usuario => Controlador_GestionUsuario.InsertarUsuario(usuario));
                // Controlador_GestionarUsuarios.escribirDatosUsuarios();
            }
        }

        private void entrarBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("\n***** EJECUTANDO VALIDAR DATOS");

            String correo = correoTextBox.Text;
            String clave = claveTextBox.Text;

            if (!(String.IsNullOrEmpty(correo)) && !(String.IsNullOrEmpty(clave)))
            {
                if (Controlador_GestionSesion.IniciarSesion(correo, clave, frm_Registro_usuario))
                {
                    if (Sesion.usuarioSesion.Administrador)
                    {
                        Console.WriteLine("***** USUARIO: " + Sesion.usuarioSesion.Nombre + " ES USUARIO ADMINISTRADOR.");

                        Frm_Principal_Administrador frm_principal_administrador = new Frm_Principal_Administrador();
                        frm_principal_administrador.Show();
                        LimpiarContenidoTextBox();
                    }
                    else
                    {
                        Console.WriteLine("\t" + Sesion.usuarioSesion.Nombre + " NO ES USUARIO ADMINISTRADOR.");
                        /*
                         * Seleccionar los datos de los prestamos:
                         * Sesion.PrestamosUsuarioEnLinea = Controlados.GestionPrestamos.SeleccionarPrestamosUsuarioID(Sesion.usuarioSesion.IdUsuario)
                        */
                        Frm_Principal_Usuario frm_principal_usuario = new Frm_Principal_Usuario();
                        frm_principal_usuario.Show();
                        LimpiarContenidoTextBox();
                    }
                }
                else
                {
                    LimpiarContenidoTextBox();
                }
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

        private void registroBtn_Click(object sender, EventArgs e)
        {
            Frm_Registro_Usuario frmRegistroUsuario = new Frm_Registro_Usuario();
            frmRegistroUsuario.FormClosed += FrmRegistroUsuario_FormClosed;
            frmRegistroUsuario.Show();
        }

        private void FrmRegistroUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("\n***** EL FORMULARIO REGISTRO SE HA CERRADO");
            this.Refresh();
            Frm_Login_Load(this, EventArgs.Empty);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!verClave)
            {
                claveTextBox.UseSystemPasswordChar = false;
                pictureBox1.Image = Properties.Resources.visibility_FILL0_wght400_GRAD0_opsz241;
                verClave = true;
            }
            else
            {
                claveTextBox.UseSystemPasswordChar = true;
                pictureBox1.Image = Properties.Resources.visibility_off_FILL0_wght400_GRAD0_opsz24;
                verClave = false;
            }
        }
    }
}
