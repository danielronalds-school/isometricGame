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

        int GridSize = 6;

        public Point[] A, B, C, D, E, F;

        public Grid()
        {
            loadArrayA();
            loadArrayB();
            loadArrayC();
            loadArrayD();
            loadArrayE();
            loadArrayF();
        }

        private void loadArrayA()
        {
            A = new Point[GridSize];

            for (int i = 0; i < GridSize; i++)
            {
                if (i == 0)
                {
                    A[i] = new Point(x_offset + (22 * 1), y_offset + (11 * 1));
                }
                else
                {
                    Point previousTile = A[i - 1];

                    A[i] = new Point(previousTile.X - 22, previousTile.Y + 11);
                }
            }
        }

        private void loadArrayB()
        {
            B = new Point[GridSize];

            for (int i = 0; i < GridSize; i++)
            {
                if (i == 0)
                {
                    B[i] = new Point(x_offset + (22 * 2), y_offset + (11 * 2));
                }
                else
                {
                    Point previousTile = B[i - 1];

                    B[i] = new Point(previousTile.X - 22, previousTile.Y + 11);
                }
            }
        }

        private void loadArrayC()
        {
            C = new Point[GridSize];

            for (int i = 0; i < GridSize; i++)
            {
                if (i == 0)
                {
                    C[i] = new Point(x_offset + (22 * 3), y_offset + (11 * 3));
                }
                else
                {
                    Point previousTile = C[i - 1];

                    C[i] = new Point(previousTile.X - 22, previousTile.Y + 11);
                }
            }
        }

        private void loadArrayD()
        {
            D = new Point[GridSize];

            for (int i = 0; i < GridSize; i++)
            {
                if (i == 0)
                {
                    D[i] = new Point(x_offset + (22 * 4), y_offset + (11 * 4));
                }
                else
                {
                    Point previousTile = D[i - 1];

                    D[i] = new Point(previousTile.X - 22, previousTile.Y + 11);
                }
            }
        }

        private void loadArrayE()
        {
            E = new Point[GridSize];

            for (int i = 0; i < GridSize; i++)
            {
                if (i == 0)
                {
                    E[i] = new Point(x_offset + (22 * 5), y_offset + (11 * 5));
                }
                else
                {
                    Point previousTile = E[i - 1];

                    E[i] = new Point(previousTile.X - 22, previousTile.Y + 11);
                }
            }
        }

        private void loadArrayF()
        {
            F = new Point[GridSize];

            for (int i = 0; i < GridSize; i++)
            {
                if (i == 0)
                {
                    F[i] = new Point(x_offset + (22 * 6), y_offset + (11 * 6));
                }
                else
                {
                    Point previousTile = F[i - 1];

                    F[i] = new Point(previousTile.X - 22, previousTile.Y + 11);
                }
            }
        }
    }
}
