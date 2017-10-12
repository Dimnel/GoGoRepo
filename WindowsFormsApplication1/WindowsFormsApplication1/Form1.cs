using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int x = 200, y = 200, dx, dy;
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            dx = rnd.Next(1, 10);
            dy = rnd.Next(1, 10);
        }
        
            

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Graphics g = pictureBox1.CreateGraphics();
            Pen p = new Pen(Color.Black, 10);
            g.Clear(Color.White);
            g.DrawEllipse(p, x, y, 10, 10);
            if (x > 380 || x < 5)
                dx = dx * -1;
            if (y > 380 || y < 5)
                dy = dy * -1;
            x += dx;
            y += dy;
            
        }
    }
}
