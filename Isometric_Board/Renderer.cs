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
        public Grid grid = new Grid();

        public Grid_v2 grid2 = new Grid_v2();

        public List<IsometricTile> tiles = new List<IsometricTile>();

        public GridMap gridmap = new GridMap();

        public Renderer()
        {
            loadIsometricGrid();
            loadIsometricGridTwo();
            loadIsometricGridThree();
            loadIsometricGridFour();
            loadIsometricGridFive();
            loadIsometricGridSix();
            loadIsometricGridSeven();

            foreach(Point[,] layer in grid2.Layers)
            {
                for (int i = 0; i < grid2.gridSize; i++)
                {
                    for (int x = 0; x < grid2.gridSize; x++)
                    {
                        tiles.Add(new IsometricTile(layer[x, i], "test", false));
                    }
                }
            }

            foreach (IsometricTile tile in tiles)
            {
                Console.WriteLine(tile.tileID);
            }

            Console.WriteLine("Total tiles: " + tiles.Count());
        }

        public void Render(Graphics g, Player player)
        {
            bool drawnPlayer = false;

            foreach (IsometricTile tile in tiles)
            {
                tile.drawTile(g);


                //if (tile.tileID == "D23" && !drawnPlayer) // Draws player so that it appears under items that are on a taller layer
                //{
                //    player.drawPlayer(g);
                //    drawnPlayer = true;
                //}
            }
        }

        private void loadIsometricGrid()
        {
            for (int i = 0; i < grid.GridSize; i++) // 2D
            {
                if (gridmap.aRow[i] != "" && gridmap.aRow[i] != "0" && gridmap.aRow[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.A[i], "A" + i, false));
                }

                if (gridmap.bRow[i] != "" && gridmap.bRow[i] != "0" && gridmap.bRow[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.B[i], "B" + i, false));
                }

                if (gridmap.cRow[i] != "" && gridmap.cRow[i] != "0" && gridmap.cRow[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.C[i], "C" + i, false));
                }

                if (gridmap.dRow[i] != "" && gridmap.dRow[i] != "0" && gridmap.dRow[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.D[i], "D" + i, false));
                }

                if (gridmap.eRow[i] != "" && gridmap.eRow[i] != "0" && gridmap.eRow[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.E[i], "E" + i, false));
                }

                if (gridmap.fRow[i] != "" && gridmap.fRow[i] != "0" && gridmap.fRow[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.F[i], "F" + i, false));
                }

                if (gridmap.gRow[i] != "" && gridmap.gRow[i] != "0" && gridmap.gRow[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.G[i], "G" + i, false));
                }
            }
        }

        private void loadIsometricGridTwo()
        {
            for (int i = 0; i < grid.GridSize; i++)
            {
                if(gridmap.a2Row[i] != "" && gridmap.a2Row[i] != "0" && gridmap.a2Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.A2[i], "A2" + i, true));
                }

                if (gridmap.b2Row[i] != "" && gridmap.b2Row[i] != "0" && gridmap.b2Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.B2[i], "B2" + i, true));
                }

                if (gridmap.c2Row[i] != "" && gridmap.c2Row[i] != "0" && gridmap.c2Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.C2[i], "C2" + i, true));
                }

                if (gridmap.d2Row[i] != "" && gridmap.d2Row[i] != "0" && gridmap.d2Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.D2[i], "D2" + i, true));
                }

                if (gridmap.e2Row[i] != "" && gridmap.e2Row[i] != "0" && gridmap.e2Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.E2[i], "E2" + i, true));
                }

                if (gridmap.f2Row[i] != "" && gridmap.f2Row[i] != "0" && gridmap.f2Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.F2[i], "F2" + i, true));
                }

                if (gridmap.g2Row[i] != "" && gridmap.g2Row[i] != "0" && gridmap.g2Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.G2[i], "G2" + i, true));
                }
            }
        }
        
        private void loadIsometricGridThree()
        {
            for (int i = 0; i < grid.GridSize; i++)
            {
                if (gridmap.a3Row[i] != "" && gridmap.a3Row[i] != "0" && gridmap.a3Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.A3[i], "A3" + i, false));
                }

                if (gridmap.b3Row[i] != "" && gridmap.b3Row[i] != "0" && gridmap.b3Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.B3[i], "B3" + i, false));
                }

                if (gridmap.c3Row[i] != "" && gridmap.c3Row[i] != "0" && gridmap.c3Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.C3[i], "C3" + i, false));
                }

                if (gridmap.d3Row[i] != "" && gridmap.d3Row[i] != "0" && gridmap.d3Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.D3[i], "D3" + i, false));
                }

                if (gridmap.e3Row[i] != "" && gridmap.e3Row[i] != "0" && gridmap.e3Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.E3[i], "E3" + i, false));
                }

                if (gridmap.f3Row[i] != "" && gridmap.f3Row[i] != "0" && gridmap.f3Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.F3[i], "F3" + i, false));
                }

                if (gridmap.g3Row[i] != "" && gridmap.g3Row[i] != "0" && gridmap.g3Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.G3[i], "G3" + i, false));
                }
            }
        }

        private void loadIsometricGridFour()
        {
            for (int i = 0; i < grid.GridSize; i++)
            {
                if (gridmap.a4Row[i] != "" && gridmap.a4Row[i] != "0" && gridmap.a4Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.A4[i], "A4" + i, false));
                }

                if (gridmap.b4Row[i] != "" && gridmap.b4Row[i] != "0" && gridmap.b4Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.B4[i], "B4" + i, false));
                }

                if (gridmap.c4Row[i] != "" && gridmap.c4Row[i] != "0" && gridmap.c4Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.C4[i], "C4" + i, false));
                }

                if (gridmap.d4Row[i] != "" && gridmap.d4Row[i] != "0" && gridmap.d4Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.D4[i], "D4" + i, false));
                }

                if (gridmap.e4Row[i] != "" && gridmap.e4Row[i] != "0" && gridmap.e4Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.E4[i], "E4" + i, false));
                }

                if (gridmap.f4Row[i] != "" && gridmap.f4Row[i] != "0" && gridmap.f4Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.F4[i], "F4" + i, false));
                }

                if (gridmap.g4Row[i] != "" && gridmap.g4Row[i] != "0" && gridmap.g4Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.G4[i], "G4" + i, false));
                }
            }
        }

        private void loadIsometricGridFive()
        {
            for (int i = 0; i < grid.GridSize; i++)
            {
                if (gridmap.a5Row[i] != "" && gridmap.a5Row[i] != "0" && gridmap.a5Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.A5[i], "A5" + i, false));
                }

                if (gridmap.b5Row[i] != "" && gridmap.b5Row[i] != "0" && gridmap.b5Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.B5[i], "B5" + i, false));
                }

                if (gridmap.c5Row[i] != "" && gridmap.c5Row[i] != "0" && gridmap.c5Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.C5[i], "C5" + i, false));
                }

                if (gridmap.d5Row[i] != "" && gridmap.d5Row[i] != "0" && gridmap.d5Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.D5[i], "D5" + i, false));
                }

                if (gridmap.e5Row[i] != "" && gridmap.e5Row[i] != "0" && gridmap.e5Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.E5[i], "E5" + i, false));
                }

                if (gridmap.f5Row[i] != "" && gridmap.f5Row[i] != "0" && gridmap.f5Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.F5[i], "F5" + i, false));
                }

                if (gridmap.g5Row[i] != "" && gridmap.g5Row[i] != "0" && gridmap.g5Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.G5[i], "G5" + i, false));
                }
            }
        }

        private void loadIsometricGridSix()
        {
            for (int i = 0; i < grid.GridSize; i++)
            {
                if (gridmap.a6Row[i] != "" && gridmap.a6Row[i] != "0" && gridmap.a6Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.A6[i], "A6" + i, false));
                }

                if (gridmap.b6Row[i] != "" && gridmap.b6Row[i] != "0" && gridmap.b6Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.B6[i], "B6" + i, false));
                }

                if (gridmap.c6Row[i] != "" && gridmap.c6Row[i] != "0" && gridmap.c6Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.C6[i], "C6" + i, false));
                }

                if (gridmap.d6Row[i] != "" && gridmap.d6Row[i] != "0" && gridmap.d6Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.D6[i], "D6" + i, false));
                }

                if (gridmap.e6Row[i] != "" && gridmap.e6Row[i] != "0" && gridmap.e6Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.E6[i], "E6" + i, false));
                }

                if (gridmap.f6Row[i] != "" && gridmap.f6Row[i] != "0" && gridmap.f6Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.F6[i], "F6" + i, false));
                }

                if (gridmap.g6Row[i] != "" && gridmap.g6Row[i] != "0" && gridmap.g6Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.G6[i], "G6" + i, false));
                }
            }
        }

        private void loadIsometricGridSeven()
        {
            for (int i = 0; i < grid.GridSize; i++)
            {
                if (gridmap.a7Row[i] != "" && gridmap.a7Row[i] != "0" && gridmap.a7Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.A7[i], "A7" + i, false));
                }

                if (gridmap.b7Row[i] != "" && gridmap.b7Row[i] != "0" && gridmap.b7Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.B7[i], "B7" + i, false));
                }

                if (gridmap.c7Row[i] != "" && gridmap.c7Row[i] != "0" && gridmap.c7Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.C7[i], "C7" + i, false));
                }

                if (gridmap.d7Row[i] != "" && gridmap.d7Row[i] != "0" && gridmap.d7Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.D7[i], "D7" + i, false));
                }

                if (gridmap.e7Row[i] != "" && gridmap.e7Row[i] != "0" && gridmap.e7Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.E7[i], "E7" + i, false));
                }

                if (gridmap.f7Row[i] != "" && gridmap.f7Row[i] != "0" && gridmap.f7Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.F7[i], "F7" + i, false));
                }

                if (gridmap.g7Row[i] != "" && gridmap.g7Row[i] != "0" && gridmap.g7Row[i] != ".")
                {
                    tiles.Add(new IsometricTile(grid.G7[i], "G7" + i, false));
                }
            }
        }
    }
}
