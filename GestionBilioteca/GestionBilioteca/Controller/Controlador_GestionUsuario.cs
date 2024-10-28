using GestionBilioteca.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBilioteca.Controller
{
    public static class Controlador_GestionUsuario
    {
        public static void cargarUsuariosPorDefecto()
        {
            // Variables
            int n_usuarios = 4, telefono = 0, cont=0;
            String id = "", nombre = "", apellido = "", dni = "", correo = "", clave = "", imagen = "";

            // Array de datos por atributo
            String[] nombres = { "Juan", "Maria", "Pedro", "Ana" };
            String[] apellidos = { "García López", "Rodríguez Martinez", "Sanchez Gómez", "Martín Fernández" };
            String[] dnis = { "12345678A", "98765432B", "87654321C", "76543210D" };
            String[] correros = { "juan.Garcia@gmail.com", "maria.Rodriguez@gmail.com", "pedro.Sanchez@admin.letras.com", "ana.Martin@admin.letras.com" };
            String[] claves = { "1234", "1234", "1234", "1234" };
            int[] telefonos = { 654321987, 678901234, 123456789, 987654321 };
            String[] imagenes = { @"..\..\Resources\persona_1_fondo_negro.png", @"..\..\Resources\persona_2_fondo_negro.png" };

            for (int i = 0; i < n_usuarios; i++) // For para crear los usuarios
            {
                Usuario usuarioNuevo;

                nombre = nombres[i];
                apellido = apellidos[i];
                dni = dnis[i];
                correo = correros[i];
                clave = claves[i];
                telefono = telefonos[i];
                
                if (i < 2) // Si i es menor que 2: se crean usuarios comunes
                {
                    imagen = imagenes[cont];
                    id = Controlador_GestionBiblioteca.GenerarIdComun();
                    int numTarjeta = Controlador_GestionBiblioteca.GenerarCodigoTarjeta();
                    usuarioNuevo = new Usuario(id, nombre, apellido, dni, correo, clave, telefono, numTarjeta, false, imagen);
                    cont++;
                }
                else // Si no: se crean usuarios administradores
                {
                    id = Controlador_GestionBiblioteca.GenerarIdAdministrador();
                    usuarioNuevo = new Usuario(id, nombre, apellido, dni, correo, clave, telefono, true);
                }
                Usuario.usuarios.Add(usuarioNuevo);
            }
        }

        public static List<Usuario> ObtenerUsuariosDesdeFuenteDatos()
        {
            Console.WriteLine("\n***** EJECUTAR OBTENER DATOS DESDE LA TABLA USUARIOS");
            List<Usuario> usuarios = new List<Usuario>();

            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();

            string query = "SELECT * FROM Usuario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        IdUsuario = reader["IdUsuario"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Apellidos = reader["Apellidos"].ToString(),
                        Dni = reader["Dni"].ToString(),
                        Correo = reader["Correo"].ToString(),
                        Contrasenia = reader["Contrasenia"].ToString(),
                        Telefono = (int)reader["Telefono"],
                        Administrador = (bool)reader["Administrador"],
                    };

                    if (!usuario.Administrador)
                    {
                        usuario.Imagen = reader["Imagen"].ToString();
                        usuario.NumTarjeta = (int)reader["NumTarjeta"];
                    }
     
                    usuarios.Add(usuario);
                };

                return usuarios;
            }
        }

        public static List<Usuario> ObtenerListaUsuariosBusqueda(string palabraClave)
        {
            Console.WriteLine("\n***** EJECUTAR OBTENER DATOS DESDE LA TABLA FILTRADAS POR BUSQUEDA");
            List<Usuario> usuarios = new List<Usuario>();

            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();

            string query = "SELECT * FROM Usuario " +
                                "WHERE IdUsuario LIKE '%' + @PalabraClave + '%'" +
                                "OR Nombre LIKE '%' + @PalabraClave + '%'" +
                                "OR Apellidos LIKE '%' + @PalabraClave + '%'" +
                                "OR Dni LIKE '%' + @PalabraClave + '%'" +
                                "OR Correo LIKE '%' + @PalabraClave + '%'" +
                                "OR CONVERT(VARCHAR(20), telefono) LIKE '%' + @PalabraClave + '%'" +
                                "OR CONVERT(VARCHAR(20), NumTarjeta) LIKE '%' + @PalabraClave + '%'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("@PalabraClave", palabraClave);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        IdUsuario = reader["IdUsuario"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Apellidos = reader["Apellidos"].ToString(),
                        Dni = reader["Dni"].ToString(),
                        Correo = reader["Correo"].ToString(),
                        Contrasenia = reader["Contrasenia"].ToString(),
                        Telefono = (int)reader["Telefono"],
                        Administrador = (bool)reader["Administrador"],
                    };

                    if (!usuario.Administrador)
                    {
                        usuario.Imagen = reader["Imagen"].ToString();
                        usuario.NumTarjeta = (int)reader["NumTarjeta"];
                    }

                    usuarios.Add(usuario);
                };

                return usuarios;
            }
        }
        public static Usuario BuscarUsuarioBBDDId(string idUsuario)
        {
            Usuario usuario;

            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();
            string query = "SELECT * FROM Usuario WHERE IdUsuario = @IdUsuario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();
                usuario = new Usuario
                {
                    IdUsuario = reader["IdUsuario"].ToString(),
                    Nombre = reader["Nombre"].ToString(),
                    Apellidos = reader["Apellidos"].ToString(),
                    Dni = reader["Dni"].ToString(),
                    Correo = reader["Correo"].ToString(),
                    Contrasenia = reader["Contrasenia"].ToString(),
                    Telefono = (int)reader["Telefono"],
                    Administrador = (bool)reader["Administrador"],
                };

                if (!usuario.Administrador)
                {
                    usuario.Imagen = reader["Imagen"].ToString();
                    usuario.NumTarjeta = (int)reader["NumTarjeta"];
                }

                connection.Close();
            } 
            return usuario;
        }
        public static bool InsertarUsuario(Usuario usuario)
        {
            Console.WriteLine("\n***** EJECUTAR INSERTAR USUARIO");
            try
            {
                string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();

                string query = "INSERT INTO Usuario (IdUsuario, Nombre, Apellidos, Dni, Correo, Contrasenia, Telefono, NumTarjeta, Administrador, Imagen) " +
                                       "VALUES (@IdUsuario, @Nombre, @Apellidos, @Dni, @Correo, @Contrasenia, @Telefono, @NumTarjeta, @Administrador, @Imagen)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
                    command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
                    command.Parameters.AddWithValue("@Dni", usuario.Dni);
                    command.Parameters.AddWithValue("@Correo", usuario.Correo);
                    command.Parameters.AddWithValue("@Contrasenia", usuario.Contrasenia);
                    command.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                    command.Parameters.AddWithValue("@NumTarjeta", (!usuario.Administrador) ? usuario.NumTarjeta : 0);
                    command.Parameters.AddWithValue("@Administrador", usuario.Administrador);
                    command.Parameters.AddWithValue("@Imagen", (usuario.Imagen != null) ? usuario.Imagen : "");

                    int registrosAfectados = command.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        Usuario.usuarios.Add(usuario);
                        Console.WriteLine($"Se insertó correctamente el registro. Registros afectados: {registrosAfectados}");
                        MessageBox.Show("Usuario registrado", "Confirmación creación registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar registro", "Error registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    connection.Close();
                    return registrosAfectados > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar los registros: {ex.Message}");
            }
            return false;
        }

        public static bool EliminarUsuario(string idUsuario)
        {
            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();
            string query = "DELETE FROM Usuario WHERE IdUsuario = @IdUsuario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario); // Asignar el valor del parámetro
                connection.Open();

                int cant = command.ExecuteNonQuery();
                return cant > 0;
            }
        }

        

        public static void ModificarDatos(string nombreColumna, object newValue, object primaryKeyValue)
        {
            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();
            string updateQuery = $"UPDATE Usuario SET {nombreColumna} = @newValue WHERE idUsuario = @primaryKeyValue";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@newValue", newValue);
                    command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Los datos se actualizaron correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar los datos en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar los datos en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public static Usuario SeleccionarId(String id)
        {
            return  Usuario.usuarios
                .Where(u => u.IdUsuario == id)
                .Select(u => (Usuario)u)
                .FirstOrDefault();
        }

        public static bool ModificarUsuarioLista(Usuario usuarioSinModificar, Usuario usuarioModificado)
        {
            if ((usuarioSinModificar != null && usuarioModificado!=null) && usuarioSinModificar.IdUsuario == usuarioModificado.IdUsuario)
            {
                Usuario.usuarios.Remove(usuarioSinModificar);
                Usuario.usuarios.Remove(usuarioModificado);

                return true;
            }
            return false;
        }

        public static String nombreApellidoUsuario(string idUsuario)
        {
            Usuario usuario = SeleccionarId(idUsuario);
            StringBuilder sb = new StringBuilder();
            sb.Append(usuario.Nombre).Append(" ").Append(usuario.Apellidos);
            return sb.ToString();
        }
    }
}
