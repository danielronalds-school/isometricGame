using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace isometricRenderEngine
{
    class RenderComponent
    {
        /*
            The RenderComponent() class holds visual information for the renderer to draw the sprite with.

            It should be initialized in any class that has a sprite

            Allows the use of a list to draw the isometric sprites in the right order
             */

        public Rectangle RenderRect;

        public Image RenderImage;

        public RenderComponent(Image image, Rectangle rectangle)
        {
            RenderImage = image;

            RenderRect = rectangle;
        }

        public void Render(Graphics g)
        {
            g.DrawImage(RenderImage, RenderRect);
        }
    }
}
