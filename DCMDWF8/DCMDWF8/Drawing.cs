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
    public partial class Drawing : Form
    {
        public Drawing()
        {
            InitializeComponent();
        }

        private void Drawing_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            //Pen penDP = new Pen(Color.FromArgb(109, 41, 150, 255),50);
            SolidBrush penDP = new SolidBrush(Color.FromArgb(109, 41, 150, 255));
            /*
            int[] points = new int[4];
            points[0] = 200;
            points[1] = 300;
            points[2] = 400;
            points[3] = 500;
            */
            GraphicsPath graphicsPath = new GraphicsPath();    
            graphicsPath.FillMode = FillMode.Winding;
            graphicsPath.AddLine(100,100,200,200);
            graphicsPath.AddLine(200, 200, 300, 100);
            graphicsPath.AddLine(300, 100, 200, 0);
            graphicsPath.AddLine(200, 0, 100, 100);

            Region region = new Region(graphicsPath);

            //g.FillRectangle(penDP,100,200,300,400);
            g.FillRegion(penDP,region);

        }
    }
}
