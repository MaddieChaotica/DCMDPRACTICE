using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMDWF5
{
    public partial class LineCounter : Form
    {
        /// <summary>
        ///  Some Global variables that are need inside of a function
        ///  Ind is an index value that works like a counter
        ///  s is just a string for in-between calculations
        /// </summary>
        int ind = 0;
        string s;
        public LineCounter()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handels the Activation of the button.
        /// When The button is activated, it gets the text of the text box and puts it into a string
        /// After that it starts a loop that detects spaces. Each space is equal to a word.
        /// It outputs that counter as a messagebox.
        /// </summary>
        private void btnLineCntActivator_Click(object sender, EventArgs e)
        {
            string str = (String)theLineBox.Items[theLineBox.SelectedIndex];
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == ' ' && i != str.Length)
                {
                    counter++;
                }

            }


            MessageBox.Show("Your line has "+ Convert.ToString(counter) + " words");

        }
        /// <summary>
        /// Detects each key press user makes.
        /// If the key press is an enter, it increases the index ind value by one and also add an empty object to the box
        /// If user pressed anything else, it inputs it into the listbox
        /// </summary>
        private void lstbxTheLineBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                ind++;
                theLineBox.Items.Add(" ");
            }
            else 
            {
                s = Convert.ToString(theLineBox.Items[ind]);
                theLineBox.Items.Remove(s);
                s = s + e.KeyChar;
                theLineBox.Items.Insert(ind, s);
            }
            
            
 
        }

        /// <summary>
        /// Creates an empty object when the form loads. 
        /// Needed to ease the functioning of the program
        /// </summary>
        private void LineCounter_Load(object sender, EventArgs e)
        {
            theLineBox.Items.Add(" ");

        }
    }
}
