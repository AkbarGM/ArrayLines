using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Aquamarine);
            pen.Width = 20;
            int[] a = new int[10];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                a[i] = r.Next(50, 350);
                g.DrawLine(pen, 50 + 70 * i, 400, 50 + 70 * i,400-a[i]);
            }
        }
    }
}
