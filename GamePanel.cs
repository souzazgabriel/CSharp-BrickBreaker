using System;
using System.Drawing;
using System.Windows.Forms;

namespace BrickBreaker
{
    public class GamePanel : Panel
    {
        //private Bola bola;
        //private Raquete raquete;
        //private Timer timer;

        public GamePanel()
        {
            // Configurações iniciais
            this.DoubleBuffered = true;
            this.BackColor = Color.Black;
            this.Size = new Size(800, 600);
            this.Focus();
        }
    }
}
