using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLA
{
    public class Map
    {
        public static byte c_width = 5;
        public static byte c_height = 5;
        public static int max_in_row = 100;
        public static int max_in_col = 100;
        static double particle_percent = 10;

        public static double radius;
        public static double timestep;
        public static double visc;
        public static double temp;
        public static double diff_coeff;
        public static double[] probability = { 1, 1, 1, 1 };
        public static double Diff_coeff
        {
            get
            {
                if (radius <= 0) throw new Exception("Необходимо задать начальный радиус частицы");
                if (diff_coeff > 0) return diff_coeff;
                if (temp <= 0 || visc <= 0 || radius <= 0)
                    throw new Exception("Недостаточно данных для определения коэффициента диффузии");
                return 1.3806 * Pow(10, -23) * temp / (6 * PI * visc * radius);
            }
        }

        static int Particle_num 
        {
            get { return (int)Math.Truncate(max_in_row*max_in_col * particle_percent / 100); }
        }
        static Coordinate [,] _map;
        
        public Map(double _radius, double _timestep, double [] _probability)
        {
            radius = _radius;
            timestep = _timestep;
            for (int i = 0; i < _probability.Length; i++)
                probability[i] = _probability[i];
            _map = new Coordinate[max_in_row, max_in_col];
            for (int i = 0; i < max_in_row; i++)
                for (int j = 0; j < max_in_col; j++)
                    _map[i, j] = new Coordinate();

            
        }
        public Map (double _radius, double _timestep, double[] _probability,double _visc, double _temp) : this(_radius,_timestep, _probability)
        {
            visc = _visc;
            temp = _temp;
        }
        public Map(double _radius, double _timestep, double[] _probability, double _diff_coeff ) : this(_radius, _timestep, _probability)
        {
            diff_coeff = _diff_coeff;  
        }
        public Coordinate this[int i, int j]
        {
            get { return _map[i, j]; }
            set { _map[i, j] = value; }
        }

        public static void Start_Spawn(Random sluchai)
        {
           
            int x;
            int y;

            for (int i = 0; i < Particle_num; i++)
            {
                x = sluchai.Next(0, max_in_row);
                y = sluchai.Next(0, max_in_col);
                while (Neighbours(x,y) == true )
                {
                    x = sluchai.Next(0, max_in_row); // here
                    y = sluchai.Next(0, max_in_col);
                }
                Particle part = new Particle(x, y);
                _map[x, y].particle = part;
            }
        
        }
        
        static bool Neighbours(int x, int y)
        {
            for (int i = -1; i < 2; i++)
                for (int j = -1; j < 2; j++)
                {
                    if (i != 0 && j != 0) continue; // клетки, находящиеся по диагонали, не считаются соседними
                    if ( Coordinate_Check(x,y,i,j) == false) continue;
                    if (_map[x + i, y + j ].Taken == true ) return true;
                }
            return false;
        }
        public static bool Coordinate_Check(int x, int y, int dx, int dy)
        {
            if (x + dx < 0 || y + dy < 0 || x + dx >= max_in_row || y + dy >= max_in_col)
                return false;
            else return true;
        }
    }
}
