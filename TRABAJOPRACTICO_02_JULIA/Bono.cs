using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABAJOPRACTICO_02_JULIA
{
    public partial class Bono : Form
    {
        public Bono()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double total = 0;
            double sueldo = Convert.ToDouble(txtSueldo.Text);

            if (cmbSexo.SelectedIndex == 1)
            {
                double bono = sueldo * 0.3;
            }



        }
    }
}
