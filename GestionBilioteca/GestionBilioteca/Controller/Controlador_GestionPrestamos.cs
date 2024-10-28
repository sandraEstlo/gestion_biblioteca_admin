using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionBilioteca.Class;

namespace GestionBilioteca.Controller
{
    public class Controlador_GestionPrestamos
    {
        public static List<Usuario> listaUsuariosFiltradaBusqueda;
        public static Usuario usuarioSeleccionadoBusqueda;

        public static List<Libro> listaLibrosFiltradaBusqueda;
        public static Libro libroSeleccionadoBusqueda;

        public static List<Prestamo> ObtenerPrestamosDesdeFuenteDatos()
        {
            Console.WriteLine("\n***** EJECUTAR OBTENER DATOS DESDE LA TABLA PRESTAMOS");
            List<Prestamo> prestamos = new List<Prestamo>();

            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();
            string query = "SELECT * FROM Prestamo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Prestamo prestamo = new Prestamo()
                    {
                        IdPrestamo = reader["IdPrestamo"].ToString(),
                        IdLibro = reader["IdLibro"].ToString(),
                        IdUsuario = reader["IdUsuario"].ToString(),
                        FechaPrestamo = (DateTime)reader["FechaPrestamo"],
                        FechaDevolucion = (DateTime)reader["FechaDevolucion"],
                        Devuelto = (bool)reader["Devuelto"]
                    };

                    prestamos.Add(prestamo);
                }

                return prestamos;
            }
        }

        public static void InsertarPrestamo(Prestamo prestamo, Libro sinModificar)
        {
            Console.WriteLine("\n***** EJECUTAR INSERTAR PRESTAMO");
            try
            {
                string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();

                string query = "INSERT INTO Prestamo (IdPrestamo, IdLibro, IdUsuario, FechaPrestamo, FechaDevolucion, Devuelto) " +
                                       "VALUES (@IdPrestamo, @IdLibro, @IdUsuario, @FechaPrestamo, @FechaDevolucion, @Devuelto)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@IdPrestamo", prestamo.IdPrestamo);
                    command.Parameters.AddWithValue("@IdLibro", prestamo.IdLibro);
                    command.Parameters.AddWithValue("@IdUsuario", prestamo.IdUsuario);
                    command.Parameters.AddWithValue("@FechaPrestamo", prestamo.FechaPrestamo);
                    command.Parameters.AddWithValue("@FechaDevolucion", prestamo.FechaDevolucion);
                    command.Parameters.AddWithValue("@Devuelto", prestamo.Devuelto);

                    int registrosAfectados = command.ExecuteNonQuery();
                    Console.WriteLine($"Se insertó correctamente el registro. Registros afectados: {registrosAfectados}");

                    if (registrosAfectados>0)
                    {
                        String nombreColumna = "Disponibles";
                        object newValue = sinModificar.Disponibles - 1;
                        object primaryKeyValue = sinModificar.IdLibro;

                        
                        Controlador_GestionLibro.modificarDatosLibro(nombreColumna, newValue, primaryKeyValue);
                        Libro libro = Controlador_GestionLibro.buscarLibroBBDDId(primaryKeyValue.ToString());

                        Controlador_GestionLibro.modificarLibroLista(sinModificar,libro);
                        Prestamo.prestamos.Add(prestamo);

                        string icalContenido = GenerarEventoCalendario(libro.Titulo, prestamo.IdPrestamo, prestamo.FechaDevolucion);
                        File.WriteAllText($"prestamo{prestamo.IdPrestamo}.ics", icalContenido);
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar los registros: {ex.Message}");
                MessageBox.Show("Error al insertar el registro.");
            }
        }

        public static bool EliminarPrestamo(Prestamo prestamo)
        {
            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();
            string query = "DELETE FROM Prestamo WHERE IdPrestamo = @IdPrestamo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdPrestamo", prestamo.IdPrestamo);
                connection.Open();
                int cant = command.ExecuteNonQuery();

                if (cant > 0 && !prestamo.Devuelto)
                {
                    Libro sinModificar = Controlador_GestionLibro.buscarLibroBBDDId(prestamo.IdLibro);
                    Console.WriteLine($"LIBRO A MODIFICAR: {sinModificar}");

                    String nombreColumna = "Disponibles";
                    object newValue = (sinModificar.Disponibles) + 1;
                    object primaryKeyValue = prestamo.IdLibro;

                    Controlador_GestionLibro.modificarDatosLibro(nombreColumna, newValue, primaryKeyValue);
                    Libro libro = Controlador_GestionLibro.buscarLibroBBDDId(primaryKeyValue.ToString());

                    Controlador_GestionLibro.modificarLibroLista(sinModificar, libro);

                    ActualizarListaPrestamos(prestamo.IdPrestamo);
                }

                return cant > 0;
            }
        }

        public static void ModificarDatos(string nombreColumna, object newValue, object primaryKeyValue)
        {
            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();
            string updateQuery = $"UPDATE Prestamo SET {nombreColumna} = @NewValue WHERE IdPrestamo = @PrimaryKeyValue";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@NewValue", newValue);
                    command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        string mensaje = (rowsAffected > 0) ? "Registro cambiado" : "Error cambiar registro";
                        MessageBox.Show(mensaje);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar los datos en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public static void registrarDevolucion(Prestamo prestamo)
        {
            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();
            string updateQuery = $"UPDATE Prestamo SET FechaDevolucion = (SELECT CURRENT_TIMESTAMP), Devuelto = 'True' WHERE IdPrestamo = @IdPrestamo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@IdPrestamo", prestamo.IdPrestamo);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Libro sinModificar = Controlador_GestionLibro.buscarLibroBBDDId(prestamo.IdLibro);
                            Console.WriteLine($"LIBRO A MODIFICAR: {sinModificar}" );

                            String nombreColumna = "Disponibles";
                            object newValue = (sinModificar.Disponibles) + 1;
                            object primaryKeyValue = prestamo.IdLibro;

                            Controlador_GestionLibro.modificarDatosLibro(nombreColumna, newValue, primaryKeyValue);
                            Libro libro = Controlador_GestionLibro.buscarLibroBBDDId(primaryKeyValue.ToString());

                            Controlador_GestionLibro.modificarLibroLista(sinModificar, libro);

                            ActualizarListaPrestamos(prestamo.IdPrestamo);
                        }
                        string mensaje = (rowsAffected > 0) ? "Devolucion Tramitada" : "Error en tramitar devolucion";
                        MessageBox.Show(mensaje);

                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show("Error al actualizar la lista de préstamos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar los datos en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public static Prestamo BuscarPrestamoCodigo(string idPrestamo)
        {
            Console.WriteLine("\n***** EJECUTAR BUSCAR PRESTAMO POR ID");
            Prestamo prestamo = new Prestamo();
            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();
            string query = "SELECT * FROM Prestamo WHERE IdPrestamo = @IdPrestamo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdPrestamo", idPrestamo);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();
                    prestamo = new Prestamo()
                    {
                        IdPrestamo = reader["IdPrestamo"].ToString(),
                        IdLibro = reader["IdLibro"].ToString(),
                        IdUsuario = reader["IdUsuario"].ToString(),
                        FechaPrestamo = (DateTime)reader["FechaPrestamo"],
                        FechaDevolucion = (DateTime)reader["FechaDevolucion"],
                        Devuelto = (bool)reader["Devuelto"]
                    };

                    return prestamo;
                }
               
            }
        }

        /*
         * CREAR EVENTO CALENDARIO: 
         * El metodo crea un evento en el formato que utiliza google calendar para posteriormente
         * poder enviarselo al usuario y que pueda añadir un recordatorio a su calendario 
         */
        public static string GenerarEventoCalendario(string title, string description, DateTime dateEnd)
        {
            StringBuilder icalText = new StringBuilder();

            icalText.AppendLine(@"BEGIN:VCALENDAR");
            icalText.AppendLine("VERSION:2.0");
            icalText.AppendLine("METHOD:PUBLISH");
            icalText.AppendLine("BEGIN:VEVENT");
            icalText.AppendLine($"SUMMARY:DEVOLVER LIBRO: {title}");
            icalText.AppendLine($"DESCRIPTION:CODIGO RESTAMOS: {description}");
            icalText.AppendLine($"DTSTART:{dateEnd:yyyMMddTHHmmss}");
            icalText.AppendLine($"DTEND:{dateEnd:yyyMMddTHHmmss}");
            icalText.AppendLine("END:VEVENT");
            icalText.AppendLine("END:VCALENDAR");

            return icalText.ToString();
        }

        public static int seleccionarNumeroRegistrosUsuario(string idUsuario)
        {
            return Prestamo.prestamos.Select(p => p.IdUsuario == idUsuario).Count();
        }

        public static int seleccionarNumRegistrosUsuario(string idUsuario)
        {
            int numero = 0;
            Console.WriteLine("\n***** EJECUTAR BUSCAR PRESTAMO POR ID");
            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();
            string query = "SELECT COUNT(*) FROM Prestamo WHERE IdUsuario = @IdUsuario AND Devuelto = 'False'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Obtiene el valor del primer campo del primer registro
                            numero = reader.GetInt32(0);
                        }
                    }
                }
            }
            return numero;
        }

        public static void ActualizarListaPrestamos(string idPrestamo)
        {
            Console.WriteLine("***** EJECUTANDO MODIFICAR LISTA PRESTAMO");
            foreach (Prestamo prestamo in Prestamo.prestamos)
            {
                if (prestamo.IdPrestamo.Trim() == idPrestamo.Trim())
                {
                    prestamo.Devuelto = true;
                    prestamo.FechaPrestamo = DateTime.Now;
                }

                Console.WriteLine(prestamo);
            }
        }
    }
}
