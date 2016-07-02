using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Astar;
using System.Threading;

namespace AstarVisual
{
    public partial class Form1 : Form
    {
        Button a;
        public Form1()
        {
            InitializeComponent();
        }

        private void f1_DragDrop(object sender, DragEventArgs e)
        {
            Button b = (Button)sender;
            string ttext = b.Text;
            string tname = b.Name;
            string[] s1 = (string[]) e.Data.GetData(typeof(string[]));
            b.Text = s1[0];
            b.Name = s1[1];
            a.Text = ttext;
            a.Name = tname;
        }

        private void f1_MouseDown(object sender, MouseEventArgs e)
        {
            a = (Button)sender;
            string[] s = new string[2];
            s[0] = a.Text;
            s[1] = a.Name;
            DoDragDrop(s, DragDropEffects.Copy);
        }

        private void f1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        problem p;
        private void Solve_Click(object sender, EventArgs e)
        {
            state first = new state(3);
            string[,] k = new string[3, 3];
            for(int i=0;i<3;i++)
                for(int j=0;j<3;j++)
                {
                    Point pt = new Point(100 * j + 50, 100 * i + 50);
                    k[i, j] = ((Button)firststate.GetChildAtPoint(pt)).Text;
                }
            first.setk(k);
            state goal = new state(3);
            string[,] g = new string[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    Point pt = new Point(100*j+50, 100*i+50);
                    g[i, j] = ((Button)Goalstate.GetChildAtPoint(pt)).Text;
                }
            goal.setk(g);
            p = new problem(first, goal,3);
            if (p.whichset(first.getk()) != p.whichset(goal.getk()))
                MessageBox.Show("the sets didnt match");
            else
            {
                AStar AS = new AStar(p);
                try
                {
                    state[] solution = AS.AS();
                    MessageBox.Show("I found the solution now i will show it : ");
                    foreach (state s in solution)
                    {
                        showstate(s);
                        this.Refresh();
                        Thread.Sleep(1000);
                    }
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("SYSTEM IS OUT OF MEMORY");
                }
            }
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
                    pt = new Point(100 * j + 50, 100 * i + 50);
                    B = ((Button)firststate.GetChildAtPoint(pt));
                    B.Text = K[i, j];
                    B.BackColor = Control.DefaultBackColor;
                }
            int[] a = AStar.whereisblock("-", K);
            pt = new Point(100*a[1]+50, 100*a[0]+50);
            B = ((Button)firststate.GetChildAtPoint(pt));
            B.BackColor = Color.Yellow;
        }

    }
}
