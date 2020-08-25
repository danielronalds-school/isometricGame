using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Isometric_Board
{
    class Math
    {
        public Point toIsometric(Point coords)
        {
            int isometric_x, isometric_y;

            isometric_x = coords.X + coords.Y;
            isometric_y = (int)((-0.5 * coords.X) + (0.5 * coords.Y));

            return (new Point(isometric_x, isometric_y));
        }
    }
}
