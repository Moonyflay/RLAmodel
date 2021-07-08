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
        static int max_in_row = 500;
        static double particle_percent = 1;

        static double radius;
        static double timestep;
        static double visc;
        static double temp;
        static double diff_coeff;
        static double displacement;
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
        public static int Displacement
        // Одна частица занимет одну клетку, следовательно, диаметр частицы есть размер клетки
        // Чтобы узнать, на сколько клеток может сдвинуться частица, необходимо поделить среднеквадратический сдвиг на радиус
        {
            get
            {
                if (radius <= 0) throw new Exception("Необходимо задать начальный радиус частицы");
                if (displacement > 0) return (int)Truncate(displacement / (2 * radius));
                return (int)Truncate(Sqrt(2 * Diff_coeff * timestep) / (2 * radius));
            }
        }

        static int Particle_num 
        {
            get { return (int)Truncate(max_in_row*max_in_row * particle_percent / 100); }
        }
        static Coordinate [,] _map;
        
         Map(double _radius, double [] _probability, int _max_in_row, double _particle_percent)
        {
            diff_coeff = 0;
            displacement = 0;
            visc = 0;
            temp = 0;

            radius = _radius;
           
           
            max_in_row = _max_in_row;
            particle_percent = _particle_percent;
            for (int i = 0; i < _probability.Length; i++)
                probability[i] = _probability[i];
            _map = new Coordinate[max_in_row, max_in_row];
            for (int i = 0; i < max_in_row; i++)
                for (int j = 0; j < max_in_row; j++)
                    _map[i, j] = new Coordinate();

            
        }
        public Map (double _radius, double _timestep, double[] _probability, int _max_in_row, double _particle_percent, double _visc, double _temp) : this(_radius, _probability,_max_in_row, _particle_percent)
        {
            visc = _visc;
            temp = _temp;
            timestep = _timestep;
        }
        public Map(double _radius, double _timestep, double[] _probability, int _max_in_row, double _particle_percent, double _diff_coeff ) : this(_radius,  _probability, _max_in_row, _particle_percent)
        {
            diff_coeff = _diff_coeff;
            timestep = _timestep;
        }
        public Map(double _displacement, double _radius,  double[] _probability, int _max_in_row, double _particle_percent) : this(_radius,  _probability,  _max_in_row, _particle_percent)
        {
            displacement = _displacement;
        }
        public Coordinate this[int i, int j]
        {
            get { return _map[i, j]; }
            set { _map[i, j] = value; }
        }

        public static void Start_Spawn()
        {
            for (int i = 0; i < Particle_num; i++)
            {
                Single_Spawn();  
            }
        
        }
        public static void Single_Spawn() 
        {
            int x;
            int y;
            x = FormMain.sluchai.Next(0, max_in_row);
            y = FormMain.sluchai.Next(0, max_in_row);
            while (Neighbours(x, y) == true || ( x > Cluster.Min_X && x < Cluster.Max_X && y > Cluster.Min_Y && y < Cluster.Max_Y) )
            {
                x = FormMain.sluchai.Next(0, max_in_row); 
                y = FormMain.sluchai.Next(0, max_in_row);
            }
            _map[x, y].particle.Add(new Particle(x, y));

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
            if (x + dx < 0 || y + dy < 0 || x + dx >= max_in_row || y + dy >= max_in_row)
                return false;
            else return true;
        }
    }
}
