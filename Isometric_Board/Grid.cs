using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Isometric_Board
{
    class Grid
    {
        int x_offset = 350;
        int y_offset = 140;

        public Point A1, A2, A3, A4, A5, A6;

        public Point B1, B2, B3, B4, B5, B6;

        public Point C1, C2, C3, C4, C5, C6;

        public Point D1, D2, D3, D4, D5, D6;

        public Point E1, E2, E3, E4, E5, E6;

        public Point F1, F2, F3, F4, F5, F6;

        public Grid()
        {
            A1 = new Point(x_offset + (22*1), y_offset + (11*1));
            A2 = new Point(A1.X - 22, A1.Y + 11);
            A3 = new Point(A2.X - 22, A2.Y + 11);
            A4 = new Point(A3.X - 22, A3.Y + 11);
            A5 = new Point(A4.X - 22, A4.Y + 11);
            A6 = new Point(A5.X - 22, A5.Y + 11);

            B1 = new Point(x_offset + (22 * 2), y_offset + (11 * 2));
            B2 = new Point(B1.X - 22, B1.Y + 11);
            B3 = new Point(B2.X - 22, B2.Y + 11);
            B4 = new Point(B3.X - 22, B3.Y + 11);
            B5 = new Point(B4.X - 22, B4.Y + 11);
            B6 = new Point(B5.X - 22, B5.Y + 11);

            C1 = new Point(x_offset + (22 * 3), y_offset + (11 * 3));
            C2 = new Point(C1.X - 22, C1.Y + 11);
            C3 = new Point(C2.X - 22, C2.Y + 11);
            C4 = new Point(C3.X - 22, C3.Y + 11);
            C5 = new Point(C4.X - 22, C4.Y + 11);
            C6 = new Point(C5.X - 22, C5.Y + 11);

            D1 = new Point(x_offset + (22 * 4), y_offset + (11 * 4));
            D2 = new Point(D1.X - 22, D1.Y + 11);
            D3 = new Point(D2.X - 22, D2.Y + 11);
            D4 = new Point(D3.X - 22, D3.Y + 11);
            D5 = new Point(D4.X - 22, D4.Y + 11);
            D6 = new Point(D5.X - 22, D5.Y + 11);

            E1 = new Point(x_offset + (22 * 5), y_offset + (11 * 5));
            E2 = new Point(E1.X - 22, E1.Y + 11);
            E3 = new Point(E2.X - 22, E2.Y + 11);
            E4 = new Point(E3.X - 22, E3.Y + 11);
            E5 = new Point(E4.X - 22, E4.Y + 11);
            E6 = new Point(E5.X - 22, E5.Y + 11);

            F1 = new Point(x_offset + (22 * 6), y_offset + (11 * 6));
            F2 = new Point(F1.X - 22, F1.Y + 11);
            F3 = new Point(F2.X - 22, F2.Y + 11);
            F4 = new Point(F3.X - 22, F3.Y + 11);
            F5 = new Point(F4.X - 22, F4.Y + 11);
            F6 = new Point(F5.X - 22, F5.Y + 11);

        }
    }
}
