using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Astar
{
	    class Heap
	    {
	        private state[] heapArray;
	        private int maxSize;
	        private int currentSize;
	        public Heap(int maxHeapSize)
	        {
	            maxSize = maxHeapSize;
	            currentSize = 0;
	            heapArray = new state[maxSize];
	        }
	        public bool IsEmpty()
	        { return currentSize==0; }
	        public bool Insert(state S)
	        {
	            if(currentSize==maxSize)
	                return false;
	            heapArray[currentSize] = S;
	            CascadeUp(currentSize++);
	            return true;
	        }
	        public void CascadeUp(int index)
	        {
	            int parent = (index-1) / 2;
	            state bottom = heapArray[index];
	            while( index > 0 && heapArray[parent].f > bottom.f )
	            {
	                heapArray[index] = heapArray[parent];
	                index = parent;
	                parent = (parent-1) / 2;
	            }
	            heapArray[index] = bottom;
	        }
	        public state Remove() // Remove maximum value node
	        {
	            state root = heapArray[0];
	            heapArray[0] = heapArray[--currentSize];
	            CascadeDown(0);
	            return root;
	        }
	        public void CascadeDown(int index)
	        {
	            int largerChild;
	            state top = heapArray[index];
	            while(index < currentSize/2)
	            {
	                int leftChild = 2*index+1;
	                int rightChild = leftChild+1;
	                if(rightChild < currentSize && heapArray[leftChild].f > heapArray[rightChild].f)
	                    largerChild = rightChild;
	                else
	                    largerChild = leftChild;
	                if( top.f <= heapArray[largerChild].f )
	                    break;
	                heapArray[index] = heapArray[largerChild];
	                index = largerChild;
	            }
	            heapArray[index] = top;
	        }
	        public void DisplayHeap()
	        {
                for (int i = 0; i < currentSize; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine(i+" : ");
                    foreach (string c in heapArray[i].getk())
                    {
                        Console.Write(c + " ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("==================================================");
	        }
	    } 
    public class state{
        public string lastaction= "";
        public bool Kseted = false;
        string[,] K;
        public int g = 0;
        state parent;
        public int f;
        public state(int n){
            K = new string[n, n];
        }
        public void setparent(state P)
        {
            parent = P;
            g = P.g+1;
        }
        public state getparent()
        {
            return parent;
        }
        public void setk(string[,] l)
        {
            Kseted = true;
            for (int i = 0; i < l.GetLength(0); i++)
                for(int j=0;j< l.GetLength(1); j++)
                     K[i,j] = l[i,j];
        }
        public string[,] getk()
        {
            return K;
        }
    }
    public class actions
    {
        static public int[] whereisblank(string[,] C)
        {
            int[] a = new int[2];
            for (int i = 0; i < C.GetLength(0); i++)
                for (int j = 0; j < C.GetLength(1); j++)
                    if (C[i, j] == "-")
                    {
                        a[0] = i;
                        a[1] = j;
                        return a;
                    }
            return a;
        }
        static public state left(state currentstate)
        {
            state S = new state(problem.N);
            if (whereisblank(currentstate.getk())[1] == 0) { }
            else
            {
                string[,] next = new string[problem.N, problem.N];
                for (int i = 0; i < currentstate.getk().GetLength(0); i++)
                    for (int j = 0; j < currentstate.getk().GetLength(1); j++)
                        next[i, j] = currentstate.getk()[i, j];
                int x = whereisblank(next)[0];
                int y = whereisblank(next)[1];
                next[x, y] = next[x, y - 1];
                next[x, y - 1] = "-";
                S.setk(next);
                S.lastaction = "LEFT";
            }
            return S;
        }
        static public state Down(state currentstate)
        {
            state S = new state(problem.N);
            if (whereisblank(currentstate.getk())[0] == problem.N-1) { }
            else
            {
                string[,] next = new string[problem.N, problem.N];
                for (int i = 0; i < currentstate.getk().GetLength(0); i++)
                    for (int j = 0; j < currentstate.getk().GetLength(1); j++)
                        next[i, j] = currentstate.getk()[i, j];
                int x = whereisblank(next)[0];
                int y = whereisblank(next)[1];
                next[x, y] = next[x + 1, y];
                next[x + 1, y] = "-";
                S.setk(next);
                S.lastaction = "DOWN";
            }
            return S;
        }
        static public state right(state currentstate)
        {
            state S = new state(problem.N);
            if (whereisblank(currentstate.getk())[1] == problem.N -1) { }
            else
            {
                string[,] next = new string[problem.N, problem.N];
                for (int i = 0; i < currentstate.getk().GetLength(0); i++)
                    for (int j = 0; j < currentstate.getk().GetLength(1); j++)
                        next[i, j] = currentstate.getk()[i, j];
                int x = whereisblank(next)[0];
                int y = whereisblank(next)[1];
                next[x, y] = next[x, y + 1];
                next[x, y + 1] = "-";
                S.setk(next);
                S.lastaction = "RIGHT";
            }
            return S;
        }
        static public state Up(state currentstate)
        {
            state S = new state(problem.N);
            if (whereisblank(currentstate.getk())[0] == 0) { }
            else
            {
                string[,] next = new string[problem.N, problem.N];
                for (int i = 0; i < currentstate.getk().GetLength(0); i++)
                    for (int j = 0; j < currentstate.getk().GetLength(1); j++)
                        next[i, j] = currentstate.getk()[i, j];
                int x = whereisblank(next)[0];
                int y = whereisblank(next)[1];
                next[x, y] = next[x - 1, y];
                next[x - 1, y] = "-";
                S.setk(next);
                S.lastaction = "UP";
            }
            return S;
        }
    }
    public class problem
    {
        static public int N = 0;
        public state firststate;
        public state goal;
        string[,] f;
        public string[,] G;
        public string whichset(string[,] C)
        {
            int N1=0;
            string[] C1 = new string[C.GetLength(0) * C.GetLength(1)];
            int k=0;
            for (int i = 0; i < C.GetLength(0); i++)
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    C1[k] = C[i,j];
                    k++;
                }
                    for (int h = 0; h < C1.Length; h++)
                        for (int g = h; g < C1.Length; g++)
                        {
                            if (C1[h] == "-" || C1[g]=="-")
                                continue;
                            if (Convert.ToInt32(C1[g]) < Convert.ToInt32(C1[h]))
                                N1++;
                        }
                    if (N % 2 == 0)
                        N1 += AStar.whereisblock("-", C)[0];
                    if (N1 % 2 == 0)
                        return "even";
                    else
                        return "odd";
        }
        public string[,] getstate(char name)
        {
            string[,] C = new string[N, N];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    Console.Write("insert "+name+"[" + i + "," + j + "] : ");
                    C[i, j] = Console.ReadLine();
                }
            return C;
        }
        public problem(state first,state goalstate,int getN)
        {
            firststate = first;
            goal = goalstate;
            N = getN;
        }
        public bool GoalTest(state currentstate)
        {
            bool g = true;
            for (int i = 0; i < problem.N; i++)
                for (int j = 0; j < problem.N; j++)
                    if (currentstate.getk()[i, j] != goal.getk()[i, j])
                        g = false;
            return g;
        }
        public state[] Succesorfunction(state currentstate)
        {
            state[] S = new state[4];
            S[0] = actions.left(currentstate);
            S[1] = actions.right(currentstate);
            S[2] = actions.Down(currentstate);
            S[3] = actions.Up(currentstate);
            return S;
        }
        public int waycost(state currentstate)
        {
            return currentstate.g;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            state first= new state(3);
            state goal = new state(3);
            problem P = new problem(first,goal,3);
            AStar s = new AStar(P);
            state[] solution = s.AS();
            Array.Reverse(solution);
            foreach (state st in solution)
            {
                Console.WriteLine(st.lastaction);
            }
            Console.WriteLine("solution Length : " + solution.Length + "\n\n");
            Console.ReadKey();
        }
    }
    public class AStar
    {
        static public int[] whereisblock(string b,string[,] C)
        {
            int[] a = new int[2];
            for (int i = 0; i < C.GetLength(0); i++)
                for (int j = 0; j < C.GetLength(1); j++)
                    if (C[i, j] == b)
                    {
                        a[0] = i;
                        a[1] = j;
                    }
            return a;
        }
        problem P;
        public AStar(problem currentP)
        {
            P = currentP;
        }
        public int h(state current)
        {
            int total=0;
            //using total manhattan distances (h2 in slide 27)
            for (int i = 1; i < problem.N*problem.N; i++)
            {
                total += Math.Abs(whereisblock(i.ToString(), current.getk())[0] - whereisblock(i.ToString(), P.goal.getk())[0]) + Math.Abs(whereisblock(i.ToString(), current.getk())[1] - whereisblock(i.ToString(), P.goal.getk())[1]);
            }
            return total;
        }
        public state[] AS()
        {
            //thinking thinkform = new thinking();
            //thinkform.Show();
            Heap fring = new Heap(100000000);
            P.firststate.f = h(P.firststate);
            fring.Insert(P.firststate);
            while (true)
            {
                if (fring.IsEmpty())
                {
                    state[] SOLUTION = new state[1];
                    SOLUTION[0].lastaction = "failure";
                    return SOLUTION;
                }
                state a = fring.Remove();
              //  if(a.Kseted)
              //      thinkform.showstate(a);
              //  thinkform.Refresh();
                //Thread.Sleep(50);
                if (P.GoalTest(a))
                {
                    thinkform.Hide();
                    state[] SOLUTION = new state[a.g];
                    int i = 0;
                    state s = a;
                    while (s.getparent() != null)
                    {
                        SOLUTION[i] = s;
                        i++;
                        s = s.getparent();
                    }
                    Array.Reverse(SOLUTION);
                    return SOLUTION;
                }
                else
                    foreach (state s in P.Succesorfunction(a))
                    {
                        if (!s.Kseted)
                            continue;
                        s.setparent(a);
                        s.f = h(s) + s.g;
                        if (!fring.Insert(s))
                        {
                            Console.WriteLine("OUT OF MEMORY");
                            state[] SOLUTION = new state[1];
                            SOLUTION[0].lastaction = "fring is out of memory";
                            return SOLUTION;
                        }
                    }
            }
        }
    }
}
