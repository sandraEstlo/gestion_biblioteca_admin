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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionBilioteca.View
{
    public partial class Frm_Listar_Busqueda_Libros : Form
    {
        private int initialPosition = 20;
        public Frm_Listar_Busqueda_Libros()
        {
            InitializeComponent();
        }

        private void Frm_Listar_Busqueda_Libros_Load(object sender, EventArgs e)
        {
            Controlador_GestionPrestamos.listaLibrosFiltradaBusqueda.ForEach(libro => { crearRadioButton(libro); });
        }

        private void crearRadioButton(Libro libro)
        {
            RadioButton radioButton = new RadioButton();
            radioButton.CheckedChanged += RadioButton_CheckedChanged;

            radioButton.AutoSize = true;
            radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radioButton.Location = new System.Drawing.Point(20, this.initialPosition);
            radioButton.Text = $"{libro.Titulo} - {libro.Autor,-30}";

            // Asigna el objeto Usuario al Tag del RadioButton
            radioButton.Tag = libro;

            librosListBox.Controls.Add(radioButton);
            this.initialPosition += 20;
        }


        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            Controlador_GestionPrestamos.libroSeleccionadoBusqueda = (Libro)radioButton.Tag;
            Console.WriteLine($"+++++ LIBRO SELECCIONADO: {Controlador_GestionPrestamos.libroSeleccionadoBusqueda}");
            this.Close();
        }
    }
}
