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
        public List<RenderComponent> renderComponent = new List<RenderComponent>();

        int width, height, x, y;

        Image playerImage = Properties.Resources.player_main;
        Image playerShadowImage = Properties.Resources.player_shadow;

        public Rectangle playerRec;
        Rectangle playerBodyRec;

        int playerSpeed = 2;

        int currentAnimation = 0;
        int maxAnimation = 8;
        int animationDelay = 0;
        int maxAnimationDelay = 6;

        public Player(Point Location)
        {
            width = 64;
            height = width;

            x = Location.X;
            y = Location.Y;

            Size playerSize = new Size(width, height);

            playerRec = new Rectangle(Location, playerSize);
            playerBodyRec = new Rectangle(Location, playerSize);

            renderComponent.Add(new RenderComponent(playerShadowImage, playerRec));
            renderComponent.Add(new RenderComponent(playerImage, playerBodyRec));
        }

        public void updateAnimation()
        {
            if(animationDelay >= maxAnimationDelay)
            {
                if (currentAnimation <= (maxAnimation / 2))
                {
                    renderComponent[1].RenderRect.Y += 1;
                }
                else if (currentAnimation < maxAnimation)
                {
                    renderComponent[1].RenderRect.Y -= 1;
                }
                else
                {
                    renderComponent[1].RenderRect.Location = renderComponent[0].RenderRect.Location;
                    currentAnimation = 0;
                }

                currentAnimation++;

                animationDelay = 0;
            } else
            {
                animationDelay++;
            }
        }

        public void movePlayer(bool right, bool left, bool up, bool down, List<RenderComponent> components)
        {
            if (right)
            {
                //playerRec.X += (2 * playerSpeed);
                //playerRec.Y -= (1 * playerSpeed);
                foreach(RenderComponent component in components)
                {
                    component.RenderRect.X -= (2 * playerSpeed);
                    component.RenderRect.Y += (1 * playerSpeed);
                }
            }

            if(left)
            {
                //playerRec.X -= (2 * playerSpeed);
                //playerRec.Y += (1 * playerSpeed);
                foreach (RenderComponent component in components)
                {
                    component.RenderRect.X += (2 * playerSpeed);
                    component.RenderRect.Y -= (1 * playerSpeed);
                }
            }

            if(up)
            {
                //playerRec.X -= (2 * playerSpeed);
                //playerRec.Y -= (1 * playerSpeed);
                foreach (RenderComponent component in components)
                {
                    component.RenderRect.X += (2 * playerSpeed);
                    component.RenderRect.Y += (1 * playerSpeed);
                }
            }

            if(down)
            {
                //playerRec.X += (2 * playerSpeed);
                //playerRec.Y += (1 * playerSpeed);
                foreach (RenderComponent component in components)
                {
                    component.RenderRect.X -= (2 * playerSpeed);
                    component.RenderRect.Y -= (1 * playerSpeed);
                }
            }

            if(right || left || up || down)
            {
                maxAnimationDelay = 3;
            } else
            {
                maxAnimationDelay = 6;
            }

            updateAnimation();
        }
    }
}
