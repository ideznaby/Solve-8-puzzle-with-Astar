using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Astar
{
    public partial class thinking : Form
    {
        public thinking()
        {
            InitializeComponent();
        }
        public void showstate(state currentstate)
        {
            Point pt;
            Button B;
            if (currentstate.lastaction == "failure")
            {
                MessageBox.Show("failure");
                return;
            }
            if (currentstate.lastaction == "fring is out of memory")
            {
                MessageBox.Show("fring is full");
                return;
            }
            string[,] K = currentstate.getk();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    pt = new Point(50 * j + 25, 50 * i + 25);
                    B = ((Button)thinkstate.GetChildAtPoint(pt));
                    B.Text = K[i, j];
                    B.BackColor = Control.DefaultBackColor;
                }
            int[] a = AStar.whereisblock("-", K);
            pt = new Point(50 * a[1] + 25, 50 * a[0] + 25);
            B = ((Button)thinkstate.GetChildAtPoint(pt));
            B.BackColor = Color.Yellow;
        }
    }
}
