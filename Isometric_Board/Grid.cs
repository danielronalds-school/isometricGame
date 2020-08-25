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
        int y_offset = 190;

        // 2:1 Ratio

        public int GridSize = 7;

        public Point[] A, B, C, D, E, F, G;

        public Point[] A2, B2, C2, D2, E2, F2, G2;

        public Point[] A3, B3, C3, D3, E3, F3, G3;

        public Point[] A4, B4, C4, D4, E4, F4, G4;

        public Point[] A5, B5, C5, D5, E5, F5, G5;

        public Point[] A6, B6, C6, D6, E6, F6, G6;

        public Point[] A7, B7, C7, D7, E7, F7, G7;

        public Grid()
        {
            loadGridArray();
            loadGrid2Array();
            loadGrid3Array();
            loadGrid4Array();
            loadGrid5Array();
            loadGrid6Array();
            loadGrid7Array();
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
        private void loadGrid2Array()
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

        private void loadGrid3Array()
        {
            A3 = new Point[GridSize];
            B3 = new Point[GridSize];
            C3 = new Point[GridSize];
            D3 = new Point[GridSize];
            E3 = new Point[GridSize];
            F3 = new Point[GridSize];
            G3 = new Point[GridSize];

            for (int i = 0; i < GridSize; i++)
            {
                A3[i] = new Point(A2[i].X, A2[i].Y - 23);
                B3[i] = new Point(B2[i].X, B2[i].Y - 23);
                C3[i] = new Point(C2[i].X, C2[i].Y - 23);
                D3[i] = new Point(D2[i].X, D2[i].Y - 23);
                E3[i] = new Point(E2[i].X, E2[i].Y - 23);
                F3[i] = new Point(F2[i].X, F2[i].Y - 23);
                G3[i] = new Point(G2[i].X, G2[i].Y - 23);
            }
        }

        private void loadGrid4Array()
        {
            A4 = new Point[GridSize];
            B4 = new Point[GridSize];
            C4 = new Point[GridSize];
            D4 = new Point[GridSize];
            E4 = new Point[GridSize];
            F4 = new Point[GridSize];
            G4 = new Point[GridSize];

            for (int i = 0; i < GridSize; i++)
            {
                A4[i] = new Point(A3[i].X, A3[i].Y - 23);
                B4[i] = new Point(B3[i].X, B3[i].Y - 23);
                C4[i] = new Point(C3[i].X, C3[i].Y - 23);
                D4[i] = new Point(D3[i].X, D3[i].Y - 23);
                E4[i] = new Point(E3[i].X, E3[i].Y - 23);
                F4[i] = new Point(F3[i].X, F3[i].Y - 23);
                G4[i] = new Point(G3[i].X, G3[i].Y - 23);
            }
        }

        private void loadGrid5Array()
        {
            A5 = new Point[GridSize];
            B5 = new Point[GridSize];
            C5 = new Point[GridSize];
            D5 = new Point[GridSize];
            E5 = new Point[GridSize];
            F5 = new Point[GridSize];
            G5 = new Point[GridSize];

            for (int i = 0; i < GridSize; i++)
            {
                A5[i] = new Point(A4[i].X, A4[i].Y - 23);
                B5[i] = new Point(B4[i].X, B4[i].Y - 23);
                C5[i] = new Point(C4[i].X, C4[i].Y - 23);
                D5[i] = new Point(D4[i].X, D4[i].Y - 23);
                E5[i] = new Point(E4[i].X, E4[i].Y - 23);
                F5[i] = new Point(F4[i].X, F4[i].Y - 23);
                G5[i] = new Point(G4[i].X, G4[i].Y - 23);
            }
        }

        private void loadGrid6Array()
        {
            A6 = new Point[GridSize];
            B6 = new Point[GridSize];
            C6 = new Point[GridSize];
            D6 = new Point[GridSize];
            E6 = new Point[GridSize];
            F6 = new Point[GridSize];
            G6 = new Point[GridSize];

            for (int i = 0; i < GridSize; i++)
            {
                A6[i] = new Point(A5[i].X, A5[i].Y - 23);
                B6[i] = new Point(B5[i].X, B5[i].Y - 23);
                C6[i] = new Point(C5[i].X, C5[i].Y - 23);
                D6[i] = new Point(D5[i].X, D5[i].Y - 23);
                E6[i] = new Point(E5[i].X, E5[i].Y - 23);
                F6[i] = new Point(F5[i].X, F5[i].Y - 23);
                G6[i] = new Point(G5[i].X, G5[i].Y - 23);
            }
        }

        private void loadGrid7Array()
        {
            A7 = new Point[GridSize];
            B7 = new Point[GridSize];
            C7 = new Point[GridSize];
            D7 = new Point[GridSize];
            E7 = new Point[GridSize];
            F7 = new Point[GridSize];
            G7 = new Point[GridSize];

            for (int i = 0; i < GridSize; i++)
            {
                A7[i] = new Point(A6[i].X, A6[i].Y - 23);
                B7[i] = new Point(B6[i].X, B6[i].Y - 23);
                C7[i] = new Point(C6[i].X, C6[i].Y - 23);
                D7[i] = new Point(D6[i].X, D6[i].Y - 23);
                E7[i] = new Point(E6[i].X, E6[i].Y - 23);
                F7[i] = new Point(F6[i].X, F6[i].Y - 23);
                G7[i] = new Point(G6[i].X, G6[i].Y - 23);
            }
        }
    }
}
