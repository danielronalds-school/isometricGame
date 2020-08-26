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

        public IsometricCollider collider;

        Image playerImage = Properties.Resources.high_res_player_cube;

        public Rectangle playerRec;

        int playerSpeed = 1;

        public Player(Point Location)
        {
            width = 48;
            height = width;

            x = Location.X;
            y = Location.Y;

            Size playerSize = new Size(width, height);

            playerRec = new Rectangle(Location, playerSize);

            collider = new IsometricCollider(playerRec.Location);
        }

        public void drawPlayer(Graphics g)
        {
            g.DrawImage(playerImage, playerRec);
        }

        public void movePlayer(bool right, bool left, bool up, bool down, List<IsometricTile> tiles)
        {
            if(right)
            {
                playerRec.X += (2 * playerSpeed);
                playerRec.Y -= (1 * playerSpeed);
                foreach(IsometricTile tile in tiles)
                {
                    if(tile.playerLayer)
                    {
                        foreach (Rectangle tileCollider in tile.collider.colliders)
                        {
                            foreach (Rectangle playerCollider in collider.colliders)
                            {
                                if(playerCollider.IntersectsWith(tileCollider))
                                {
                                    playerRec.X -= (2 * playerSpeed);
                                    playerRec.Y += (1 * playerSpeed);
                                    collider.updatePosition(playerRec.Location);
                                    break;
                                }
                            }
                        }
                    }
                }
            }

             else if(left)
            {
                playerRec.X -= (2 * playerSpeed);
                playerRec.Y += (1 * playerSpeed);
                foreach (IsometricTile tile in tiles)
                {
                    if (tile.playerLayer)
                    {
                        foreach (Rectangle tileCollider in tile.collider.colliders)
                        {
                            foreach (Rectangle playerCollider in collider.colliders)
                            {
                                if (playerCollider.IntersectsWith(tileCollider))
                                {
                                    playerRec.X += (2 * playerSpeed);
                                    playerRec.Y -= (1 * playerSpeed);
                                    collider.updatePosition(playerRec.Location);
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            else if(up)
            {
                playerRec.X -= (2 * playerSpeed);
                playerRec.Y -= (1 * playerSpeed);
                foreach (IsometricTile tile in tiles)
                {
                    if (tile.playerLayer)
                    {
                        foreach (Rectangle tileCollider in tile.collider.colliders)
                        {
                            foreach (Rectangle playerCollider in collider.colliders)
                            {
                                if (playerCollider.IntersectsWith(tileCollider))
                                {
                                    playerRec.X += (2 * playerSpeed);
                                    playerRec.Y += (1 * playerSpeed);
                                    collider.updatePosition(playerRec.Location);
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            else if(down)
            {
                playerRec.X += (2 * playerSpeed);
                playerRec.Y += (1 * playerSpeed);
                foreach (IsometricTile tile in tiles)
                {
                    if (tile.playerLayer)
                    {
                        foreach (Rectangle tileCollider in tile.collider.colliders)
                        {
                            foreach (Rectangle playerCollider in collider.colliders)
                            {
                                if (playerCollider.IntersectsWith(tileCollider))
                                {
                                    playerRec.X -= (2 * playerSpeed);
                                    playerRec.Y -= (1 * playerSpeed);
                                    collider.updatePosition(playerRec.Location);
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            collider.updatePosition(playerRec.Location);
        }

    }
}
