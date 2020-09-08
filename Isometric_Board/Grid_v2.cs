using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Isometric_Board
{
    class Grid_v2
    {
        int x_offset = 376;
        int y_offset = 10;

        public int gridSize = 17;
        public int gridSizeZ = 4;

        int x_tile_offset = 32; // 22 for 48x48 tiles 32 for 64x64 tiles
        int y_tile_offset = 16; // 11 for 48x48 tiles 16 for 64x64 tiles
        int z_tile_offset = 32; // 23 for 48x48 tiles 32 for 64x64 tiles

        public List<Point[,]> Layers = new List<Point[,]>();

        //public Point[,] Layer;

        public Grid_v2()
        {
            for (int i = 0; i < gridSizeZ; i++)
            {
                Layers.Add(loadLayer(i));
            }
        }

        public Point[,] loadLayer(int layerNumber)
        {
            Point[,] Layer = new Point[gridSize, gridSize];

            int layer_y;

            layer_y = y_offset - (z_tile_offset * layerNumber);

            for (int i = 0; i < gridSize; i++)
            {
                Layer[i, 0] = new Point(x_offset + (x_tile_offset * (i+1)), layer_y + (y_tile_offset * (i + 1)));
            }

            for (int i = 0; i < gridSize; i++)
            {
                for (int x = 0; x < gridSize; x++)
                {
                    Point previousTile;//= new Point(0,0);

                    if (i == 0)
                    {
                        previousTile = Layer[x, i];
                    }
                    else
                    {
                        previousTile = Layer[x, i - 1];
                    }

                    Layer[x,i] = new Point(previousTile.X - x_tile_offset, previousTile.Y + y_tile_offset);
                }
            }

            return Layer;
        }
    }
}
