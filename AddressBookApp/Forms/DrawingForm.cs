using System;
using System.Drawing;
using System.Windows.Forms;

namespace AddressBookApp
{
    public partial class DrawingForm : Form
    {
        private bool isDrawing;
        private Point previousPoint;
        private Graphics graphics;

        public DrawingForm()
        {
            InitializeComponent();
            graphics = drawingPanel.CreateGraphics();
        }

        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                previousPoint = e.Location;
            }
        }

        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                Point currentPoint = e.Location;
                graphics.DrawLine(Pens.Black, previousPoint, currentPoint);
                previousPoint = currentPoint;
            }
        }

        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
            }
        }
    }
}
