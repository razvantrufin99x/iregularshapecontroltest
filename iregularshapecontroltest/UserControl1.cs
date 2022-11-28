using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace iregularshapecontroltest
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public bool ismd = false;
        private void UserControl1_Load(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            Point[] pointsA = new Point[]
{
new Point(0, 0),
new Point(40, 60),
new Point(this.Width - 100, 10)
};
            path.AddCurve(pointsA);
            Point[] pointsB = new Point[]
{
new Point(this.Width - 40, this.Height - 60),
new Point(this.Width, this.Height),
new Point(10, this.Height)
};
            path.AddCurve(pointsB);
            path.CloseAllFigures();
            this.Region = new Region(path);
        }

        private void UserControl1_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = true;
        }

        private void UserControl1_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = false;
        }

        private void UserControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd == true)
            {
                this.Left += e.X;
                this.Top += e.Y;
            }
        }
        }
    }

