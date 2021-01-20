using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smajlici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int m, n, x, y;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                s[i].Crtaj(e.Graphics);
            }
        }

        Smajli[] s = new Smajli[10];
        private void Form1_Load(object sender, EventArgs e)
        {
            m = ClientRectangle.Width;
            n = ClientRectangle.Height;
            for (int i = 0; i < 10; i++)

            {
                x = r.Next(100, m - 100);
                y = r.Next(100, n - 100);
                int tip = r.Next(3);
                if (tip == 0)
                    s[i] = new Smajli1(x, y);
                else if (tip == 1)
                    s[i] = new Smajli2(x, y);
            }
        }
    }
    
}
