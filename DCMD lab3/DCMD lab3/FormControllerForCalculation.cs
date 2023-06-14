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

        /// <summary>
        /// Handles the click of the button, calling the SolveEquation function with the first input parametre that is equal to pressed radiobutton.
        /// </summary>
        private void btn2Click(object sender, EventArgs e)
        {
            int num = 1;
            if (radioButton1.Checked == true)
            {
                num = 1;
            }
            if (radioButton2.Checked == true)
            {
                num = 2;
            }
            if (radioButton3.Checked == true)
            {
                num = 3;
            }


            MessageBox.Show(Program.SolveEquations(num, Convert.ToDouble(tbXValue.Text), Convert.ToDouble(tbYValue.Text)));
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
        /// Handles the inputs into textboxes. If the input isn't a number or a decimal point or a minus, it won't allow you to input it
        /// </summary>
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            // only allow one minus symbol
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
