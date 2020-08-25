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

        string[] aRow = { "f", ".", ".", ".", ".", ".", "f" };
        string[] bRow = { ".", ".", ".", ".", ".", ".", "f" };
        string[] cRow = { ".", ".", ".", ".", ".", ".", "f" };
        string[] dRow = { ".", ".", ".", ".", ".", ".", "f" };
        string[] eRow = { ".", ".", ".", ".", ".", ".", "f" };
        string[] fRow = { ".", ".", ".", ".", ".", ".", "f" };
        string[] gRow = { "f", "f", "f", "f", "f", "f", "f" };

        public Renderer()
        {
            loadIsometricGrid();

            tiles.Add(new IsometricTile(new Point(grid.A[0].X, grid.A[0].Y - 23), "Test"));

            foreach (IsometricTile tile in tiles)
            {
                Console.WriteLine(tile.tileID);
            }

            Console.WriteLine("Total tiles: " + tiles.Count());
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
            for (int i = 0; i < grid.A.Length; i++) // 2D
            {
                if (aRow[i] != "" && aRow[i] != "0" && aRow[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.A[i], "A" + i));
                }

                if (bRow[i] != "" && bRow[i] != "0" && bRow[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.B[i], "B" + i));
                }

                if (cRow[i] != "" && cRow[i] != "0" && cRow[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.C[i], "C" + i));
                }

                if (dRow[i] != "" && dRow[i] != "0" && dRow[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.D[i], "D" + i));
                }

                if (eRow[i] != "" && eRow[i] != "0" && eRow[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.E[i], "E" + i));
                }

                if (fRow[i] != "" && fRow[i] != "0" && fRow[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.F[i], "F" + i));
                }

                if (gRow[i] != "" && gRow[i] != "0" && gRow[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.G[i], "G" + i));
                }
            }
        }
    }
}
