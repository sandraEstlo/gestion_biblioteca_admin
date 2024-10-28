using GestionBilioteca.Class;
using GestionBilioteca.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBilioteca.View
{
    public partial class Frm_Listar_Prestamos_Administrador : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public Frm_Listar_Prestamos_Administrador()
        {
            InitializeComponent();
        }

        private void Frm_Listar_Prestamos_Administrador_Load(object sender, EventArgs e)
        {
            prestamosDataGridView.DataSource = null;
            prestamosDataGridView.Rows.Clear();
            prestamosDataGridView.Columns.Clear();

            CargarDatosGridViewPorDefecto();
            InicializarYNombresDataGridView();
            FormatoEstilosDataGridView();
        }

        private void nuevoBtn_Click(object sender, EventArgs e)
        {
            Frm_Nuevo_Prestamo_Administrador frmNuevoPrestamo = new Frm_Nuevo_Prestamo_Administrador();
            frmNuevoPrestamo.Show();

            frmNuevoPrestamo.FormClosed += FrmNuevoPrestamo_FormClosed;
        }

        private void FrmNuevoPrestamo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("\n***** EL FORMULARIO NUEVO PRESTAMO SE HA CERRADO");
            this.Refresh();
            Frm_Listar_Prestamos_Administrador_Load(this, EventArgs.Empty);
        }

        private void CargarDatosGridViewPorDefecto()
        {
            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();
            string query = "SELECT * FROM SeleccionarPrestamo";

            SqlConnection connection = new SqlConnection(connectionString);
            dataAdapter.SelectCommand = new SqlCommand(query, connection);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Prestamo");

            bindingSource1.DataSource = dataSet.Tables["Prestamo"];
            prestamosDataGridView.DataSource = bindingSource1;

            prestamosDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void InicializarYNombresDataGridView()
        {
            prestamosDataGridView.Columns[0].Name = "IdPrestamo";
            prestamosDataGridView.Columns[1].Name = "Titulo";
            prestamosDataGridView.Columns[2].Name = "Autor";
            prestamosDataGridView.Columns[3].Name = "Nombre";
            prestamosDataGridView.Columns[4].Name = "Apellidos";
            prestamosDataGridView.Columns[5].Name = "Fecha prestamo";
            prestamosDataGridView.Columns[6].Name = "Fecha devolucion";
            prestamosDataGridView.Columns[7].Name = "Devuelto";

            DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn();
            deleteColumn.Image = Properties.Resources.icono_eliminar_negro;
            deleteColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            deleteColumn.Width = 60;
            deleteColumn.Name = "Eliminar";
            prestamosDataGridView.Columns.Add(deleteColumn);

            prestamosDataGridView.Columns["IdPrestamo"].Width = 80;
            prestamosDataGridView.Columns["Titulo"].Width = 180;
            prestamosDataGridView.Columns["Autor"].Width = 115;
            prestamosDataGridView.Columns["Nombre"].Width = 95;
            prestamosDataGridView.Columns["Apellidos"].Width = 175;
            prestamosDataGridView.Columns["Fecha prestamo"].Width = 85;
            prestamosDataGridView.Columns["Fecha devolucion"].Width = 85;
            prestamosDataGridView.Columns["Devuelto"].Width = 35;

            prestamosDataGridView.Columns["IdPrestamo"].ReadOnly = true;
            prestamosDataGridView.Columns["Titulo"].ReadOnly = true;
            prestamosDataGridView.Columns["Autor"].ReadOnly = true;
            prestamosDataGridView.Columns["Nombre"].ReadOnly = true;
            prestamosDataGridView.Columns["Apellidos"].ReadOnly = true;
            prestamosDataGridView.Columns["Fecha prestamo"].ReadOnly = true;
            prestamosDataGridView.Columns["Fecha devolucion"].ReadOnly = true;
            prestamosDataGridView.Columns["Devuelto"].ReadOnly = true;
        }

        private void FormatoEstilosDataGridView()
        {
            prestamosDataGridView.GridColor = Color.Black;
            prestamosDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            prestamosDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            prestamosDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            prestamosDataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
            prestamosDataGridView.AllowUserToAddRows = true;
        }

        private void librosDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (prestamosDataGridView.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex == prestamosDataGridView.NewRowIndex)
            {
                e.Value = Properties.Resources.icono_eliminar_negro;
            }
        }

        private void filtrarButton_Click(object sender, EventArgs e)
        {
            prestamosDataGridView.DataSource = null;
            prestamosDataGridView.Rows.Clear();
            prestamosDataGridView.Columns.Clear();

            if (tipoComboBox.SelectedIndex<0)
            {
                CargarDatosGridViewPorDefecto();
            } 
            else
            {
                CargarDatosFiltrados(tipoComboBox.SelectedIndex);
            }

            InicializarYNombresDataGridView();
            FormatoEstilosDataGridView();
        }

        private void CargarDatosFiltrados(int i)
        {
            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();
            string query = "";

            switch (i)
            {
                case 0: query = "SELECT * FROM SeleccionarPrestamosSinDevolver";          break;
                case 1: query = "SELECT * FROM SeleccionarDevoluciones";                  break;
                case 2: query = "SELECT * FROM SeleccionarPrestamosPendientesRetrasados"; break;
            }

            SqlConnection connection = new SqlConnection(connectionString);
            dataAdapter.SelectCommand = new SqlCommand(query, connection);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Prestamo");

            bindingSource1.DataSource = dataSet.Tables["Prestamo"];
            prestamosDataGridView.DataSource = bindingSource1;
        }

        private void filtrarDatosBusqueda(string palabraClave)
        {
            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();
            string query = "SELECT p.IdPrestamo, l.Titulo, l.Autor, u.Nombre, u.Apellidos, p.FechaPrestamo, p.FechaDevolucion, p.Devuelto " +
                           "FROM Prestamo as p " +
                           "JOIN Libro as l ON l.IdLibro = p.IdLibro " +
                           "JOIN Usuario as u ON u.IdUsuario = p.IdUsuario " +
                           "WHERE (p.IdPrestamo LIKE '%' + @PalabraClave + '%' " +
                               "OR l.Titulo LIKE '%' + @PalabraClave + '%' " +
                               "OR l.Autor LIKE '%' + @PalabraClave + '%' " +
                               "OR u.Nombre LIKE '%' + @PalabraClave + '%' " +
                               "OR u.Apellidos LIKE '%' + @PalabraClave + '%' " +
                               "OR CONCAT(u.Nombre, ' ', u.Apellidos) LIKE '%' + @PalabraClave + '%' " +
                               "OR CONCAT(u.Apellidos, ' ', u.Nombre) LIKE '%' + @PalabraClave + '%' " +
                               "OR CONCAT(l.Titulo, ' ', u.Nombre, ' ', u.Apellidos) LIKE '%' + @PalabraClave + '%' " +
                               "OR CONCAT(u.Nombre, ' ', u.Apellidos, ' ', l.Titulo) LIKE '%' + @PalabraClave + '%') " +
                               "OR u.Correo LIKE '%' + @PalabraClave + '%' " +
                               "OR p.IdPrestamo = @PalabraClave " +
                               "OR l.Titulo = @PalabraClave " +
                               "OR l.Autor = @PalabraClave " +
                               "OR u.Nombre = @PalabraClave " +
                               "OR u.Apellidos = @PalabraClave";

            SqlConnection connection = new SqlConnection(connectionString);
            dataAdapter.SelectCommand = new SqlCommand(query, connection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@PalabraClave", palabraClave);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Prestamo");

            bindingSource1.DataSource = dataSet.Tables["Prestamo"];
            prestamosDataGridView.DataSource = bindingSource1;
        }

        private void prestamosDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (prestamosDataGridView.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex == prestamosDataGridView.NewRowIndex)
            {
                e.Value = Properties.Resources.icono_eliminar_negro;
            }
        }

        private void Busquedabutton_Click(object sender, EventArgs e)
        {
            prestamosDataGridView.DataSource = null;
            prestamosDataGridView.Rows.Clear();
            prestamosDataGridView.Columns.Clear();

            if (String.IsNullOrEmpty(busquedaTextBox.Text))
            {
                CargarDatosGridViewPorDefecto();
            } 
            else
            {
                filtrarDatosBusqueda(busquedaTextBox.Text);
            }

            InicializarYNombresDataGridView();
            FormatoEstilosDataGridView();
        }

        private void prestamosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("***** EJECUTANDO CLICK PRETAMO");
            if (e.RowIndex >= 0 && e.RowIndex < (prestamosDataGridView.Rows.Count - 1))
            {
                string idRegistro = prestamosDataGridView.Rows[e.RowIndex].Cells["IdPrestamo"].Value.ToString();
                Prestamo prestamo = Controlador_GestionPrestamos.BuscarPrestamoCodigo(idRegistro);
                Console.WriteLine(prestamo.Devuelto.ToString());

                if (prestamo.Devuelto)
                {
                    MessageBox.Show("No se puede devolver un prestamo ya devuelto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Console.WriteLine($"+++++ PRESTAMO SELECCIONADO: {prestamo}");
                    Frm_Registar_Devolucion frmRegistroDevolucion = new Frm_Registar_Devolucion(prestamo);
                    frmRegistroDevolucion.Show();

                    frmRegistroDevolucion.FormClosed += FrmRegistroDevolucion_FormClosed;
                }
            }
        }

        private void FrmRegistroDevolucion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("\n***** EL FORMULARIO NUEVO DEVOLUCION SE HA CERRADO");
            this.Refresh();
            Frm_Listar_Prestamos_Administrador_Load(this, EventArgs.Empty);
        }

        private void prestamosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == prestamosDataGridView.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                Console.WriteLine("***** EJECUTANDO ELIMINAR REGISTRO CLICK");
                string idRegistro = prestamosDataGridView.Rows[e.RowIndex].Cells["IdPrestamo"].Value.ToString();
                DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas eliminar el prestamo\n {idRegistro}?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                Console.WriteLine($"ID: {idRegistro}");

                if (result == DialogResult.Yes)
                {
                    Prestamo prestamoEliminar = Controlador_GestionPrestamos.BuscarPrestamoCodigo(idRegistro) ;
                    Console.WriteLine($"+++++ PRESTAMO A ELIMINAR: {prestamoEliminar}");

                    if (Controlador_GestionPrestamos.EliminarPrestamo(prestamoEliminar))
                    {
                        Prestamo.prestamos.Remove(prestamoEliminar);
                        prestamosDataGridView.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Se ha eliminado el prestamo", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
