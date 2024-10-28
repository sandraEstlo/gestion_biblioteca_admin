using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBilioteca.Class
{
    [Serializable]
    public class Usuario
    {
        public static List<Usuario> usuarios = new List<Usuario>();

        private String idUsuario;
        private String nombre;
        private String apellidos;
        private String dni;
        private String correo;
        private String contrasenia;
        private int telefono;
        private int numTarjeta;
        private bool administrador;
        private string imagen;

        // Constructor 0: Sin argumentos
        public Usuario() {  }

        // Constructor 1: Usuario Administrador
        public Usuario(string idUsuario, string nombre, string apellidos, string dni, string correo, string contrasenia, int telefono, bool administrador)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Apellidos = apellidos;
            Dni = dni;
            Correo = correo;
            Contrasenia = contrasenia;
            Telefono = telefono;
            Administrador = administrador;
        }

        // Constructor 2: Usuario con imagen
        public Usuario(string idUsuario, string nombre, string apellidos, string dni, string correo, string contrasenia, int telefono, int numTarjeta, bool administrador, string imagen)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.correo = correo;
            this.contrasenia = contrasenia;
            this.telefono = telefono;
            this.numTarjeta = numTarjeta;
            this.administrador = administrador;
            this.imagen = imagen;
        }

        // Constructor 3: Sin imagen
        public Usuario(string idUsuario, string nombre, string apellidos, string dni, string correo, string contrasenia, int telefono, int numTarjeta, bool administrador)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.correo = correo;
            this.contrasenia = contrasenia;
            this.telefono = telefono;
            this.numTarjeta = numTarjeta;
            this.administrador = administrador;
        }

        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public int NumTarjeta { get => numTarjeta; set => numTarjeta = value; }
        public bool Administrador { get => administrador; set => administrador = value; }
        public string Imagen { get => imagen; set => imagen = value; }

        // String Usuarios
        public string ToStringUsuario()
        {
            return $"{IdUsuario} {Nombre} {Apellidos} {Dni} {Correo} {Contrasenia} {Telefono} {NumTarjeta} {Administrador} {Imagen}";
        }

        // String Administrador
        public string ToStringAdministrador()
        {
            return $"{IdUsuario} {Nombre} {Apellidos} {Dni} {Correo} {Contrasenia} {Telefono} {Administrador}";
        }

        public override string ToString()
        {
            return $"{IdUsuario,-6} {Nombre,-15} {Apellidos,-18} {dni,-9} {correo,-30}";
        }
    }
}
