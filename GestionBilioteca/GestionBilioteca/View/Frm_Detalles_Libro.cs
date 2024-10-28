using GestionBilioteca.Class;
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
    public partial class Frm_Detalles_Libro : Form
    {
        private Libro libro;
        public Frm_Detalles_Libro(Libro libro)
        {
            InitializeComponent();
            this.libro = libro;

            if (!String.IsNullOrEmpty(libro.Imagen))
            {
                pictureBox1.Image = Image.FromFile(libro.Imagen);
            }
            
            tituloTextBox.Text = libro.Titulo;
            autorTextBox.Text = libro.Autor;
            ejemLabel.Text = libro.Ejemplares.ToString();
            disLabel.Text = libro.Disponibles.ToString();
            fpLabel.Text = libro.FechaPublicacion.ToString("dd/MM/yyyy");
            descripcionTextBox.Text = libro.Descripcion;
            labelid.Text = libro.IdLibro;
        }

        private void Frm_Detalles_Libro_Load(object sender, EventArgs e)
        {

        }
    }
}
