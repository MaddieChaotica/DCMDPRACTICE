using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DCMDWF4
{
    public partial class GraphBuilder : Form
    {
        public GraphBuilder()
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
            double xMin = Convert.ToDouble(xMinValue.Text);
            double xMax = Convert.ToDouble(xMaxValue.Text);
            double step = Convert.ToDouble(stepValue.Text);
            double x = x0;
            double yMin = 999999;
            double yMax = -999999;

            derChart.ChartAreas[0].AxisX.Minimum = xMin;
            derChart.ChartAreas[0].AxisX.Maximum = xMax;
            derChart.ChartAreas[0].AxisX.Interval = step;
            
            int xDots = Convert.ToInt32(Math.Ceiling((xMax-xMin)/step)+1);

            double[] xPoints = new double[xDots];
            double[] yPoints = new double[xDots];

            int iMin = (int)Math.Floor(xMin);


            if (Math.Abs(xk - (x0 + dx)) < Math.Abs(xk - x0))
            {
                for (int i = iMin; i < xMax; i++)
                {
                    x = Math.Round(x + dx, 2);   
                    xPoints[Math.Abs(i)] = xMin + step * Math.Abs(i);
                    yPoints[Math.Abs(i)] = Program.equationTabbySolver(x, a, b); //Y Points on the chart
                    if (yPoints[Math.Abs(i)] < yMin) { yMin = yPoints[Math.Abs(i)]; }
                    if (yPoints[Math.Abs(i)] > yMax) { yMax = yPoints[Math.Abs(i)]; }
                }
            }
            else
            {
                MessageBox.Show("Error! With inputed parametres you cannot achive xk");
            }
            derChart.ChartAreas[0].AxisY.Minimum = yMin;
            derChart.ChartAreas[0].AxisY.Minimum = yMax;
            
            derChart.Series[0].Points.DataBindXY(xPoints, yPoints);


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

        /// <summary>
        /// Handles the inputs into textboxes. If the input isn't a number or a decimal point or a minus, it won't allow you to input it
        /// </summary>
        private void xMinValue_KeyPress(object sender, KeyPressEventArgs e)
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
        private void xMaxValue_KeyPress(object sender, KeyPressEventArgs e)
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
        private void stepValue_KeyPress(object sender, KeyPressEventArgs e)
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
            #endregion

        }
    }
}
