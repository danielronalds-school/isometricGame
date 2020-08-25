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

        Math math = new Math();

        Grid grid = new Grid();

        List<IsometricTile> tiles = new List<IsometricTile>();

        public Form1()
        {
            InitializeComponent();

            tiles.Add(new IsometricTile(grid.A1, "A1"));
            tiles.Add(new IsometricTile(grid.A2, "A2"));
            tiles.Add(new IsometricTile(grid.A3, "A3"));
            tiles.Add(new IsometricTile(grid.A4, "A4"));
            tiles.Add(new IsometricTile(grid.A5, "A5"));
            tiles.Add(new IsometricTile(grid.A6, "A6"));

            tiles.Add(new IsometricTile(grid.B1, "B1"));
            //tiles.Add(new IsometricTile(grid.B2, "B2"));
            //tiles.Add(new IsometricTile(grid.B3, "B3"));
            //tiles.Add(new IsometricTile(grid.B4, "B4"));
            //tiles.Add(new IsometricTile(grid.B5, "B5"));
            tiles.Add(new IsometricTile(grid.B6, "B6"));

            tiles.Add(new IsometricTile(grid.C1, "C1"));
            //tiles.Add(new IsometricTile(grid.C2, "C2"));
            tiles.Add(new IsometricTile(grid.C3, "C3"));
            tiles.Add(new IsometricTile(grid.C4, "C4"));
            //tiles.Add(new IsometricTile(grid.C5, "C5"));
            tiles.Add(new IsometricTile(grid.C6, "C6"));

            tiles.Add(new IsometricTile(grid.D1, "D1"));
            //tiles.Add(new IsometricTile(grid.D2, "D2"));
            tiles.Add(new IsometricTile(grid.D3, "D3"));
            tiles.Add(new IsometricTile(grid.D4, "D4"));
            //tiles.Add(new IsometricTile(grid.D5, "D5"));
            tiles.Add(new IsometricTile(grid.D6, "D6"));

            tiles.Add(new IsometricTile(grid.E1, "E1"));
            //tiles.Add(new IsometricTile(grid.E2, "E2"));
            //tiles.Add(new IsometricTile(grid.E3, "E3"));
            //tiles.Add(new IsometricTile(grid.E4, "E4"));
            //tiles.Add(new IsometricTile(grid.E5, "E5"));
            tiles.Add(new IsometricTile(grid.E6, "E6"));

            tiles.Add(new IsometricTile(grid.F1, "F1"));
            tiles.Add(new IsometricTile(grid.F2, "F2"));
            tiles.Add(new IsometricTile(grid.F3, "F3"));
            tiles.Add(new IsometricTile(grid.F4, "F4"));
            tiles.Add(new IsometricTile(grid.F5, "F5"));
            tiles.Add(new IsometricTile(grid.F6, "F6"));
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            foreach(IsometricTile tile in tiles)
            {
                tile.drawTile(g);
            }
        }

        private void refreshScreen_Tick(object sender, EventArgs e)
        {
            Canvas.Invalidate();
        }
    }
}
