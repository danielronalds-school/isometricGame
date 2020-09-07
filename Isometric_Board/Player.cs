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
        public RenderComponent renderComponent;

        int width, height, x, y;

        Image playerImage = Properties.Resources.high_res_player_cube;

        public Rectangle playerRec;

        int playerSpeed = 2;

        public Player(Point Location)
        {
            width = 48;
            height = width;

            x = Location.X;
            y = Location.Y;

            Size playerSize = new Size(width, height);

            playerRec = new Rectangle(Location, playerSize);

            renderComponent = new RenderComponent(playerImage, playerRec);
        }

        public void movePlayer(bool right, bool left, bool up, bool down, List<IsometricTile> tiles)
        {
            if(right)
            {
                playerRec.X += (2 * playerSpeed);
                playerRec.Y -= (1 * playerSpeed);
            }

            if(left)
            {
                playerRec.X -= (2 * playerSpeed);
                playerRec.Y += (1 * playerSpeed);
            }

            if(up)
            {
                playerRec.X -= (2 * playerSpeed);
                playerRec.Y -= (1 * playerSpeed);
            }

            if(down)
            {
                playerRec.X += (2 * playerSpeed);
                playerRec.Y += (1 * playerSpeed);
            }

            renderComponent.RenderRect = playerRec;
        }
    }
}
