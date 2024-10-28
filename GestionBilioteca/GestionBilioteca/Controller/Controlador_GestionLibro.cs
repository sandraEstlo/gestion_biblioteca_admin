using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionBilioteca.Class;
using System.Text.Json;

namespace GestionBilioteca.Controller
{
    public class Controlador_GestionLibro
    {
        public static List<Libro> ObtenerLibrosDesdeFuenteDatos()
        {
            Console.WriteLine("\n***** EJECUTAR OBTENER DATOS DESDE LA TABLA LIBROS");
            List<Libro> libros = new List<Libro>();

            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();

            string query = "SELECT * FROM Libro";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Libro libro = new Libro
                    {
                        IdLibro = reader["IdLibro"].ToString(),
                        Titulo = reader["Titulo"].ToString(),
                        Autor = reader["Autor"].ToString(),
                        Categoria = (int)reader["Categoria"],
                        FechaPublicacion = (DateTime)reader["FechaPublicacion"],
                        Isbn = (long)reader["Isbn"],
                        Descripcion = reader["Descripcion"].ToString(),
                        Ejemplares = (int)reader["Ejemplares"],
                        Disponibles = (int)reader["Disponibles"],
                        Imagen = reader["Imagen"].ToString()
                    };
                    libros.Add(libro);
                };

                return libros;
            }
        }

        public static List<Libro> ObtenerListaLibrosBusqueda(string palabraClave)
        {
            Console.WriteLine("\n***** EJECUTAR OBTENER DATOS DESDE LA TABLA LIBROS FILTRADOS");
            List<Libro> libros = new List<Libro>();
            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();

            string query = "SELECT * FROM Libro " +
                                "WHERE IdLibro LIKE '%' + @PalabraClave + '%'" +
                                "OR Titulo LIKE '%' + @PalabraClave + '%'" +
                                "OR Autor LIKE '%' + @PalabraClave + '%'" +
                                "OR CONVERT(VARCHAR(20), Isbn) LIKE '%' + @PalabraClave + '%'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("@PalabraClave", palabraClave);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Libro libro = new Libro
                    {
                        IdLibro = reader["IdLibro"].ToString(),
                        Titulo = reader["Titulo"].ToString(),
                        Autor = reader["Autor"].ToString(),
                        Categoria = (int)reader["Categoria"],
                        FechaPublicacion = (DateTime)reader["FechaPublicacion"],
                        Isbn = (long)reader["Isbn"],
                        Descripcion = reader["Descripcion"].ToString(),
                        Ejemplares = (int)reader["Ejemplares"],
                        Disponibles = (int)reader["Disponibles"],
                        Imagen = reader["Imagen"].ToString()
                    };
                    libros.Add(libro);
                };
                return libros;
            }
        }

        public static void InsertarLibro(Libro libro)
        {
            Console.WriteLine("\n***** EJECUTAR INSERTAR LIBRO");
            try
            {
                string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();

                string query = "INSERT INTO Libro (IdLibro, Titulo, Autor, Categoria, FechaPublicacion, Isbn, Descripcion, Ejemplares, Disponibles, Imagen) " +
                                       "VALUES (@IdLibro, @Titulo, @Autor, @Categoria, @FechaPublicacion, @Isbn, @Descripcion, @Ejemplares, @Disponibles, @Imagen)"; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdLibro", libro.IdLibro);
                    command.Parameters.AddWithValue("@Titulo", libro.Titulo);
                    command.Parameters.AddWithValue("@Autor", libro.Autor);
                    command.Parameters.AddWithValue("@Categoria", libro.Categoria);
                    command.Parameters.AddWithValue("@FechaPublicacion", libro.FechaPublicacion);
                    command.Parameters.AddWithValue("@Isbn", libro.Isbn);
                    command.Parameters.AddWithValue("@Descripcion", libro.Descripcion);
                    command.Parameters.AddWithValue("@Ejemplares", libro.Ejemplares);
                    command.Parameters.AddWithValue("@Disponibles", libro.Ejemplares);
                    command.Parameters.AddWithValue("@Imagen", (libro.Imagen != null) ? libro.Imagen : ""); // Usar DBNull.Value si el valor es null

                    int registrosAfectados = command.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        Libro.libros.Add(libro);
                        MessageBox.Show("Se inserto correctamente el registro", "Registro insertado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Console.WriteLine($"Se insertó correctamente el registro. Registros afectados: {registrosAfectados}");
                    }
                    else
                    {
                        Console.WriteLine($"Error al insertar el registro: {registrosAfectados}");
                        MessageBox.Show("Error al insertar el registro", "Error registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error al insertar los registros: {ex.Message}");
            }
        }

        public static bool eliminarLibro(string idLibro)
        {
            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();
            string query = "DELETE FROM Libro WHERE idLibro = @IdLibro";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdLibro", idLibro); // Asignar el valor del parámetro
                connection.Open();

                int cant = command.ExecuteNonQuery();
                return cant > 0;
            }
        }

        public static Libro buscarLibroBBDDId(string idLibro)
        {
            Libro libro;

            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();
            string query = "SELECT * FROM Libro WHERE IdLibro = @IdLibro";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdLibro", idLibro);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                reader.Read();
                libro = new Libro
                {
                    IdLibro = reader["IdLibro"].ToString(),
                    Titulo = reader["Titulo"].ToString(),
                    Autor = reader["Autor"].ToString(),
                    Categoria = (int)reader["Categoria"],
                    FechaPublicacion = (DateTime)reader["FechaPublicacion"],
                    Isbn = (long)reader["Isbn"],
                    Descripcion = reader["Descripcion"].ToString(),
                    Ejemplares = (int)reader["Ejemplares"],
                    Disponibles = (int)reader["Disponibles"],
                    Imagen = reader["Imagen"].ToString()
                };
            }

            return libro;
        }

        public static void modificarDatosLibro(string nombreColumna, object newValue, object primaryKeyValue)
        {
            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();
            string updateQuery = $"UPDATE Libro SET {nombreColumna} = @newValue WHERE IdLibro = @primaryKeyValue";

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

        public static Libro SeleccionarId(String id)
        {
            return Libro.libros
                .Where(l => l.IdLibro == id)
                .Select(l => (Libro)l)
                .FirstOrDefault();
        }

        public static bool modificarLibroLista(Libro sinModificar, Libro modificado)
        {
            if ((sinModificar != null && modificado != null) && sinModificar.IdLibro == modificado.IdLibro)
            {
                Libro.libros.Remove(sinModificar);
                Libro.libros.Add(modificado);

                return true;
            }

            return false;
        }
        public static void escribirArchivoLibros()
        {
            try
            {
                string jsonText = JsonSerializer.Serialize(Libro.libros, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("libros.json", jsonText);
                Console.WriteLine("Libros guardados correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir el archivo: {ex.Message}");
            }
        }
        public static List<Libro> LeerArchivoLibros()
        {
            List<Libro> listaLibro = new List<Libro>();
            try
            {
                if (File.Exists("libros.json"))
                {
                    string jsonString = File.ReadAllText("libros.json");
                    listaLibro = JsonSerializer.Deserialize<List<Libro>>(jsonString);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"El archivo libros.json no existe.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
            }

            return listaLibro;
        }

        public static bool EsNumericUpDownCero(int numero)
        {
            return !(numero== 0);
        }
        public static bool EsFechaAnterior(DateTime dt)
        {
            return (dt < DateTime.Now);
        }

        public static bool comprobarIsbn(String isbn)
        {
            return (isbn.Length == 13 && long.TryParse(isbn, out _));
        }
    }
}
