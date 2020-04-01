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
            Brush brush = new SolidBrush(Color.Orange);
            pen.Width = 3;
            int[] a = new int[10];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                a[i] = r.Next(50, 350);
            }
            for (int i = 0; i < 9; i++)
            {
                g.DrawLine(pen, 50 + 70 * i, 400 -a[i],50 + 70 * (i + 1),400 -a[i+1]);
            }
            for (int i = 0; i < 10; i++)
            {
                g.FillEllipse(brush, 50 + 70 * i-5, 400 - a[i]-5,10,10);
            }
            Brush brush1 = new SolidBrush(Color.Black);
            Font font = new Font(new FontFamily("Corbel"), 20);
            for (int i = 0; i < 10; i++)
            {
                g.DrawString(a[i].ToString(), font, brush1, 50 + 70 * i-25, 400 - a[i] - 35);
            }
        }
    }
}
