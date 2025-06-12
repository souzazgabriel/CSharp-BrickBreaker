using System;
using System.Drawing;
using System.Windows.Forms;

namespace BrickBreaker
{
    public class GameForm : Form
    {
        public GameForm()
        {
            this.Text = "Brick Breaker";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            GamePanel gamePanel = new GamePanel();
            this.Controls.Add(gamePanel);
            this.ClientSize = new Size(gamePanel.Width, gamePanel.Height);
        }
    }
}
