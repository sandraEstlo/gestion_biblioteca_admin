using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionBilioteca.Class;
using GestionBilioteca.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace GestionBilioteca.View
{
    public partial class Frm_Nuevo_Libro_Administrador : Form
    {
        public Libro libroNuevo = new Libro();
        private string rutaImagenOrigen = string.Empty;
        private ErrorProvider errorProvider = new ErrorProvider();

        public Frm_Nuevo_Libro_Administrador()
        {
            InitializeComponent();
            imagenLibro.Visible = true;
        }

        private void Frm_Nuevo_Libro_Administrador_Load(object sender, EventArgs e)
        {
            LimpiarContenido();
            CargarCategoria();

            toolTip1.SetToolTip(imagenLibro, "Para escoger una imagen haga click.");
        }

        private int comprobarCampos()
        {
            Console.WriteLine("\n**** EJECUTANDO: COMPROBAR CAMPOS NUEVO LIBRO");
            int contCamposCorrectos = 0;

            if (tituloTextBox.Text == string.Empty || string.IsNullOrWhiteSpace(tituloTextBox.Text))
            { MostrarError(tituloPanel, "El campo titulo es requerido"); }
            else { libroNuevo.Titulo = tituloTextBox.Text; contCamposCorrectos++; QuitarError(tituloPanel); }

            if (autorTextBox.Text == string.Empty || string.IsNullOrWhiteSpace(autorTextBox.Text))
            { MostrarError(autorPanel, "El campo autor es requerido"); }
            else { libroNuevo.Autor = autorTextBox.Text; contCamposCorrectos++; QuitarError(autorPanel); }

            if (categoriaComboBox.SelectedItem != null)
            { String nombre = categoriaComboBox.SelectedItem.ToString();
              Categoria categoria = Controlador_GestionBiblioteca.devolverCategoriaId(nombre);
              libroNuevo.Categoria = categoria.Id; contCamposCorrectos++; QuitarError(categoriaComboBoxPanel);
            } else { MostrarError(categoriaComboBoxPanel, "El campo categoria es requerido"); }

            if (Controlador_GestionLibro.comprobarIsbn(isbnTextBox.Text))
            { libroNuevo.Isbn = long.Parse(isbnTextBox.Text); contCamposCorrectos++; QuitarError(isbnPanel);
            } else { MostrarError(isbnPanel, "El campo isbn es requerido y ser de longitud 13"); }

            if (descripcionTextBox.Text == string.Empty || string.IsNullOrWhiteSpace(descripcionTextBox.Text))
            { MostrarError(descripcionPanel, "El campo descripcion es requerido"); 
            } else { libroNuevo.Descripcion = descripcionTextBox.Text; contCamposCorrectos++; QuitarError(descripcionPanel); }

            if (!Controlador_GestionLibro.EsFechaAnterior((DateTime)fechapublicacionDTP.Value))
            { MostrarError(dateTimePanel, "La fecha no puede ser mayor que hoy");
            } else { libroNuevo.FechaPublicacion = fechapublicacionDTP.Value; contCamposCorrectos++; QuitarError(dateTimePanel); }

            if (!Controlador_GestionLibro.EsNumericUpDownCero((int)ejemplaresNUD.Value))
            { MostrarError(ejemplaresPanel, "El numero de ejemplares no puede ser 0");
            } else { libroNuevo.Ejemplares = (int)ejemplaresNUD.Value; QuitarError(ejemplaresPanel); }

            return contCamposCorrectos;
        }

        private void MostrarError(Panel panel, string mensajeError)
        {
            Icon iconoPersonalizado = Icon.FromHandle(Properties.Resources.error_icon.GetHicon());
            errorProvider.Icon = iconoPersonalizado;
            errorProvider.SetIconPadding(panel, -30);
            errorProvider.SetIconAlignment(panel, ErrorIconAlignment.MiddleRight);
            errorProvider.SetError(panel, mensajeError);
        }
        private void QuitarError(Panel panel)
        {
            errorProvider.SetError(panel, "");
        }

        private void crearBtn_Click(object sender, EventArgs e)
        {
            int camposRequeridos = Controls.OfType<Panel>().Count() - 1;
            int camposCorrectos = comprobarCampos();

            if(camposCorrectos == camposRequeridos)
            {
                libroNuevo.IdLibro = Controlador_GestionBiblioteca.generarCodigoLibro(libroNuevo.Categoria, libroNuevo.Titulo, libroNuevo.Autor);

                if (rutaImagenOrigen != string.Empty || !string.IsNullOrWhiteSpace(tituloTextBox.Text))
                {
                    Console.WriteLine($"***** RESULTADO: CAMPOS REQUERIDOS {camposRequeridos} | CAMPOS CORRECTOS {camposCorrectos}");
                    string nombreArchivo = $"{libroNuevo.Categoria}{libroNuevo.IdLibro}.png";
                    string rutaImagenDestino = Path.Combine("..", "..", "Resources", nombreArchivo);

                    try
                    {
                        File.Copy(rutaImagenOrigen, rutaImagenDestino, true);
                        Console.WriteLine($"Imagen copiada exitosamente a la carpeta Resources con la ruta relativa: {rutaImagenDestino}");

                        libroNuevo.Imagen = rutaImagenDestino;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al copiar la imagen: {ex.Message}");
                    }
                }
                Controlador_GestionLibro.InsertarLibro(libroNuevo);
                LimpiarContenido();
            }
        }

        private void CargarCategoria()
        {
            categoriaComboBox.Items.Clear();
            Controlador_GestionBiblioteca.categorias.ForEach(categoria => { categoriaComboBox.Items.Add(categoria.Nombre); });
        }

        private void imagenLibro_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"***** EJECUTANDO CARGAR IMAGEN:: ONCLICK");
            var rutaArchivo = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image files (*.bmp; *.gif; *.jpg; *.png)|*.bmp; *.gif; *.jpg; *.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivo = openFileDialog.FileName;
                    imagenLibro.Image = Image.FromFile(rutaArchivo);
                    rutaImagenOrigen = rutaArchivo;
                }
            }
        }

        private void LimpiarContenido()
        {
            foreach (Control control in Controls)
            {
                if (control is Panel panel)
                {
                    foreach (Control c in panel.Controls)
                    {
                        if (c is TextBox tb)
                        {
                            tb.Text = string.Empty;
                        }

                        if (c is NumericUpDown nb)
                        {
                            nb.Value = 0;
                        }
                    }
                }
            }
        }
    }
}
