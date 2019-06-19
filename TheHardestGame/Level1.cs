using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TheHardestGame
{
    public partial class Level1 : Form
    {
        //public Square square;
        public GameDoc gameDoc;
        private Timer timer;
        public Level1()
        {   
            InitializeComponent();
            DoubleBuffered = true;
            gameDoc = new GameDoc();
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            this.BackColor = Color.White;
            
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            foreach(var item in gameDoc.balls)
            {
                item.MoveBall();
                Invalidate(true);
            }
        }
        private void Level1_Paint(object sender, PaintEventArgs e)
        {
            Brush b = new SolidBrush(Color.Blue);
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            pen.Width = 5;
            
            e.Graphics.DrawLines(pen, gameDoc.points);
            gameDoc.DrawBalls(e.Graphics);  
            gameDoc.square.Draw(e.Graphics);
        }

        private void Level1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Up)
            {
                gameDoc.square.Move(Direction.UP);
                Invalidate(true);
            }
            if(e.KeyCode == Keys.Down)
            {
                gameDoc.square.Move(Direction.DOWN);
                Invalidate(true);
            }
            if(e.KeyCode == Keys.Left)
            {
                gameDoc.square.Move(Direction.LEFT);
                gameDoc.isHitSquareLines();
                Invalidate(true);
            }
            if(e.KeyCode == Keys.Right)
            {
                gameDoc.square.Move(Direction.RIGHT);
                gameDoc.isHitSquareLines();
                Invalidate(true);
            }
           
        }
    }
}
