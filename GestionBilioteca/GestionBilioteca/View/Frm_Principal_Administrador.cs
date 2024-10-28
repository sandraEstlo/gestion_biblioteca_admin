using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionBilioteca.Class;
using GestionBilioteca.Controller;

namespace GestionBilioteca.View
{
    public partial class Frm_Principal_Administrador : Form
    {
        public Frm_Principal_Administrador()
        {
            InitializeComponent();
        }
        private void Frm_Principal_Administrador_Load(object sender, EventArgs e)
        {
            Console.WriteLine("\n***** EJECUTANDO CARGAR LIBROS Y CATEGORIAS");

            Controlador_GestionBiblioteca.categorias = Controlador_GestionBiblioteca.ObtenerCategoriasBBDD();

            Libro.libros = Controlador_GestionLibro.ObtenerLibrosDesdeFuenteDatos();
            if (Libro.libros.Count == 0)
            {
                Console.WriteLine("+++++ LISTA LIBROS VACIA: se cargan datos de fichero json");
                Libro.libros = Controlador_GestionLibro.LeerArchivoLibros();

                if (Libro.libros.Count != 0)
                {
                    Console.WriteLine("+++++ INSERTAR DATOS A LA BBDD");
                    Libro.libros.ForEach(libro => { Controlador_GestionLibro.InsertarLibro(libro); });
                    
                }

                Console.WriteLine("+++++ LISTA LIBROS CARGADA: ");
                Libro.libros.ForEach(libro => { Console.WriteLine(libro.ToString()); });
            }
            else
            {
                Console.WriteLine("+++++ LISTA LIBROS CARGADA CORRECTAMENTE: ");
                Libro.libros.ForEach(libro => { Console.WriteLine(libro.ToString()); });
            }

            Prestamo.prestamos = Controlador_GestionPrestamos.ObtenerPrestamosDesdeFuenteDatos();

            Console.WriteLine("+++++ LISTA PRESTAMOS");
            Prestamo.prestamos.ForEach(p => Console.WriteLine(p));
        }

        private void usuariosBtn_Click(object sender, EventArgs e)
        {
            Frm_listar_usuarios frm_Listar_Usuarios = new Frm_listar_usuarios();
            frm_Listar_Usuarios.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Listar_Libros_Administrador frm_Listar_Libros_Administrador = new Frm_Listar_Libros_Administrador();
            frm_Listar_Libros_Administrador.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Listar_Prestamos_Administrador frmListarPrestamos = new Frm_Listar_Prestamos_Administrador();
            frmListarPrestamos.Show();
        }
    }
}
