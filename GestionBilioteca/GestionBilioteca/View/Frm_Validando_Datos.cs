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
using ProgressBar = System.Windows.Forms.ProgressBar;

namespace GestionBilioteca.View
{
    public partial class Frm_Validando_Datos : Form
    {
        private Timer timerProgreso;

        public Frm_Validando_Datos()
        {
            InitializeComponent();
            ConfigurarProgressBar();
            IniciarProgreso();
        }

        private void ConfigurarProgressBar()
        {
            // Configurar el mínimo y el máximo del ProgressBar
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }

        private void IniciarProgreso()
        {
            timerProgreso = new Timer();
            timerProgreso.Interval = 50;
            timerProgreso.Tick += TimerProgreso_Tick;
            timerProgreso.Start();
        }
        private void TimerProgreso_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
            }
            else
            {
                timerProgreso.Stop();
                Task.Delay(1000).ContinueWith(_ =>
                {
                    if (this.IsHandleCreated)
                    {
                        this.Invoke((Action)delegate { this.Close(); });
                    }
                    else
                    {
                        this.Close();
                    }
                });
            }
        }

        private void Frm_Validando_Datos_Load(object sender, EventArgs e)
        {
            IniciarProgreso();
        }
    }
}
