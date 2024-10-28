using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionBilioteca.Class;
using GestionBilioteca.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionBilioteca.View
{
    public partial class Frm_Listar_Libros_Administrador : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private ErrorProvider errorProvider = new ErrorProvider();
        public Frm_Listar_Libros_Administrador()
        {
            InitializeComponent();
        }

        private void nuevoBtn_Click(object sender, EventArgs e)
        {
            Frm_Nuevo_Libro_Administrador frm_Nuevo_Libro_Administrador = new Frm_Nuevo_Libro_Administrador();
            frm_Nuevo_Libro_Administrador.Show();
            frm_Nuevo_Libro_Administrador.FormClosed += Frm_Nuevo_Libro_Administrador_FormClosed;
        }

        private void Frm_Nuevo_Libro_Administrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("\n***** EL FORMULARIO NUEVO LIBRO SE HA CERRADO");
            this.Refresh();
            Frm_Listar_Libros_Administrador_Load(this, EventArgs.Empty);
        }

        private void Frm_Listar_Libros_Administrador_Load(object sender, EventArgs e)
        {
            librosDataGridView.DataSource = null;
            librosDataGridView.Rows.Clear();
            librosDataGridView.Columns.Clear();

            CargarDatosGridViewPorDefecto();
            InicializarYNombresDataGridView();
            FormatoEstilosDataGridView();
            CargarCategoria();
        }

        private void CargarDatosGridViewPorDefecto(){
            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();
            string query = "SELECT l.IdLibro as Codigo, l.Titulo, l.Autor, c.nombre as Categoria, l.FechaPublicacion as Publicacion, l.Isbn, l.Ejemplares as Num, l.Disponibles as Dis FROM Libro as l JOIN Categoria as c ON l.Categoria = c.Id;";

            SqlConnection connection = new SqlConnection(connectionString);
            dataAdapter.SelectCommand = new SqlCommand(query, connection);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Libro");

            bindingSource1.DataSource = dataSet.Tables["Libro"];
            librosDataGridView.DataSource = bindingSource1;
        }

        private void InicializarYNombresDataGridView()
        {
            librosDataGridView.Columns[0].Name = "IdLibro";
            librosDataGridView.Columns[1].Name = "Titulo";
            librosDataGridView.Columns[2].Name = "Autor";
            librosDataGridView.Columns[3].Name = "Categoria";
            librosDataGridView.Columns[4].Name = "FechaPublicacion";
            librosDataGridView.Columns[5].Name = "Isbn";
            librosDataGridView.Columns[6].Name = "Ejemplares";
            librosDataGridView.Columns[7].Name = "Disponibles";

            DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn();
            deleteColumn.Image = Properties.Resources.icono_eliminar_negro;
            deleteColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            deleteColumn.Width = 60;
            deleteColumn.Name = "Eliminar";
            librosDataGridView.Columns.Add(deleteColumn);

            librosDataGridView.Columns["IdLibro"].Width = 90;
            librosDataGridView.Columns["Titulo"].Width = 210;
            librosDataGridView.Columns["Autor"].Width = 140;
            librosDataGridView.Columns["Categoria"].Width = 180;
            librosDataGridView.Columns["FechaPublicacion"].Width = 85;
            librosDataGridView.Columns["Isbn"].Width = 95;
            librosDataGridView.Columns["Ejemplares"].Width = 35;
            librosDataGridView.Columns["Disponibles"].Width = 35;
            librosDataGridView.Columns["Eliminar"].Width = 40;

            librosDataGridView.Columns["IdLibro"].ReadOnly = true;
            librosDataGridView.Columns["Categoria"].ReadOnly = true;
            librosDataGridView.Columns["Ejemplares"].ReadOnly = true;
            librosDataGridView.Columns["Disponibles"].ReadOnly = true;
        }

        private void FormatoEstilosDataGridView()
        {
            librosDataGridView.GridColor = Color.Black;
            librosDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            librosDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            librosDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            librosDataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
            librosDataGridView.AllowUserToAddRows = true;
        }

        private void librosDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (librosDataGridView.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex == librosDataGridView.NewRowIndex)
            {
                e.Value = Properties.Resources.icono_eliminar_negro;
            }
        }

        private void librosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == librosDataGridView.Columns["Eliminar"].Index && e.RowIndex >= 0 && e.RowIndex < (librosDataGridView.Rows.Count -1))
            {
                string idRegistro = librosDataGridView.Rows[e.RowIndex].Cells["IdLibro"].Value.ToString();
                Console.WriteLine(idRegistro);
                Libro libroBusqueda = Controlador_GestionLibro.buscarLibroBBDDId(idRegistro);
                DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas eliminar el libro\n{libroBusqueda.Titulo}?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Controlador_GestionLibro.eliminarLibro(idRegistro);
                    Libro.libros.Remove(libroBusqueda);
                    librosDataGridView.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void CargarCategoria()
        {
            categoriaComboBox.Items.Clear();
            Controlador_GestionBiblioteca.categorias.ForEach(categoria => { 
                categoriaComboBox.Items.Add(categoria.Nombre); 
                categoriaComboBox.Tag = categoria;
            });
        }

        private void CargarDataGridViewDatosFiltrados(string categoria)
        {
            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();
            string query = "SELECT l.IdLibro as Codigo, l.Titulo, l.Autor, c.nombre as Categoria, l.FechaPublicacion as Publicacion, l.Isbn, l.Ejemplares as Num, l.Disponibles as Dis FROM Libro as l JOIN Categoria as c ON l.Categoria = c.Id WHERE c.nombre=@Categoria;";
            SqlConnection connection = new SqlConnection(connectionString);
            dataAdapter.SelectCommand = new SqlCommand(query, connection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Categoria", categoria);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Libro");

            bindingSource1.DataSource = dataSet.Tables["Libro"];
            librosDataGridView.DataSource = bindingSource1;
        }

        private void CargarDataGridViewDatosBusqueda(string palabraClave)
        {
            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();

            string query = "SELECT l.IdLibro as Codigo, l.Titulo, l.Autor, c.nombre as Categoria, l.FechaPublicacion as Publicacion, l.Isbn, l.Ejemplares as Num, l.Disponibles as Dis " +
                           "FROM Libro as l JOIN Categoria as c ON l.Categoria = c.Id " +
                           "WHERE (l.IdLibro LIKE '%' + @PalabraClave + '%' " +
                               "OR l.Titulo LIKE '%' + @PalabraClave + '%' " +
                               "OR l.Autor LIKE '%' + @PalabraClave + '%' " +
                               "OR l.Descripcion LIKE '%' + @PalabraClave + '%' " +
                               "OR CONVERT(VARCHAR(20), l.Isbn) LIKE '%' + @PalabraClave + '%') " +
                               "OR l.IdLibro = @PalabraClave " +
                               "OR l.Titulo = @PalabraClave " +
                               "OR l.Autor = @PalabraClave " +
                               "OR l.Descripcion = @PalabraClave " +
                               "OR CONVERT(VARCHAR(20), l.Isbn) = @PalabraClave";

            SqlConnection connection = new SqlConnection(connectionString);
            dataAdapter.SelectCommand = new SqlCommand(query, connection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@PalabraClave", palabraClave);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Libro");

            bindingSource1.DataSource = dataSet.Tables["Libro"];
            librosDataGridView.DataSource = bindingSource1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            librosDataGridView.DataSource=null;
            librosDataGridView.Rows.Clear();
            librosDataGridView.Columns.Clear();

            if (categoriaComboBox.SelectedItem != null)
            {
                CargarDataGridViewDatosFiltrados(categoriaComboBox.SelectedItem.ToString());
            } else
            {
                CargarDatosGridViewPorDefecto();
            }

            InicializarYNombresDataGridView();
            FormatoEstilosDataGridView();
        }

        private void Busquedabutton_Click(object sender, EventArgs e)
        {
            FiltrarPorBusqueda();
        }

        private void FiltrarPorBusqueda()
        {
            librosDataGridView.DataSource = null;
            librosDataGridView.Rows.Clear();
            librosDataGridView.Columns.Clear();

            if (busquedaTextBox.Text == string.Empty || string.IsNullOrWhiteSpace(busquedaTextBox.Text))
            {
                CargarDatosGridViewPorDefecto();
            } 
            else 
            {
                CargarDataGridViewDatosBusqueda(busquedaTextBox.Text);
            }

            InicializarYNombresDataGridView();
            FormatoEstilosDataGridView();
        }

        private void librosDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("\n***** EJECUTAR MODIFICAR LIBRO");

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = librosDataGridView.Rows[e.RowIndex];
                DataGridViewCell cell = row.Cells[e.ColumnIndex];

                object newValue = cell.Value;
                string columnName = cell.OwningColumn.Name;
                object primaryKeyValue = librosDataGridView.Rows[e.RowIndex].Cells["IdLibro"].Value;

                if (cell.OwningColumn.Name == "Titulo")
                {
                    if (string.IsNullOrWhiteSpace(cell.Value?.ToString()))
                    {
                        MessageBox.Show("El titulo no puede ir vacio.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (cell.OwningColumn.Name == "Autor")
                {
                    if (string.IsNullOrWhiteSpace(cell.Value?.ToString()))
                    {
                        MessageBox.Show("El autor no puede ir vacio.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (cell.OwningColumn.Name == "FechaPublicacion")
                {
                    if (!DateTime.TryParse(newValue.ToString(), out DateTime fecha))
                    {
                        MessageBox.Show("La fecha introducida no es valida.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (cell.OwningColumn.Name == "Isbn")
                {
                    if (!long.TryParse(newValue.ToString(), out long isbn) || newValue.ToString().Length != 13 || string.IsNullOrWhiteSpace(cell.Value?.ToString()))
                    {
                        MessageBox.Show("El isbn debe ser un numero de 13 digitos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                Controlador_GestionLibro.modificarDatosLibro(columnName, newValue, primaryKeyValue);
                Libro modificado = Controlador_GestionLibro.buscarLibroBBDDId(primaryKeyValue.ToString());
                Libro sinModificar = Controlador_GestionLibro.SeleccionarId(primaryKeyValue.ToString());

                Console.WriteLine("\t+++++ LIBRO ANTES DE MODIFICAR:   " + modificado.ToString());
                Console.WriteLine("\t+++++ LIBRO DESPUES DE MODIFICAR: " + sinModificar.ToString());

                string mensaje = (Controlador_GestionLibro.modificarLibroLista(sinModificar, modificado)) ? "El libro se ha modificado correctamente." : "No se ha podido modificar el libro.";
                Console.WriteLine($"\t***** RESULTADO: {mensaje}");
            }
        }

        private void librosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != librosDataGridView.Columns["Eliminar"].Index && e.RowIndex >= 0 && e.RowIndex < (librosDataGridView.Rows.Count - 1))
            {
                object primaryKeyValue = librosDataGridView.Rows[e.RowIndex].Cells["IdLibro"].Value;
                Libro libro = Controlador_GestionLibro.buscarLibroBBDDId(primaryKeyValue.ToString());

                Frm_Detalles_Libro frmDetallesLibro = new Frm_Detalles_Libro(libro);
                frmDetallesLibro.Show();
            }
        }
    }
}
