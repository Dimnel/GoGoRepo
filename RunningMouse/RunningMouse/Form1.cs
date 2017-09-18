using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RunningMouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random los = new Random();
            int x,y;
            x = los.Next(button1.Width, 475 - button1.Width);
            y = los.Next(button1.Height, 409 - button1.Height);

            Point p = new Point(x, y);
            button1.Location = p;
        }
    }
}
