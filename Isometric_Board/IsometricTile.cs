using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Isometric_Board
{
    class IsometricTile
    {
        public RenderComponent renderComponent;

        int width, height, x, y;

        Image tileImage;

        public Rectangle tileRec;

        public string tileID;

        public IsometricTile(Point Position, string ID, bool slab)
        {
            x = Position.X;
            y = Position.Y;
            width = 64;
            height = width;

            tileID = ID;

            tileImage = Properties.Resources.large_isometric_cube;

            if(slab)
            {
                tileImage = Properties.Resources._64x64_isometric_tile;
            }

            tileRec = new Rectangle(x, y, width, height);

            renderComponent = new RenderComponent(tileImage, tileRec);
        }
    }
}
