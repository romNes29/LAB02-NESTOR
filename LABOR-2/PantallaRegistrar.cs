using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace LABOR_2
{

    public partial class PantallaRegistrar : Form
    {
        private Procesos procesos = new Procesos();

        public PantallaRegistrar()
        {
            InitializeComponent();
        }

        private void PantallaRegistrar_Load(object sender, EventArgs e)
        {
            validaFranja();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string identificacion = txtIdentificacion.Text;
            string nombre = txtNombre.Text;
            string apellidoUno = txtPrimerApellido.Text;
            string apellidoDos = txtSegundoApellido.Text;
            string edad = txtEdad.Text;
            string tipoCargo = txtCargo.Text;
            double horasDiaTrabajadas = double.Parse(txtHorasDia.Text);
            double horasNocheTrabajadas = double.Parse(txtHorasNoche.Text);
            string franja = cbxPuesto.SelectedItem.ToString();
            if (validaFranja() == true)
            {
                procesos.registrarTrabajador(identificacion, nombre, apellidoUno, apellidoDos, edad, tipoCargo, horasDiaTrabajadas, horasNocheTrabajadas, franja);
            }
           
        }

        public bool validaFranja()
        {
           
            bool aprobar = false;
            if (cbxPuesto.SelectedItem.ToString().Equals("Diurna"))
            {
                
                txtHorasNoche.Enabled = false;
                txtHorasNoche.Text = "0";
                aprobar = true;
            }
            else if (cbxPuesto.SelectedItem.ToString().Equals("Nocturna"))
            {
                txtHorasDia.Enabled = false;
                txtHorasDia.Text = "0";
                aprobar = true;
            }
            else if (cbxPuesto.SelectedItem.ToString().Equals(""))
            {
                MessageBox.Show("POR FAVOR SELECCIONE UNA OPCIÓN.");
                aprobar = false;
            }
            else
            {
                aprobar = true;
            }
            return aprobar;
        }
    }
}
