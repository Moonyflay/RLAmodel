using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLA
{
    class Cluster
    {
        static int Particle_number
        {
            get
            {
                if (X == null) return 0;
                return X.Count;
            }
        }

        static public List<int> X = new List<int>();
        static public List<int> Y = new List<int>();
        static public int Min_X 
        { get 
            {
                int min_x = X[0];
                for (int i = 0; i < X.Count; i++)
                    if (min_x > X[i]) min_x = X[i];
                return min_x;
            } 
        }
        static public int Max_X
        {
            get
            {
                int max_x = X[0];
                for (int i = 0; i < X.Count; i++)
                    if (max_x < X[i]) max_x = X[i];
                return max_x;
            }
        }
        static public int Min_Y
        {
            get
            {
                int min_y = Y[0];
                for (int i = 0; i < Y.Count; i++)
                    if (min_y > Y[i]) min_y = Y[i];
                return min_y;
            }
        }
        static public int Max_Y
        {
            get
            {
                int max_y = Y[0];
                for (int i = 0; i < Y.Count; i++)
                    if (max_y < Y[i]) max_y = Y[i];
                return max_y;
            }
        }

        public Cluster(int _x, int _y, ref Map map) 
        {
            for (int i = 0; i < X.Count;)
            {
                X.RemoveAt(0);
                Y.RemoveAt(0);
            }
            X.Add(_x);
            Y.Add(_y);
            map[_x, _y].Is_Cluster = true;
        }
        
    }
}
