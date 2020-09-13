using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace isometricRenderEngine
{
    class Renderer_v2
    {
        /*
            Put some description here
             */

        public Grid_v2 grid = new Grid_v2(64); // width/height of the isometric sprites/assests

        public GridMap_v2 gridMap = new GridMap_v2();

        public List<IsometricTile> tiles = new List<IsometricTile>();

        public List<RenderComponent> renderOrder = new List<RenderComponent>();

        int playerLayer = 1;

        public Renderer_v2()
        {
            loadIsometricTiles();
        }

        public void Render(Graphics g) 
        {
            sortRenderOrder();

            foreach(RenderComponent component in renderOrder)
            {
                component.Render(g);
            }
<<<<<<< HEAD
=======

            player.renderComponent.Render(g);
>>>>>>> parent of 1e710e4... Now 64x64 based compared to the previous 48x48 (nicer to work with more complex shapes) got a basic player going and the bottom tiles are now slabs
        }

        private void sortRenderOrder() // Sorts render order to maintain the isometric illusion
        {
            renderOrder.Clear();

            foreach(IsometricTile tile in tiles)
            {
                renderOrder.Add(tile.renderComponent);
            }
        }

        private int[] getGridID(Point Location)
        {
            Point [,] map = grid.Layers[1];

            for (int i = 0; i < grid.gridSize; i++)
            {
                for (int x = 0; x < grid.gridSize; x++)
                {
                    if (Location == map[i, x])
                    {
                        int[] mapLocation = { i, x };
                        return mapLocation;
                    }
                }
            }

            return null;
        }

        private void loadIsometricTiles() // Inteprets the grid map to see when to place a block
        {
            string ID;
            int layerNumber = -1;

            bool halfSlab = false; // use a half slab sprite, if you have one (Check isomtric tile class)

            foreach (Point[,] layer in grid.Layers)
            {
                layerNumber++;
                string[,] map = gridMap.Layers[layerNumber];

                int playerI = 0;
                int playerX = 0;

<<<<<<< HEAD
                for (int i = 0; i < grid.gridSize; i++) 
=======
                if (layerNumber == playerLayer) // Finds when to paint the player
                {
                    for (int i = 0; i < grid.gridSize; i++)
                    {
                        for (int x = 0; x < grid.gridSize; x++)
                        {
                            if (map[x, i] != "0")
                            {
                                playerI = i;
                                playerX = x;
                            }
                        }
                    }
                }

                for (int i = 0; i < grid.gridSize; i++)
>>>>>>> parent of 1e710e4... Now 64x64 based compared to the previous 48x48 (nicer to work with more complex shapes) got a basic player going and the bottom tiles are now slabs
                {
                    for (int x = 0; x < grid.gridSize; x++)
                    {
                        if (map[x, i] != "0")
                        {
<<<<<<< HEAD
                            bool tile;

                            ID = layerNumber + "-" + "-" + i + "-" + x;
                            if (layerNumber == 0 && halfSlab)
                            {
                                tile = true;
=======
                            if (i == playerI && x == playerX && layerNumber == playerLayer)
                            {
                                ID = "P" + layerNumber + "-" + "-" + i + "-" + x;
>>>>>>> parent of 1e710e4... Now 64x64 based compared to the previous 48x48 (nicer to work with more complex shapes) got a basic player going and the bottom tiles are now slabs
                            }
                            else
                            {
                                ID = layerNumber + "-" + "-" + i + "-" + x;
                            }
                            tiles.Add(new IsometricTile(layer[x, i], ID));
                        }
                    }

                    foreach (IsometricTile tile in tiles)
                    {
                        Console.WriteLine(tile.tileID);
                    }

                    Console.WriteLine("Total tiles: " + tiles.Count());
                }
            }
        }
    }
}
