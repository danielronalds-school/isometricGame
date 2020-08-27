using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isometric_Board
{
    class GridMap_v2
    {
        public List<string[,]> Layers = new List<string[,]>(); 

        public GridMap_v2()
        {
            Layers.Add(layer1);
            Layers.Add(layer2);
            Layers.Add(layer3);
            Layers.Add(layer4);
            Layers.Add(layer5);
            Layers.Add(layer6);
            Layers.Add(layer7);
            Layers.Add(layer8);
            Layers.Add(layer9);
        }

        public string[,] layer1 = {
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", }
        };

        public string[,] layer2 = {
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", }
        };

        public string[,] layer3 = {
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", }
        };

        public string[,] layer4 = {
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", }
        };
        public string[,] layer5 = {
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", }
        };
        public string[,] layer6 = {
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", }
        };
        public string[,] layer7 = {
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", }
        };
        public string[,] layer8 = {
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", }
        };
        public string[,] layer9 = {
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", } ,
            { "v", "v", "v", "v", "v", "v", "v", "v", "v", }
        };
    }
}
