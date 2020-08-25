using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Isometric_Board
{
    class Player
    {
        int width, height, x, y;

        Image playerImage = Properties.Resources.player_cube;

        Rectangle playerRec;

        int playerSpeed = 2;

        public Player(Point Location)
        {
            width = 48;
            height = width;

            x = Location.X;
            y = Location.Y;

            Size playerSize = new Size(width, height);

            playerRec = new Rectangle(Location, playerSize);
        }

        public void drawPlayer(Graphics g)
        {
            playerRec.Location = new Point(x, y);

            g.DrawImage(playerImage, playerRec);
        }

        public void movePlayer(bool right, bool left, bool up, bool down)
        {
            if(right)
            {
                x += (2 * playerSpeed);
                y += (1 * playerSpeed);
            }

            if(left)
            {
                x -= (2 * playerSpeed);
                y -= (1 * playerSpeed);
            }

            if(up)
            {
                x += (2 * playerSpeed);
                y -= (1 * playerSpeed);
            }

            if(down)
            {
                x -= (2 * playerSpeed);
                y += (1 * playerSpeed);
            }
        }

    }
}
