using GestionBilioteca.Class;
using GestionBilioteca.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBilioteca.Controller
{
    public class Controlador_GestionSesion
    {
        
        public static bool IniciarSesion(String correo, String clave, Frm_Registro_Usuario formularioRegistro)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(correo);

                Usuario usuarioEnLista = Usuario.usuarios.FirstOrDefault(u => u.Correo == correo);

                if (usuarioEnLista!=null)
                {
                    if (usuarioEnLista.Contrasenia == clave)
                    {
                        Sesion.usuarioSesion = usuarioEnLista;
                        Console.WriteLine("\t++++ SE HA PODIDO INICIAR SESION: Se ha encontrado el usuario");
                        Console.WriteLine($"\tUSUARIO SESION: {Sesion.usuarioSesion.ToStringUsuario()}");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("La clave no es correcta", "Error correo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    Sesion.usuarioSesion = null;
                    Console.WriteLine("\t---- NO SE HA PODIDO INICIAR SESION: Usuario no encontrado");
                    DialogResult result = MessageBox.Show("Usuario no registrado. ¿Desea registrarse?", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Console.WriteLine("\t**** IR AL REGISTRO DE USUARIOS");
                        formularioRegistro.ShowDialog();
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("El correo electrónico ingresado no es válido.");
                MessageBox.Show("INTRODUZCA UN CORREO VALIDO PARA PODER CONTINUAR CON EL INICIO DE SESION.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public void CerrarSesion(Sesion sesion)
        {
            Sesion.usuarioSesion = null;
        }
        
    }
}
