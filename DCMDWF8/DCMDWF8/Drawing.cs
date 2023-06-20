using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMDWF8
{
    /// <summary>
    /// This initialises form Drawing that is an inheritence of class Form.
    /// This form creates a small drawing that was given in the given task
    /// </summary>
    public partial class Drawing : Form
    {
        public Drawing()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method completely creates the drawing.
        /// At first we create a bunch of pens that have the colours of the given rhombuses.
        /// Then we have creation of additional counters "Count" and "Divi" 
        /// Afterwards we create and initialise a new graphics path and set it to fill mode
        /// Then we have 4 regions. Each region corresponds to a given colour of rectangle
        /// They fill them up using different loops.
        /// </summary>
        /// <param name="sender"> Not used</param>
        /// <param name="e"> Not used</param>
        private void Drawing_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            SolidBrush penDP = new SolidBrush(Color.FromArgb(255, (byte)102, (byte)46, (byte)147));
            SolidBrush penMag = new SolidBrush(Color.FromArgb(255, (byte)203, (byte)21, (byte)140));
            SolidBrush penSky = new SolidBrush(Color.FromArgb(255, (byte)86, (byte)197, (byte)242));
            SolidBrush penDarkSky = new SolidBrush(Color.FromArgb(255, (byte)0, (byte)178, (byte)242));

            int count = 0;
            int divi = 0;


            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.FillMode = FillMode.Winding;

            #region DarkSky
            for (int i = 0; i != 3; i++)
            {
                divi = -i;
                while (count != (i*2+1))
                {

                    graphicsPath.AddLine(475 + divi * 50, 425 + i * 50, 500 + divi * 50, 400 + i * 50);
                    graphicsPath.AddLine(500 + divi * 50, 400 + i * 50, 525 + divi * 50, 425 + i * 50);
                    graphicsPath.AddLine(525 + divi * 50, 425 + i * 50, 500 + divi * 50, 450 + i * 50);
                    graphicsPath.AddLine(500 + divi * 50, 450 + i * 50, 475 + divi * 50, 425 + i * 50);

                    Region region = new Region(graphicsPath);

                    g.FillRegion(penDarkSky, region);
                    graphicsPath.Reset();
                    count++;
                    divi++;
                }
                count = 0;

            }


            #endregion

            #region purples
            //vertical
            for (int i = 0; i !=4 ; i++)
            {
                graphicsPath.AddLine(475, 475 + i * 50, 500, 450 + i * 50);
                graphicsPath.AddLine(500, 450 + i * 50, 525, 475 + i * 50);
                graphicsPath.AddLine(525, 475 + i * 50, 500, 500 + i * 50);
                graphicsPath.AddLine(500, 500 + i * 50, 475, 475 + i * 50);

                Region region = new Region(graphicsPath);

                g.FillRegion(penDP, region);
                graphicsPath.Reset();
            }
            //horizonal
            for (int i = -1; i != 2; i++)
            {
                graphicsPath.AddLine(475 + i * 50, 575, 500 + i * 50, 550);
                graphicsPath.AddLine(500 + i * 50, 550, 525 + i * 50, 575);
                graphicsPath.AddLine(525 + i * 50, 575, 500 + i * 50, 600);
                graphicsPath.AddLine(500 + i * 50, 600, 475 + i * 50, 575);

                Region region = new Region(graphicsPath);

                g.FillRegion(penDP, region);
                graphicsPath.Reset();
            }
            #endregion

            #region Sky
            int height = 1;
            for (int i = 0; i != 3; i++)
            {
                if (i != 2)
                {
                    divi = -i - 1;
                }
                else
                {
                    divi = -2;
                }
                
                while (count != (height * 2) && count < 4)
                {

                    graphicsPath.AddLine(500 + divi * 50, 450 + i * 50, 525 + divi * 50, 425 + i * 50);
                    graphicsPath.AddLine(525 + divi * 50, 425 + i * 50, 550 + divi * 50, 450 + i * 50);
                    graphicsPath.AddLine(550 + divi * 50, 450 + i * 50, 525 + divi * 50, 475 + i * 50);
                    graphicsPath.AddLine(525 + divi * 50, 475 + i * 50, 500 + divi * 50, 450 + i * 50);

                    Region region = new Region(graphicsPath);

                    g.FillRegion(penSky, region);
                    graphicsPath.Reset();
                    count++;
                    divi++;
                }
                height++;
                count = 0;

            }


            #endregion

            #region Magenta
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    graphicsPath.AddLine(450 + j * 50, 550 + i * 50, 475 + j * 50, 575 + i * 50);
                    graphicsPath.AddLine(475 + j * 50, 575 + i * 50, 500 + j * 50, 550 + i * 50);
                    graphicsPath.AddLine(500 + j * 50, 550 + i * 50, 475 + j * 50, 525 + i * 50);
                    graphicsPath.AddLine(475 + j * 50, 525 + i * 50, 450 + j * 50, 550 + i * 50);

                    Region region = new Region(graphicsPath);

                    g.FillRegion(penMag, region);
                    graphicsPath.Reset();
                }
            }


            #endregion

        }
    }
}
