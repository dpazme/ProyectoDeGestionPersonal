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

            // Asociar el ToolTip al botón GUARDAD
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Mostrar un MessageBox con el resumen de los datos
            string resumen = $"Nombre: {txtNombre.Text}\n" +
                             $"Apellidos: {txtApellidos.Text}\n" +
                             $"Dirección: {txtDireccion.Text}\n" +
                             $"Correo: {txtCorreo.Text}\n" +
                             $"Género: {(rboMasculino.Checked ? "Masculino" : rboFemenino.Checked ? "Femenino" :  "Otro")}\n" +
                             $"Fecha de Nacimiento: {monthCalendar1.SelectionStart.ToShortDateString()}\n" +
                             $"Edad: {numericUpDow.Value}\n" +
                             $"Boletín: {(chkSi.Checked ? "Sí" : "No")}\n" +
                             $"Hobbies: {string.Join(", ", chklHobbies.CheckedItems.Cast<string>())}\n" +
                             $"País: {cboPaisResidencia.SelectedItem}\n" +
                             $"Satisfacción: {trackBarSatisfaccion.Value}/10";

            MessageBox.Show(resumen, "Resumen de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            rboMasculino.Checked = false;
            rboFemenino.Checked = false;
            rboOtro.Checked = false;
            numericUpDow.Value = 1;
            monthCalendar1.SetDate(DateTime.Today);
            chkSi.Checked = false;
            chkNo.Checked = false;
            foreach (int i in chklHobbies.CheckedIndices)
            {
                chklHobbies.SetItemCheckState(i, CheckState.Unchecked);
            }
            cboPaisResidencia.SelectedIndex = -1;
            trackBarSatisfaccion.Value = 1;

            // Mostrar MessageBox indicando que los campos fueron limpiados
            MessageBox.Show("Los campos han sido borrados.", "Formulario Limpio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }
    }
}
