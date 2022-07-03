using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABOR_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("PROFE\nTuve problemas con la electricidad, se me fue en medio desarrollo del Lab, es por eso\n" +
                "que la mayoria de procesos quedaron a medias. Lo siento :(");
        }

        private void btnRegistrarTrabajador_Click(object sender, EventArgs e)
        {
            PantallaRegistrar pr = new PantallaRegistrar();
            pr.Visible = true;
            Form1 f1 = new Form1();
            f1.Visible = false;

        }

        private void btnDatosPlanilla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("POR FAVOR INGRESE EL NUMERO DE IDENTIFICACION DEL USUARIO");
            DatosTrabajador oDatosTrabajador = new DatosTrabajador();
            oDatosTrabajador.Show();
            //oDatosTrabajador.Visible = true;
        }
    }
}
