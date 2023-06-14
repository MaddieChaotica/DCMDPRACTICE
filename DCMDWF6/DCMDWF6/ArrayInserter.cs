using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DCMDWF6
{
    public partial class ArrayInserter : Form
    {

        public ArrayInserter()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// Initialisation of an array that is passed between methods
        /// </summary>
        int[] array = new int[0];
        /// <summary>
        /// Method that handles the click of the click of the number generator button.
        /// It generates random numbers and adds to the box on the left.
        /// The amount of generated numbers is equal to the value user inputted in the box
        /// </summary>
        private void numberGenerator_Click(object sender, EventArgs e)
        {
            int n = 0;
            try
            {
                n = Convert.ToInt32(nValue.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("INPUT THE DAMN VALUE IN THE DAMN BOX");
            }
            
            Random Randy = new Random();
            Array.Resize(ref array,n+1);

            int maxRandNum = 100;

            for (int i = 0; i < n; i++)
            {
                array[i] = Randy.Next(-Randy.Next(maxRandNum),Randy.Next(maxRandNum));
                inputBox.Items.Add("Array[" + (i+1) +"] = " + array[i]);
            }

        }
        /// <summary>
        /// Method that handles inputs into nValue box.
        /// It allows only digits to be inputed in them
        /// </summary>
        private void nValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Method that handles inputs into kValue box.
        /// It allows only digits to be inputed in them
        /// </summary>
        private void kValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Method that handles clicks on zeroButton
        /// When the button is clicked it fills up the box on the right with elements from the box on the left, but at position k it inserts 0
        /// </summary>
        private void zeroButton_Click(object sender, EventArgs e)
        {
            int n = 0;
            int k = 0;
            try
            {
                k = Convert.ToInt32(kValue.Text);
                n = Convert.ToInt32(nValue.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("INPUT THE DAMN VALUE IN THE DAMN BOX");
            }
            int ind = -1;

            for (int i = 0;i < n; i++)
            {
                ind++;
                if (i == k)
                {
                    outputBox.Items.Add("Array[" + (ind + 1) + "] = " + 0);
                    ind++;
                }
                if (i < n) 
                {
                    outputBox.Items.Add("Array[" + (ind + 1) + "] = " + array[i]);
                }
                

            }
        }
    }
}
