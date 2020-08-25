using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Isometric_Board
{
    class Renderer
    {
        Grid grid = new Grid();

        List<IsometricTile> tiles = new List<IsometricTile>();

        string[] aRow = { "f", "f", "f", "f", "f", "f", "f" };
        string[] bRow = { "f", "", "", "", "", "", "f" };
        string[] cRow = { "f", "", "", "", "", "", "f" };
        string[] dRow = { "f", "", "", "", "", "", "f" };
        string[] eRow = { "f", "", "", "", "", "", "f" };
        string[] fRow = { "f", "", "", "", "", "", "f" };
        string[] gRow = { "f", "f", "f", "f", "f", "f", "f" };

        public Renderer()
        {
            loadIsometricGrid();

            foreach (IsometricTile tile in tiles)
            {
                Console.WriteLine(tile.tileID);
            }
        }

        public void renderIsometricTiles(Graphics g)
        {
            foreach (IsometricTile tile in tiles)
            {
                tile.drawTile(g);
            }
        }

        private void loadIsometricGrid()
        {
            for (int i = 0; i < grid.A.Length; i++) // A
            {
                if (aRow[i] != "")
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

            for (int i = 0; i < grid.G.Length; i++) // G
            {
                if (gRow[i] != "")
                {
                    tiles.Add(new IsometricTile(grid.G[i], "G" + i));
                }
            }
        }
    }
}
