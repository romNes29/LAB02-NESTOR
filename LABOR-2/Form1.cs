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

        }

        private void btnRegistrarTrabajador_Click(object sender, EventArgs e)
        {
            PantallaRegistrar pr = new PantallaRegistrar();
            pr.Visible = true;
            Form1 f1 = new Form1();
            f1.Visible = false;

        }
    }
}
