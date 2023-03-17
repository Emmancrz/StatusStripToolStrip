using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statusStrip
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public double a, b, r;

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ejemplo para menú");
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);

            r = a + b;
            lblResultado.Text = "Resultado: " + r.ToString();

            slblValores.Text = "A=" + a.ToString() + ", B=" + b.ToString() + ";";
            slblOperacion.Text = "Suma;";
            slblResultado.Text = "Resultado=" + r.ToString() + ";";
        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);

            r = a - b;
            lblResultado.Text = "Resultado: " + r.ToString();

            slblValores.Text = "A=" + a.ToString() + ", B=" + b.ToString() + ";";
            slblOperacion.Text = "Resta;";
            slblResultado.Text = "Resultado=" + r.ToString() + ";";
        }

        private void multiplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);

            r = a * b;
            lblResultado.Text = "Resultado: " + r.ToString();

            slblValores.Text = "A=" + a.ToString() + ", B=" + b.ToString() + ";";
            slblOperacion.Text = "Multiplicación;";
            slblResultado.Text = "Resultado=" + r.ToString() + ";";
        }

        private void divisiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);

            r = a / b;
            lblResultado.Text = "Resultado: " + r.ToString();

            slblValores.Text = "A=" + a.ToString() + ", B=" + b.ToString() + ";";
            slblOperacion.Text = "División;";
            slblResultado.Text = "Resultado=" + r.ToString() + ";";
        }
    }
}
