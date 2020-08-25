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
        int width, height, x, y;

        Image tileImage;

        public Rectangle tileRec;

        public string tileID;

        public IsometricTile(Point Position, string ID)
        {
            x = Position.X;
            y = Position.Y;
            width = 48;
            height = width;

            tileID = ID;

            tileImage = Properties.Resources.white_isometric_cube;

            tileRec = new Rectangle(x, y, width, height);
        }

        public void drawTile(Graphics g)
        {
            g.DrawImage(tileImage, tileRec);
            //g.DrawRectangle(Pens.Green, tileRec);
        }
    }
}
