using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;


namespace RLA
{
    public class Particle
    {
        
        static double displacement = 0;
      
        public bool moved = false; // показывает, двигалась ли частица в этот ход  
        public bool in_agg = false; // показывает, является ли частица частью кластера
        public Agglomerate agg;

        public int x;
        public int y;

        public byte bonds = 0; // количество соседей данной частицы
        public Particle(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        
        //public static double Viscosity
        //{
        //    set { if (value > 0) visc = value; }
        //}
        //public static double Temperature
        //{
        //    set { if (value > 0) temp = value; }
        //}
        public static int Displacement 
            // Одна частица занимет одну клетку, следовательно, диаметр частицы есть размер клетки
            // Чтобы узнать, на сколько клеток может сдвинуться частица, необходимо поделить среднеквадратический сдвиг на радиус
        {
            get 
            {
                if (Map.radius <= 0) throw new Exception("Необходимо задать начальный радиус частицы");
                if (displacement > 0) return (int)Truncate(displacement / (2 * Map.radius));
                return (int)Truncate(Sqrt(2 * Map.Diff_coeff * Map.timestep) / (2 * Map.radius));
            }
            set
            {
                if (value > 0) displacement = value;
            }
        }
         
        public void Move(ref Map map)
        {
            
            if (agg != null)
                if (agg.Moved == true) return;
                else agg.Move(ref map);
            if (moved == true) return;
            moved = true;
            
            Random sluchai = new Random(); // вызывать со стороны?
            int angle = sluchai.Next(0, 360);
            int dy = (int)Truncate(Displacement * Sin(angle * PI / 180));
            int dx = (int)Truncate(Displacement * Cos(angle * PI / 180));
            while (Abs(dx) + Abs(dy) > 0)
            {
                if (Abs(dx) > 0) // Сначала 45, потом либо 0, либо 90. Исправить!
                {
                    if (Map.Coordinate_Check(x, y, Sign(dx), 0) == false)  Bounce(ref dx, ref dy);
                    
                    if (map[x + Sign(dx), y].Taken == true) 
                    {
                        if (Map.probability[bonds] * Map.probability[map[x + Sign(dx), y].particle.bonds] >= sluchai.Next(0, 1000001) / 1000000)
                            Fuse(ref map, x + Sign(dx), y);
                        else { dx = -dx; }
                        break; 
                    }
                    map[x, y].particle = null;
                    this.x += Sign(dx);
                    map[x, y].particle = this;
                    dx = Sign(dx) * (Abs(dx) - 1);
                    
                }
                if (Abs(dy) > 0)
                {
                    if (Map.Coordinate_Check(x, y, 0, Sign(dy)) == false) Bounce(ref dx, ref dy); 
                   
                    if (map[x, y+ Sign(dy)].Taken == true) 
                    {
                        if (Map.probability[bonds] * Map.probability[map[x, y + Sign(dy)].particle.bonds] >= sluchai.Next(0, 1000001) / 1000000)
                            Fuse(ref map, x, y + Sign(dy));
                        else {dy = -dy;}
                        break; 
                    }
                    map[x, y].particle = null;
                    this.y += Sign(dy);
                    map[x, y].particle = this;
                    dy = Sign(dy) * (Abs(dy) - 1);
                    
                }
            }
            
            

        }
        void Fuse(ref Map map, int _x, int _y)
        {
            bonds++;
            
            if (map[_x, _y].particle.in_agg == true)
            { 
                this.agg = map[_x, _y].particle.agg;
                map[_x, _y].particle.agg.agglomerate.Add(this);
                return;
            }
            this.in_agg = true;
            agg = new Agglomerate(this, map[_x, _y].particle);
           
            
        }
        void Bounce(ref int dx, ref int dy)
        {
            // Удар о вертикальную стенку приводит к смене направления движения по горизонтали
            // Удар о горизонтальную стенку приводит к смене направления движения по вертикали
            // При попадании в угол сменяется направление движения и по горизонтали, и по вертикали
            if (Map.Coordinate_Check(x, y, 0, Sign(dy)) == false) dy = -dy;
            if (Map.Coordinate_Check(x, y, Sign(dx), 0) == false) dx = -dx;
        }

    }
}
