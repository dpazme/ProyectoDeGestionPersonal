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

namespace ProyectoDeGestionPersonal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuración del ToolTip
           
            toolTip1.AutomaticDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.IsBalloon = true;

            // Asociar el ToolTip al botón "Guardar"
            toolTip1.SetToolTip(btnGuardar, "Guardar los cambios");

            timer1.Start();
          
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panelDatos.Location = new Point((this.Width / 2 - panelDatos.Width / 2),
              (this.Height - panelDatos.Height) / 2);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateTimePicker1.Value= monthCalendar1.SelectionStart;

        }

        private void trackBarSatisfaccion_Scroll(object sender, EventArgs e)
        {
            lblnumeracion.Text = trackBarSatisfaccion.Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString();
        }
    }
}
