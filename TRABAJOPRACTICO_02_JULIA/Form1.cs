using Microsoft.VisualBasic;

namespace TRABAJOPRACTICO_02_JULIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensaje;
            mensaje = Interaction.InputBox("Introduce tu número");
            string mensajeComprobacion;
            mensajeComprobacion = Interaction.InputBox("Introduce tu número nuevamente para confirmar la recarga");

            if (mensaje == mensajeComprobacion)
            {
                grbDatos.Visible = true;
                grbDatos.Visible = true;
                lblnumero.Text = mensaje;
            }

            else
            {
                MessageBox.Show("Número equivocado, vuelve a intentarlo");
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int compania = cmbCompania.SelectedIndex;
            float total = 0;
            if (compania == 1)
            {
                grbCantidad.Visible = true;
                rdb30.Visible = true;
                rdb50.Visible = true;
                rdb100.Visible = true;
                rdb200.Visible = true;
                rdb500.Visible = true;

                if (rdb30.Checked == true)
                {
                    total = 30;
                    grbOutput.Visible = true;

                }

                if (rdb50.Checked == true)
                {
                    total = 50;
                    grbOutput.Visible = true;
                }

                if (rdb100.Checked == true)
                {
                    total = 150;
                    grbOutput.Visible = true;
                }

                if (rdb200.Checked == true)
                {
                    total = 300;
                    grbOutput.Visible = true;
                }

                if (rdb500.Checked == true)
                {
                    total = 1000;
                    grbOutput.Visible = true;
                }
            }
            if (compania == 2)
            {
                grbCantidad.Visible = true;
                rdb30.Visible = false;
                rdb50.Visible = false;
                rdb100.Visible = true;
                rdb200.Visible = true;
                rdb500.Visible = true;

                if (rdb100.Checked == true)
                {
                    total = 100;
                    grbOutput.Visible = true;
                }

                if (rdb200.Checked == true)
                {
                    total = 200;
                    grbOutput.Visible = true;
                }

                if (rdb500.Checked == true)
                {
                    total = 500;
                    grbOutput.Visible = true;
                }
            }
            if (compania == 3)
            {
                grbCantidad.Visible = true;
                rdb30.Visible = true;
                rdb50.Visible = true;
                rdb100.Visible = true;
                rdb200.Visible = true;
                rdb500.Visible = true;

                if (rdb30.Checked == true)
                {
                    total = 30;
                    grbOutput.Visible = true;

                }

                if (rdb50.Checked == true)
                {
                    total = 50;
                    grbOutput.Visible = true;
                }

                if (rdb100.Checked == true)
                {
                    total = 100;
                    grbOutput.Visible = true;
                }

                if (rdb200.Checked == true)
                {
                    total = 200;
                    grbOutput.Visible = true;
                }

                if (rdb500.Checked == true)
                {
                    total = 500;
                    grbOutput.Visible = true;
                }
            }

            lblRecargas.Text = ("El número " + lblnumero.Text + " acaba de recargar $" + total);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rdb30.Visible = false;
            rdb50.Visible = false;
            rdb100.Visible = false;
            rdb200.Visible = false;
            rdb500.Visible = false;

            grbCantidad.Visible = false;
            grbDatos.Visible = false;
            grbOutput.Visible = false;

            cmbCompania.SelectedIndex = 0; 
        }
    }
}
