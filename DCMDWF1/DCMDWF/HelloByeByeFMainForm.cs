using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMDWF
{

    public partial class HelloByeByeFMainForm : Form
    {
        /// <summary>
        ///  This is the method that crets the form
        /// </summary>
        public HelloByeByeFMainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  This is the load method that runs each time the form itself loads
        ///  It changes the names and colorus of both buttons 
        ///  It also changes the text and font style and size of the label1
        ///  Also changes the background colour
        /// </summary>
        private void Main_Form(object sender, EventArgs e)
        {
            BackColor = Color.AliceBlue;
            button1.Text = "Hello! 👋";
            button1.ForeColor = Color.Yellow;
            button1.BackColor = Color.Red;

            button2.Text = "Bye-bye! o7";
            button2.ForeColor = Color.LightYellow;
            button2.BackColor = Color.DarkBlue;

            Font newFont = new Font("Comic Sans MS", 35, FontStyle.Regular);
            label1.Font = newFont;
            label1.Text = "Begging work";

            BackColor = Color.Pink;


        }

        /// <summary>
        ///  This is Hello_button click method, it runs only when someone clicks button1
        ///  The method itself changes the text of the label2
        /// </summary>

        private void Hello_Button(object sender, EventArgs e)
        {

            label1.Text = "Hello! I'm inside of your walls!";
        }

        /// <summary>
        ///  This is the Byebye_Button click method, it runs only when someone pressed button2
        ///  The method itself changes the text of the label1
        /// </summary>

        private void Byebye_Button(object sender, EventArgs e)
        {
            label1.Text = "Bye-bye~ I'll make sure to not let you hide under your bed next time~";
        }

    }
}
