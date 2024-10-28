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

namespace GestionBilioteca.View
{
    public partial class Frm_Nuevo_Prestamo_Administrador : Form
    {
        public static Libro libroSeleccionado;
        private ErrorProvider errorProvider = new ErrorProvider();
        private Prestamo prestamoCreado;

        public Frm_Nuevo_Prestamo_Administrador()
        {
            InitializeComponent();
        }

        private void Frm_Nuevo_Prestamo_Administrador_Load(object sender, EventArgs e)
        {
            LimpiarContenidoTextBox();
            prestamoCreado = new Prestamo();
        }

        private void BusquedaUsuariobutton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("***** EJECUTANDO BUSCAR USUARIOS");

            if (String.IsNullOrEmpty(busquedaUsuarioTextBox.Text))
            {
                DialogResult result = MessageBox.Show("¿Los datos del usuario no pueden estar vacios.\n¿Quieres visualizar la lista de usuarios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Console.WriteLine("\tEl campo esta vacío. Se pasa lista completa.");
                    codUsuarioTextBox.Text = "";
                    Controlador_GestionPrestamos.listaUsuariosFiltradaBusqueda = Controlador_GestionUsuario.ObtenerUsuariosDesdeFuenteDatos();
                }
                else { codUsuarioTextBox.Text = ""; return; }
            }
            else
            {
                Controlador_GestionPrestamos.listaUsuariosFiltradaBusqueda = Controlador_GestionUsuario.ObtenerListaUsuariosBusqueda(busquedaUsuarioTextBox.Text);
                Console.WriteLine($"\tNumero de coincidencias: {Controlador_GestionPrestamos.listaUsuariosFiltradaBusqueda.Count}");

                if (Controlador_GestionPrestamos.listaUsuariosFiltradaBusqueda.Count==1)
                {
                    Controlador_GestionPrestamos.usuarioSeleccionadoBusqueda = Controlador_GestionPrestamos.listaUsuariosFiltradaBusqueda[0];
                    if (!Controlador_GestionPrestamos.usuarioSeleccionadoBusqueda.Administrador)
                    { codUsuarioTextBox.Text = Controlador_GestionPrestamos.usuarioSeleccionadoBusqueda.IdUsuario;
                    } else { MessageBox.Show("No se puede seleccionar un usuario administrador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } return;
                }
            }

            Frm_Listar_Busqueda_Usuarios frmListarUsuarioBusqueda = new Frm_Listar_Busqueda_Usuarios();
            frmListarUsuarioBusqueda.FormClosed += FrmListarUsuarioBusqueda_FormClosed;
            frmListarUsuarioBusqueda.Show();
        }
        private void busquedaLibroButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("***** EJECUTANDO BUSCAR LIBROS");
            Frm_Listar_Busqueda_Libros frmListarBusquedaLibros = new Frm_Listar_Busqueda_Libros();

            if (String.IsNullOrEmpty(libroBusquedaTextBox.Text))
            {
                DialogResult result = MessageBox.Show("¿Los datos del libro no pueden estar vacios.\n¿Quieres visualizar la lista de libros?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Console.WriteLine("\tEl campo esta vacío. Se pasa lista completa.");
                    codLibroTextBox.Text = "";
                    Controlador_GestionPrestamos.listaLibrosFiltradaBusqueda = Controlador_GestionLibro.ObtenerLibrosDesdeFuenteDatos();
                }
                else
                {
                    codLibroTextBox.Text = "";
                    return;
                }
            }
            else
            {
                Controlador_GestionPrestamos.listaLibrosFiltradaBusqueda = Controlador_GestionLibro.ObtenerListaLibrosBusqueda(libroBusquedaTextBox.Text);
                Console.WriteLine($"\tNumero de coincidencias: {Controlador_GestionPrestamos.listaLibrosFiltradaBusqueda.Count}");

                if (Controlador_GestionPrestamos.listaLibrosFiltradaBusqueda.Count == 1)
                {
                    Controlador_GestionPrestamos.libroSeleccionadoBusqueda = Controlador_GestionPrestamos.listaLibrosFiltradaBusqueda[0];
                    codLibroTextBox.Text = Controlador_GestionPrestamos.libroSeleccionadoBusqueda.IdLibro;
                    return;
                }
            }

            Frm_Listar_Busqueda_Libros frmBusquedaLibros = new Frm_Listar_Busqueda_Libros();
            frmBusquedaLibros.FormClosed += FrmBusquedaLibros_FormClosed;
            frmBusquedaLibros.Show();
        }

        private void FrmBusquedaLibros_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Controlador_GestionPrestamos.libroSeleccionadoBusqueda!=null)
            {
                codLibroTextBox.Text = Controlador_GestionPrestamos.libroSeleccionadoBusqueda.IdLibro;
            }
        }
        private void FrmListarUsuarioBusqueda_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Controlador_GestionPrestamos.usuarioSeleccionadoBusqueda!= null)
            {
                if (!Controlador_GestionPrestamos.usuarioSeleccionadoBusqueda.Administrador)
                {
                    codUsuarioTextBox.Text = Controlador_GestionPrestamos.usuarioSeleccionadoBusqueda.IdUsuario;
                }
                else
                {
                    MessageBox.Show("Error al insertar los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        } 
        private void crearBtn_Click(object sender, EventArgs e)
        {
            int camposCorrectos = validarCampos();
            string mensaje = "";

            if (camposCorrectos == 2)
            {
                if (Controlador_GestionPrestamos.libroSeleccionadoBusqueda.Disponibles > 0)
                {
                    int numRegistrosUsuario = Controlador_GestionPrestamos.seleccionarNumRegistrosUsuario(Controlador_GestionPrestamos.usuarioSeleccionadoBusqueda.IdUsuario);
                    if (numRegistrosUsuario < 3)
                    {
                        prestamoCreado.IdPrestamo = Controlador_GestionBiblioteca.generarCodigoPrestamo();
                        prestamoCreado.FechaPrestamo = fechaPrestamo.Value;
                        prestamoCreado.FechaDevolucion = prestamoCreado.FechaPrestamo.AddMonths(3);
                        prestamoCreado.Devuelto = false;

                        Controlador_GestionPrestamos.InsertarPrestamo(prestamoCreado, Controlador_GestionPrestamos.libroSeleccionadoBusqueda);
                        Console.WriteLine("**** PRESTAMO REGISTRADO: \n+++++ LISTA:");
                        Prestamo.prestamos.ForEach(p => Console.WriteLine(p.ToString()));
                        LimpiarContenidoTextBox();
                        return;
                    }
                    else { mensaje = "El usuario ya tiene 3 libros prestados."; }
                } else { mensaje = "El libro no se encuentra disponible."; }
            } else { mensaje = "No se ha podido efectuar el registro."; }

            MessageBox.Show(mensaje, "Error registro",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int validarCampos()
        {
            int contCamposCorrectos = 0;

            if (String.IsNullOrEmpty(codLibroTextBox.Text)) 
            { MostrarError(codLibroPanel, "El codigo libro no puede estar vacío.");
            } else { prestamoCreado.IdLibro = codLibroTextBox.Text; QuitarError(codLibroPanel); contCamposCorrectos++; }

            if (String.IsNullOrEmpty(codUsuarioTextBox.Text))
            { MostrarError(codUsuarioPanel, "El codigo libro no puede estar vacío.");
            } else { prestamoCreado.IdUsuario = codUsuarioTextBox.Text; QuitarError(codUsuarioPanel); contCamposCorrectos++; }

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
    }
}
