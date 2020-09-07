using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Isometric_Board
{
    class Renderer_v2
    {
        public Grid_v2 grid = new Grid_v2();

        public GridMap_v2 gridMap = new GridMap_v2();

        public List<IsometricTile> tiles = new List<IsometricTile>();

        public List<RenderComponent> renderOrder = new List<RenderComponent>();

        int playerLayer = 1;

        public Renderer_v2()
        {
            loadIsometricTiles();
        }

        public void Render(Graphics g, Player player)
        {
            sortRenderOrder(player);

            foreach(RenderComponent component in renderOrder)
            {
                component.Render(g);
            }

            player.renderComponent.Render(g);
        }

        private void sortRenderOrder(Player player)
        {
            renderOrder.Clear();

            foreach(IsometricTile tile in tiles)
            {
                renderOrder.Add(tile.renderComponent);
            }

            //renderOrder.Add(player.renderComponent);
        }

        private void loadIsometricTiles()
        {
            string ID;
            int layerNumber = -1;

            foreach (Point[,] layer in grid.Layers)
            {
                layerNumber++;
                string[,] map = gridMap.Layers[layerNumber];

                int playerI = 0;
                int playerX = 0;

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
                {
                    for (int x = 0; x < grid.gridSize; x++)
                    {
                        if (map[x, i] != "0")
                        {
                            if (i == playerI && x == playerX && layerNumber == playerLayer)
                            {
                                ID = "P" + layerNumber + "-" + "-" + i + "-" + x;
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
