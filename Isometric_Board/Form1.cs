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

        string[] aRow = { "f", "f", "f", "f", "f", "f" };
        string[] bRow = { "f", "f", "f", "f", "f", "f" };
        string[] cRow = { "s", "f", "f", "f", "f", "f" };
        string[] dRow = { "s", "f", "f", "f", "f", "f" };
        string[] eRow = { "s", "f", "f", "f", "f", "f" };
        string[] fRow = { "f", "s", "f", "e", "w", "f" };

        public Form1()
        {
            InitializeComponent();

            loadIsometricGrid();
        }

        private void loadIsometricGrid()
        {
            for (int i = 0; i < grid.A.Length; i++) // A
            {
                if(aRow[i] != "")
                {
                    tiles.Add(new IsometricTile(grid.A[i], "A" + i));
                }
            }

            for (int i = 0; i < grid.B.Length; i++) // B
            {
                if (bRow[i] != "")
                {
                    tiles.Add(new IsometricTile(grid.B[i], "B" + i));
                }
            }

            for (int i = 0; i < grid.C.Length; i++) // C
            {
                if (cRow[i] != "")
                {
                    tiles.Add(new IsometricTile(grid.C[i], "C" + i));
                }
            }

            for (int i = 0; i < grid.D.Length; i++) // D
            {
                if (dRow[i] != "")
                {
                    tiles.Add(new IsometricTile(grid.D[i], "D" + i));
                }
            }

            for (int i = 0; i < grid.E.Length; i++) // E
            {
                if (eRow[i] != "")
                {
                    tiles.Add(new IsometricTile(grid.E[i], "E" + i));
                }
            }

            for (int i = 0; i < grid.F.Length; i++) // F
            {
                if (fRow[i] != "")
                {
                    tiles.Add(new IsometricTile(grid.F[i], "F" + i));
                }
            }
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
