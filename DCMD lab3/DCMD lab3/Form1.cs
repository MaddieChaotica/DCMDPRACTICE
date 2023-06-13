using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMD_lab3
{
    public partial class calculateFunctions : Form
    {
        public calculateFunctions()
        {
            InitializeComponent();
        }

        private void frmMain(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the click of the btn1, calling the SolveEquation function with the first input parametre of 1.
        /// </summary>
        private void btn1Click(object sender, EventArgs e)
        {
            MessageBox.Show(Program.SolveEquations(1, Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }
        /// <summary>
        /// Handles the click of the btn2, calling the SolveEquation function with the first input parametre of 2.
        /// </summary>
        private void btn2Click(object sender, EventArgs e)
        {
            MessageBox.Show(Program.SolveEquations(2, Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }
        /// <summary>
        /// Handles the click of the btn3, calling the SolveEquation function with the first input parametre of 3.
        /// </summary>
        private void btn3Click(object sender, EventArgs e)
        {
            MessageBox.Show(Program.SolveEquations(3, Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the inputs into textboxes. If the input isn't a number or a decimal point, it won't allow you to input it
        /// </summary>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Handles the inputs into textboxes. If the input isn't a number or a decimal point, it won't allow you to input it
        /// </summary>
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
