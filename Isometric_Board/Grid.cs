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
        int y_offset = 150;

        public int GridSize = 7;

        public Point[] A, B, C, D, E, F, G;

        public Point[] A2, B2, C2, D2, E2, F2, G2;

        public Grid()
        {
            loadGridArray();
            loadGridTwoArray();
        }

        private void loadGridArray()
        {
            A = new Point[GridSize];
            B = new Point[GridSize];
            C = new Point[GridSize];
            D = new Point[GridSize];
            E = new Point[GridSize];
            F = new Point[GridSize];
            G = new Point[GridSize];

            for (int i = 0; i < GridSize; i++)
            {
                if (i == 0)
                {
                    A[i] = new Point(x_offset + (22 * 1), y_offset + (11 * 1));
                    B[i] = new Point(x_offset + (22 * 2), y_offset + (11 * 2));
                    C[i] = new Point(x_offset + (22 * 3), y_offset + (11 * 3));
                    D[i] = new Point(x_offset + (22 * 4), y_offset + (11 * 4));
                    E[i] = new Point(x_offset + (22 * 5), y_offset + (11 * 5));
                    F[i] = new Point(x_offset + (22 * 6), y_offset + (11 * 6));
                    G[i] = new Point(x_offset + (22 * 7), y_offset + (11 * 7));
                }
                else
                {
                    Point previousTileA = A[i - 1];
                    Point previousTileB = B[i - 1];
                    Point previousTileC = C[i - 1];
                    Point previousTileD = D[i - 1];
                    Point previousTileE = E[i - 1];
                    Point previousTileF = F[i - 1];
                    Point previousTileG = G[i - 1];

                    A[i] = new Point(previousTileA.X - 22, previousTileA.Y + 11);
                    B[i] = new Point(previousTileB.X - 22, previousTileB.Y + 11);
                    C[i] = new Point(previousTileC.X - 22, previousTileC.Y + 11);
                    D[i] = new Point(previousTileD.X - 22, previousTileD.Y + 11);
                    E[i] = new Point(previousTileE.X - 22, previousTileE.Y + 11);
                    F[i] = new Point(previousTileF.X - 22, previousTileF.Y + 11);
                    G[i] = new Point(previousTileG.X - 22, previousTileG.Y + 11);
                }
            }
        }

        // 3D Attempt
        private void loadGridTwoArray()
        {
            A2 = new Point[GridSize];
            B2 = new Point[GridSize];
            C2 = new Point[GridSize];
            D2 = new Point[GridSize];
            E2 = new Point[GridSize];
            F2 = new Point[GridSize];
            G2 = new Point[GridSize];

            for (int i = 0; i < GridSize; i++)
            {
                A2[i] = new Point(A[i].X, A[i].Y - 23);
                B2[i] = new Point(B[i].X, B[i].Y - 23);
                C2[i] = new Point(C[i].X, C[i].Y - 23);
                D2[i] = new Point(D[i].X, D[i].Y - 23);
                E2[i] = new Point(E[i].X, E[i].Y - 23);
                F2[i] = new Point(F[i].X, F[i].Y - 23);
                G2[i] = new Point(G[i].X, G[i].Y - 23);
            }
        }
    }
}
