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
        int ind = 0;
        string s;
        public LineCounter()
        {
            InitializeComponent();
        }

        private void lineCntActivator_Click(object sender, EventArgs e)
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

        private void LineCounter_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void theLineBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void LineCounter_Load(object sender, EventArgs e)
        {
            theLineBox.Items.Add(" ");

        }
    }
}
