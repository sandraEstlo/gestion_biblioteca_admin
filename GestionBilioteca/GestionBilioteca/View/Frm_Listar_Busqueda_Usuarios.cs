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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace GestionBilioteca.View
{
    public partial class Frm_Listar_Busqueda_Usuarios : Form
    {
        private int initialPosition = 20;
        private int nameCount;

        public Frm_Listar_Busqueda_Usuarios()
        {
            InitializeComponent();
        }

        private void Frm_Listar_Busqueda_Usuarios_Load(object sender, EventArgs e)
        {
            Controlador_GestionPrestamos.listaUsuariosFiltradaBusqueda.ForEach(usuario => {
                if (!usuario.Administrador) { crearRadioButton(usuario);  }
            });
        }

        private void crearRadioButton(Usuario usuario)
        {
            RadioButton radioButton = new RadioButton();
            radioButton.CheckedChanged += RadioButton_CheckedChanged1;

            radioButton.AutoSize = true;
            radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radioButton.Location = new System.Drawing.Point(20, this.initialPosition);
            radioButton.Size = new System.Drawing.Size(632, 329);
            radioButton.Text = $"{usuario.Nombre} {usuario.Apellidos}";

            // Asigna el objeto Usuario al Tag del RadioButton
            radioButton.Tag = usuario;

            usuariosListBox.Controls.Add(radioButton);
            this.initialPosition += 20;
        }

        private void RadioButton_CheckedChanged1(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            Controlador_GestionPrestamos.usuarioSeleccionadoBusqueda = (Usuario)radioButton.Tag;
            Console.WriteLine($"+++++ USUARIO SELECCIONADO: {Controlador_GestionPrestamos.usuarioSeleccionadoBusqueda}");
            this.Close();
        }
    }
}
