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

        GridMap gridmap = new GridMap();

        public Renderer()
        {
            loadIsometricGrid();
            loadIsometricGridTwo();

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
            for (int i = 0; i < grid.GridSize; i++) // 2D
            {
                if (gridmap.aRow[i] != "" && gridmap.aRow[i] != "0" && gridmap.aRow[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.A[i], "A" + i));
                }

                if (gridmap.bRow[i] != "" && gridmap.bRow[i] != "0" && gridmap.bRow[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.B[i], "B" + i));
                }

                if (gridmap.cRow[i] != "" && gridmap.cRow[i] != "0" && gridmap.cRow[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.C[i], "C" + i));
                }

                if (gridmap.dRow[i] != "" && gridmap.dRow[i] != "0" && gridmap.dRow[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.D[i], "D" + i));
                }

                if (gridmap.eRow[i] != "" && gridmap.eRow[i] != "0" && gridmap.eRow[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.E[i], "E" + i));
                }

                if (gridmap.fRow[i] != "" && gridmap.fRow[i] != "0" && gridmap.fRow[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.F[i], "F" + i));
                }

                if (gridmap.gRow[i] != "" && gridmap.gRow[i] != "0" && gridmap.gRow[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.G[i], "G" + i));
                }
            }
        }

        private void loadIsometricGridTwo()
        {
            for (int i = 0; i < grid.GridSize; i++)
            {
                if(gridmap.a2Row[i] != "" && gridmap.a2Row[i] != "0" && gridmap.a2Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.A2[i], "A2" + i));
                }

                if (gridmap.b2Row[i] != "" && gridmap.b2Row[i] != "0" && gridmap.b2Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.B2[i], "B2" + i));
                }

                if (gridmap.c2Row[i] != "" && gridmap.c2Row[i] != "0" && gridmap.c2Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.C2[i], "C2" + i));
                }

                if (gridmap.d2Row[i] != "" && gridmap.d2Row[i] != "0" && gridmap.d2Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.D2[i], "D2" + i));
                }

                if (gridmap.e2Row[i] != "" && gridmap.e2Row[i] != "0" && gridmap.e2Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.E2[i], "E2" + i));
                }

                if (gridmap.f2Row[i] != "" && gridmap.f2Row[i] != "0" && gridmap.f2Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.F2[i], "F2" + i));
                }

                if (gridmap.g2Row[i] != "" && gridmap.g2Row[i] != "0" && gridmap.g2Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.G2[i], "G2" + i));
                }
            }
        }
    }
}
