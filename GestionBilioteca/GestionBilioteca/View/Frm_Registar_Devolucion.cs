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
    public partial class Frm_Registar_Devolucion : Form
    {
        private Prestamo prestamo;
        public Frm_Registar_Devolucion(Prestamo prestamo)
        {
            InitializeComponent();
            this.prestamo = prestamo;
        }

        private void Frm_Registar_Devolucion_Load(object sender, EventArgs e)
        {
            tituloTextBox.Text = Libro.libros.Where(l => l.IdLibro == prestamo.IdLibro).Select(u => u.Titulo).FirstOrDefault();
            autorTextBox.Text = Libro.libros.Where(l => l.IdLibro == prestamo.IdLibro).Select(u => u.Autor).FirstOrDefault();
            usuarioTextBox.Text = Controlador_GestionUsuario.nombreApellidoUsuario(prestamo.IdUsuario);
        }

        private void devolverBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("***** EJECUTANDO BOTON DEVOLVER PRESTAMO");
            Console.WriteLine($"PRESTAMO A DEVOLVER: {prestamo}");
            Controlador_GestionPrestamos.registrarDevolucion(prestamo);
            Prestamo modificado = new Prestamo();
        }
    }
}
