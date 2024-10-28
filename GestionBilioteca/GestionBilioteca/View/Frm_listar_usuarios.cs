using GestionBilioteca.Class;
using GestionBilioteca.Controller;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GestionBilioteca.View
{
    public partial class Frm_listar_usuarios : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public Frm_listar_usuarios()
        {
            InitializeComponent();
        }

        private void Frm_listar_usuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            cargarDatosPorDefecto();
            InicializarYNombresDataGridView();
            FormatoEstilosDataGridView();
        }


        private void cargarDatosPorDefecto()
        {
            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();
            string query = "SELECT * FROM Usuario";

            SqlConnection connection = new SqlConnection(connectionString);
            dataAdapter.SelectCommand = new SqlCommand(query, connection);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Usuario");

            bindingSource1.DataSource = dataSet.Tables["Usuario"];
            dataGridView1.DataSource = bindingSource1;
        }

        private void InicializarYNombresDataGridView()
        {
            dataGridView1.Columns[0].Name = "IdUsuario";
            dataGridView1.Columns[1].Name = "Nombre";
            dataGridView1.Columns[2].Name = "Apellidos";
            dataGridView1.Columns[3].Name = "Dni";
            dataGridView1.Columns[4].Name = "Correo";
            dataGridView1.Columns[5].Name = "Contrasenia";
            dataGridView1.Columns[6].Name = "Telefono";
            dataGridView1.Columns[7].Name = "NumTarjeta";
            dataGridView1.Columns[8].Name = "Administrador";
            dataGridView1.Columns[9].Name = "Imagen";

            dataGridView1.Columns.Remove("Contrasenia");
            dataGridView1.Columns.Remove("Imagen");
            dataGridView1.Columns.Remove("Administrador");

            dataGridView1.Columns["IdUsuario"].Width = 90;
            dataGridView1.Columns["Nombre"].Width = 110;
            dataGridView1.Columns["Apellidos"].Width = 150;
            dataGridView1.Columns["Dni"].Width = 90;
            dataGridView1.Columns["Correo"].Width = 210;

            dataGridView1.Columns["IdUsuario"].ReadOnly = true;
            dataGridView1.Columns["NumTarjeta"].ReadOnly = true;
            dataGridView1.Columns["Dni"].ReadOnly = true;

            DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn();
            deleteColumn.Image = Properties.Resources.icono_eliminar_negro;
            deleteColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            deleteColumn.Width = 60;
            deleteColumn.Name = "Eliminar";
            dataGridView1.Columns.Add(deleteColumn);
        }

        private void FormatoEstilosDataGridView() 
        {
            dataGridView1.GridColor = Color.Black;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
            dataGridView1.AllowUserToAddRows = true;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex == dataGridView1.NewRowIndex)
            {
                e.Value = Properties.Resources.icono_eliminar_negro;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index && e.RowIndex >=0)
            {
                string idRegistro =  dataGridView1.Rows[e.RowIndex].Cells["IdUsuario"].Value.ToString();
                Usuario usuarioBusqueda = Controlador_GestionUsuario.SeleccionarId(idRegistro);

                if (usuarioBusqueda!=null)
                {
                    DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas eliminar al usuario {usuarioBusqueda.Nombre} {usuarioBusqueda.Apellidos}?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Controlador_GestionUsuario.EliminarUsuario(idRegistro);
                        Usuario.usuarios.Remove(usuarioBusqueda);
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show($"Usuario no encontrado. Vuelva a intentarlo más tarde o a refrescar la pagina", "Error eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
                
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("\n***** EJECUTAR MODIFICAR USUARIO");
            
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                DataGridViewCell cell = row.Cells[e.ColumnIndex];

                object newValue = cell.Value;
                string columnName = cell.OwningColumn.Name;
                object primaryKeyValue = dataGridView1.Rows[e.RowIndex].Cells["idUsuario"].Value;

                if (cell.OwningColumn.Name == "Nombre")
                {
                    if (string.IsNullOrWhiteSpace(cell.Value?.ToString()))
                    {
                        MessageBox.Show("El nombre no puede ir vacio.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (cell.OwningColumn.Name == "Apellidos")
                {
                    if (string.IsNullOrWhiteSpace(cell.Value?.ToString()))
                    {
                        MessageBox.Show("El apellido no puede ir vacio.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (cell.OwningColumn.Name == "Correo")
                {
                    if (!Controlador_ComprobacionesUsuarios.comprobarCorreo(cell.Value?.ToString()))
                    {
                        MessageBox.Show("Datos introducidos del correo no validos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (cell.OwningColumn.Name == "Telefono")
                {
                    if (cell.Value != null && cell.Value is int)
                    {
                        int telefono = (int)cell.Value;

                        if (!Controlador_ComprobacionesUsuarios.comprobarTelefono(telefono.ToString()))
                        {
                            MessageBox.Show("Datos introducidos del teléfono no válidos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El valor en la celda no es un número válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                Controlador_GestionUsuario.ModificarDatos(columnName, newValue, primaryKeyValue);

                Usuario modificado = Controlador_GestionUsuario.BuscarUsuarioBBDDId(primaryKeyValue.ToString());
                Usuario sinModificar = Controlador_GestionUsuario.SeleccionarId(primaryKeyValue.ToString());

                Console.WriteLine("\t+++++ USUARIO ANTES DE MODIFICAR:   " + sinModificar.ToString());
                Console.WriteLine("\t+++++ USUARIO DESPUES DE MODIFICAR: " + modificado.ToString());

                string mensaje = (Controlador_GestionUsuario.ModificarUsuarioLista(sinModificar, modificado)) ? "El usuario se ha modificado correctmamente." : "No se ha podido modificar el usuario.";
                Console.WriteLine($"\t***** RESULTADO: {mensaje}");
            }
        }

        private void Busquedabutton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            if (String.IsNullOrEmpty(busquedaTextBox.Text))
            {
                cargarDatosPorDefecto();
            } 
            else
            {
                usuariosBusqueda(busquedaTextBox.Text);
            }

            InicializarYNombresDataGridView();
            FormatoEstilosDataGridView();
        }

        private void nuevoBtn_Click(object sender, EventArgs e)
        {
            Frm_Nuevo_Usuario_Administrador frmNuevoUsuarioAdmin = new Frm_Nuevo_Usuario_Administrador();
            frmNuevoUsuarioAdmin.Show();
            frmNuevoUsuarioAdmin.FormClosed += FrmNuevoUsuarioAdmin_FormClosed;
        }

        private void FrmNuevoUsuarioAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            Frm_listar_usuarios_Load(this, EventArgs.Empty);
        }

        private void filtrarButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            if (tipoComboBox.SelectedItem != null)
            {
                string valor = (tipoComboBox.SelectedIndex == 0).ToString();
                usuariosFiltrados(valor);
            }
            else
            {
                cargarDatosPorDefecto();
            }

            InicializarYNombresDataGridView();
            FormatoEstilosDataGridView();
        }
        private void usuariosFiltrados(string criterio)
        {
            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();
            string query = "SELECT * FROM Usuario WHERE Administrador = @Criterio";

            SqlConnection connection = new SqlConnection(connectionString);
            dataAdapter.SelectCommand = new SqlCommand(query, connection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Criterio", criterio);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Usuario");

            bindingSource1.DataSource = dataSet.Tables["Usuario"];
            dataGridView1.DataSource = bindingSource1;
        }

        private void usuariosBusqueda(string palabraClave)
        {
            string connectionString = Controlador_GestionBiblioteca.construirCadenaConexión();
            string query = "SELECT * FROM Usuario " +
                           "WHERE (IdUsuario = @PalabraClave OR " +
                           "       Nombre = @PalabraClave OR " +
                           "       Apellidos = @PalabraClave OR " +
                           "       Dni = @PalabraClave OR " +
                           "       Correo = @PalabraClave OR " +
                           "       CONVERT(VARCHAR(20), telefono) = @PalabraClave OR " +
                           "       CONVERT(VARCHAR(20), NumTarjeta) = @PalabraClave OR " +
                           "       CONCAT(Nombre, ' ', Apellidos) = @PalabraClave) " +
                           "OR (IdUsuario LIKE '%' + @PalabraClave + '%' OR " +
                           "    Nombre LIKE '%' + @PalabraClave + '%' OR " +
                           "    Apellidos LIKE '%' + @PalabraClave + '%' OR " +
                           "    Dni LIKE '%' + @PalabraClave + '%' OR " +
                           "    Correo LIKE '%' + @PalabraClave + '%' OR " +
                           "    CONVERT(VARCHAR(20), telefono) LIKE '%' + @PalabraClave + '%' OR " +
                           "    CONVERT(VARCHAR(20), NumTarjeta) LIKE '%' + @PalabraClave + '%' OR " +
                           "    CONCAT(Nombre, ' ', Apellidos) LIKE '%' + @PalabraClave + '%')";

            SqlConnection connection = new SqlConnection(connectionString);
            dataAdapter.SelectCommand = new SqlCommand(query, connection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@PalabraClave", palabraClave);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Usuario");

            bindingSource1.DataSource = dataSet.Tables["Usuario"];
            dataGridView1.DataSource = bindingSource1;
        }
    }
}
