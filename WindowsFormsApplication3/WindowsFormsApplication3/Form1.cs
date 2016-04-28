using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {

        
        Rectangle r = new Rectangle(50, 50, 50, 200);
        Pen p = new Pen(Brushes.Aqua);
        public Form1()
        {
            InitializeComponent();
        }
        public void DrawRect()
        {
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(p, r);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawRect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            r.Offset(20, 20);
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(p, r);
        }
    }
}
