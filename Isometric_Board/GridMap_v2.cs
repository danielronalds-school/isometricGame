using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isometricRenderEngine
{
    class GridMap_v2
    {
        /*
         * What the renderer inteprets to determine what the "world" should look like
         * (basically a level designer)
         * 
         * To set the x and y dimesions of the world use the 2d string arrays, with the appropriate characters/placeholders
         * 
         * To set the z dimension of the world introduce or remove 2d string arrays, and load them into the Layer list in the constructer
         * 
         * To quickly do mass edits, use the replace tool in visual studio with the target area set to "Current Block"
         */

        public List<string[,]> Layers = new List<string[,]>();

        public GridMap_v2()
        {
            Layers.Add(layer1); // Loads the layer maps into one list for easy access 
            Layers.Add(layer2);
            Layers.Add(layer3);
            Layers.Add(layer4);
            Layers.Add(layer5);
            Layers.Add(layer6);
            Layers.Add(layer7);
        }

        // a "v" character tells the renderer to place a isomtric tile, a "0" tells it to leave it blank

        public string[,] layer1 = {
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","v" }
        };

        public string[,] layer2 = {
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","0" }
        };

        public string[,] layer3 = {
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","0" },
            {"v","v","v","v","v","0","0" }
        };

        public string[,] layer4 = {
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","0" },
            {"v","v","v","v","v","0","0" },
            {"v","v","v","v","0","0","0" }
        };

        public string[,] layer5 = {
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","0" },
            {"v","v","v","v","v","0","0" },
            {"v","v","v","v","0","0","0" },
            {"v","v","v","0","0","0","0" }
        };

        public string[,] layer6 = {
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","0" },
            {"v","v","v","v","v","0","0" },
            {"v","v","v","v","0","0","0" },
            {"v","v","v","0","0","0","0" },
            {"v","v","0","0","0","0","0" }
        };

        public string[,] layer7 = {
            {"v","v","v","v","v","v","v" },
            {"v","v","v","v","v","v","0" },
            {"v","v","v","v","v","0","0" },
            {"v","v","v","v","0","0","0" },
            {"v","v","v","0","0","0","0" },
            {"v","v","0","0","0","0","0" },
            {"v","0","0","0","0","0","0" }
        };
    }
}
