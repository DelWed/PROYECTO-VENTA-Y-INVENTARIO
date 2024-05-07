using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_VENTA_INVENTARIO
{
    public partial class MODULOS : Form
    {
        public MODULOS()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Desactivar la capacidad de cambiar el tamaño del formulario
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // O FormBorderStyle.FixedDialog

            // Centrar el formulario en la pantalla al ejecutarse
            this.StartPosition = FormStartPosition.CenterScreen;
            // Guardar la posición inicial del formulario
          


          
        }

        private void btninventario_Click(object sender, EventArgs e)
        {

        }

        private void MODULOS_FormClosing(object sender, FormClosingEventArgs e)
        {

            // Cerrar también el Formulario 1 cuando se cierre el Formulario 2

            FormPRINCIPAL FormPRINCIPAL = Application.OpenForms["FormPRINCIPAL"] as FormPRINCIPAL;
           
            if (FormPRINCIPAL != null)
            {
                FormPRINCIPAL.Close();
            }
        }
        // Código en el formulario secundario (Form2)



        private void MODULOS_Move(object sender, EventArgs e)
        {
          
        }
    }
}
