using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isometric_Board
{
    public partial class Form1 : Form
    {
        Graphics g;

        Renderer renderer = new Renderer();

        public Form1()
        {
            InitializeComponent();
        }


        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            renderer.renderIsometricTiles(g);
        }

        private void refreshScreen_Tick(object sender, EventArgs e)
        {
            Canvas.Invalidate();
        }
    }
}
