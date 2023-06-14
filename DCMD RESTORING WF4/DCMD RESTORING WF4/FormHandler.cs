using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMDWF4
{
    public partial class FormHandler : Form
    {
        public FormHandler()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Activator click handler. 
        /// It gets all the values from text boxes and checks if the progam will halt
        /// If it doesn't halt it gives out an error
        /// If it does halt it proceeds with a loop that pushes all the values of x to a function that solves the equation
        /// </summary>
        private void btn1Activator_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(X0Value.Text);
            double xk = Convert.ToDouble(XkValue.Text);
            double dx = Convert.ToDouble(DxValue.Text);
            double a = Convert.ToDouble(aValue.Text);
            double b = Convert.ToDouble(bValue.Text);
            double x = x0;
            int count = 0;
            

            if (Math.Abs(xk - (x0 + dx)) < Math.Abs(xk - x0))
            {
                AnswerBox.Items.Insert(0, Program.equationTabbySolver(x, a, b));
                while (x != xk)
                {
                    x = Math.Round(x + dx, 2);
                    count++;
                    AnswerBox.Items.Insert(count, Program.equationTabbySolver(x, a, b));
                }
            }
            else
            {
                MessageBox.Show("Error! With inputed parametres you cannot achive xk");
            }
            AnswerBox.Items.Insert(0, "Выполнил Бурыкин Дмитрий Алексеневич, студент группы 2ИС");


        }

        #region InputHandles
        /// <summary>
        /// Handles the inputs into textboxes. If the input isn't a number or a decimal point or a minus, it won't allow you to input it
        /// </summary>
        private void X0Value_KeyPress(object sender, KeyPressEventArgs e)
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
        /// <summary>
        /// Handles the inputs into textboxes. If the input isn't a number or a decimal point or a minus, it won't allow you to input it
        /// </summary>
        private void XkValue_KeyPress(object sender, KeyPressEventArgs e)
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
        /// <summary>
        /// Handles the inputs into textboxes. If the input isn't a number or a decimal point or a minus, it won't allow you to input it
        /// </summary>
        private void DxValue_KeyPress(object sender, KeyPressEventArgs e)
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
        /// <summary>
        /// Handles the inputs into textboxes. If the input isn't a number or a decimal point or a minus, it won't allow you to input it
        /// </summary>
        private void aValue_KeyPress(object sender, KeyPressEventArgs e)
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
        /// <summary>
        /// Handles the inputs into textboxes. If the input isn't a number or a decimal point or a minus, it won't allow you to input it
        /// </summary>
        private void bValue_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion
        
    }
}
