using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise2
{
    public partial class Form1 : Form
    {
        Rectangle rect = new Rectangle(300,300,50,25);
        Pen pen = new Pen(Color.Green);
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Form1_KeyDown_1);
        }
        void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                rect.Location = new Point(rect.Left - 10, rect.Top);
            if (e.KeyCode == Keys.Right)
                rect.Location = new Point(rect.Left + 10, rect.Top);
            if (e.KeyCode == Keys.Up)
                rect.Location = new Point(rect.X+10,rect.Y);
            if (e.KeyCode == Keys.Down)
                rect.Location = new Point(rect.X + 10, rect.Y);
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            g.FillRectangle(Brushes.Red,rect);
        }
        
    }
}
