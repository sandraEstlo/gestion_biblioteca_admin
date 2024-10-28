using GestionBilioteca.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBilioteca.Controller
{
    public class Controlador_GestionBiblioteca
    {
        public static List<Categoria> categorias = new List<Categoria>();
        public static string construirCadenaConexión()
        {
            Console.WriteLine("\n***** EJECUTANDO CONSTRUIR CADENA DE CONEXION");
            string databaseFileName = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\LETRAS.mdf"));
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename ={databaseFileName}; Integrated Security = True";

            Console.WriteLine("Cadena de conexión: " + connectionString);
            return connectionString;
        }
        public static int GenerarCodigoTarjeta() // Generar el Codigo de Tarjeta para los usuarios comunes
        {
            Random rand = new Random();
            int numTarjeta;

            // Obtener lista de numeros de tarjeta para no repetir datos mediante una expresion Lambda
            List<int> numerosTarjeta = Usuario.usuarios             // 1. Seccionar la lista de usuarios a recorrer
                .Where(u => !u.Administrador)                       // 2. Filtrar por tipo de usuario comun
                .Select(u => u.NumTarjeta)                          // 3. Seleccionar el atributo del numero de tarjeta
                .ToList();                                          // 4. Cnvertirlo en lista

            do
            {
                numTarjeta = rand.Next(100000000, 1000000000);      // Generar un numero aleatorio de tarjeta
            } while (numerosTarjeta.Contains(numTarjeta));          // Hasta que el numero de tarjeta no se encuentre en la lista

            return numTarjeta;
        }

        public static String GenerarIdComun()                       // Genear Id para usuarios comunes
        {
            int ultimoNumero = 0;

            if (Usuario.usuarios != null && Usuario.usuarios.Where(u => !u.Administrador).Any())
            {
                // Obtener el número máximo
                ultimoNumero = Usuario.usuarios                     // 1. Seleccionar la lista
                    .Where(u => !u.Administrador)                   // 2. Filtrar por tipo de usuario
                    .Max(u => int.Parse(u.IdUsuario.Substring(1))); // 3. Seleecionar el numero mayor del id
            }

            ultimoNumero++; // Incrementar el último número

            return $"C{ultimoNumero:D3}";
        }

        public static String GenerarIdAdministrador() // Genear Id para usuarios comunes
        {
            int ultimoNumero = 0;

            if (Usuario.usuarios != null && Usuario.usuarios.Where(u => u.Administrador).Any())
            {
                ultimoNumero = Usuario.usuarios
                    .Where(u => u.Administrador)
                    .Max(u => int.Parse(u.IdUsuario.Substring(1)));
            }

            ultimoNumero++;

            return $"A{ultimoNumero:D3}";
        }

        // Genera un codigo para el libro
        public static String generarCodigoLibro(int categoria, String titulo, String autor)
        {
            int codigo = categoria;
            String[] arrayNombre = autor.Replace(".", "").Split(' ');
            String nombre = ConstruirCadenaUltimosDos(arrayNombre).ToUpper().Substring(0, 3);

            titulo = titulo.Replace(" ", "");
            String tit = titulo.ToUpper().Substring(0, 3);

            Console.WriteLine($"***** CREAR CODIGO [{categoria}, {titulo}, {autor}]");
            Console.WriteLine($"\tCODIGO GENERADO: {categoria:D3}{nombre}{tit}");

            return $"{codigo:D3}{nombre}{tit}";
        }

        public static String ConstruirCadenaUltimosDos(String[] autor)
        {
            if (autor.Length >= 2)
            {
                // Obtener las dos últimas palabras del array
                string ultimoApellido = autor[autor.Length - 1];
                string penultimoApellido = autor[autor.Length - 2];

                // Construir la cadena con las dos últimas palabras
                StringBuilder builder = new StringBuilder();
                builder.Append(penultimoApellido).Append(ultimoApellido);

                // Completar con "A" si no hay suficientes letras
                while (builder.Length < 3)
                {
                    builder.Append("A");
                }

                return builder.ToString();
            }
            else
            {
                // Devolver un valor por defecto si no hay suficientes palabras
                return "AAA";
            }
        }

        public static String CrearCorreoAdministrador(String nombre, String apellido)
        {
            return $"{nombre.ToLower().Replace(" ", "")}.{apellido.ToLower().Replace(" ", "")}@admin.letras.com";
        }

        public static string GenerarContrasenaAleatoria(int longitud = 8)
        {
            const string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%&*()<>?";
            StringBuilder contraseñaGenerada = new StringBuilder();

            Random random = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int indiceCaracter = random.Next(caracteresPermitidos.Length);
                contraseñaGenerada.Append(caracteresPermitidos[indiceCaracter]);
            }

            return contraseñaGenerada.ToString();
        }

        public static Categoria devolverCategoriaId(string nombre)
        {
            return categorias
                .Where(c => c.Nombre == nombre)
                .Select(c => (Categoria)c)
                .FirstOrDefault();
        }

        public static Categoria devolverCategoriaNombre(int id)
        {
            return categorias
                .Where(c => c.Id == id)
                .Select(c => (Categoria)c)
                .FirstOrDefault();
        }

        public static List<Categoria> ObtenerCategoriasBBDD()
        {
            Console.WriteLine("\n***** EJECUTAR OBTENER DATOS DESDE LA TABLA CATEGORIA");
            List<Categoria> categorias = new List<Categoria>();

            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();

            string query = "SELECT * FROM Categoria";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Categoria categoria = new Categoria
                    {
                        Id = (int)reader["Id"],
                        Nombre = reader["Nombre"].ToString(),
                    };
                    categorias.Add(categoria);
                };

                return categorias;
            }
        }

        public static String generarCodigoPrestamo()
        {
            int ultimoNumero = 0;
            if (Prestamo.prestamos != null)
            {
                ultimoNumero = Prestamo.prestamos
                    .Max(p => int.Parse(p.IdPrestamo.Substring(1)));
            }
            ultimoNumero++;
            return $"P{ultimoNumero:D6}".Trim();
        }
    }
}
