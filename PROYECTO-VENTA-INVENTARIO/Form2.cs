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
    public partial class FormPRINCIPAL : Form
    {
        public FormPRINCIPAL()
        {
            InitializeComponent();
        }

        private void _Load(object sender, EventArgs e)
        {
            MODULOS MODULOS = new MODULOS();
        }

        private void FormPRINCIPAL_Load(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario (Form2)
            MODULOS MODULOS = new MODULOS();
            MODULOS.StartPosition = FormStartPosition.CenterParent;

            // Mostrar el Formulario 2 como un cuadro de diálogo (bloqueando la interacción con el Formulario 1)
            MODULOS.ShowDialog();
            // Mostrar el segundo formulario encima del primero
            

        }
      // ESTE CODIGO AL TOCAR MINIMIZAR DEL FROM FROMPRINCIPAL DE FONDO SE VA A MINIMIZAR CON EL FRON MODULOS 
        private void FormPRINCIPAL_Resize(object sender, EventArgs e)
        {
            
            if (WindowState == FormWindowState.Minimized)
            {
                // Obtener una referencia al Formulario 2
                MODULOS MODULOS = Application.OpenForms["MODULOS"] as MODULOS;
                if (MODULOS != null)
                {
                    // Minimizar el Formulario 2
                    MODULOS.WindowState = FormWindowState.Minimized;
                }
            }
        }
    }
}
