using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Isometric_Board
{
    public partial class Form1 : Form
    {
        Graphics g;

        Renderer_v2 renderer = new Renderer_v2();

        Player player;

        bool playerRight, playerLeft, playerUp, playerDown;

        public Form1()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, Canvas, new object[] { true });
            player = new Player(renderer.grid.loadLayer(1)[8,8]);
        }


        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            renderer.Render(g, player);
        }

        private void refreshScreen_Tick(object sender, EventArgs e)
        {
            player.movePlayer(playerRight, playerLeft, playerUp, playerDown, renderer.renderOrder);
            Canvas.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    playerRight = true;
                    break;

                case Keys.A:
                    playerLeft = true;
                    break;

                case Keys.W:
                    playerUp = true;
                    break;

                case Keys.S:
                    playerDown = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    playerRight = false;
                    break;

                case Keys.A:
                    playerLeft = false;
                    break;

                case Keys.W:
                    playerUp = false;
                    break;

                case Keys.S:
                    playerDown = false;
                    break;
            }
        }
    }
}
