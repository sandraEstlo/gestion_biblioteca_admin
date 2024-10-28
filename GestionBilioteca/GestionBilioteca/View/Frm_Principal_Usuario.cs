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
    public partial class Frm_Principal_Usuario : Form
    {
        public Frm_Principal_Usuario()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Usuario_Load(object sender, EventArgs e)
        {
            labelNombre.Text = Sesion.usuarioSesion.Nombre;
            CentrarInfoUsuario(labelNombre, panelMenu);

            string nombreImagenUsuario = Sesion.usuarioSesion.Imagen;
            pictureBoxAvatar.Image = Image.FromFile(nombreImagenUsuario);
        }

        private void CentrarInfoUsuario(Label l, Panel p)
        {
            // Centrar horizontalmente
            int x = (p.Width - l.Width) / 2;
            l.Location = new System.Drawing.Point(x, l.Location.Y);
        }
    }
}
