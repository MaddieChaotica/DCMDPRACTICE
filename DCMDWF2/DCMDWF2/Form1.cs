using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMDWF2
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// The creation of new form.
        /// </summary>

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The funcetion that handels the click on the button
        /// </summary>
        private void btnClickCalculateMagical(object sender, EventArgs e)
        {
            MessageBox.Show(Program.FormulaeCalculation());

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
