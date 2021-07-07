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
        public bool moved = false; // показывает, двигалась ли частица в этот ход  
        public bool To_Delete = false;

        public int x;
        public int y;

        public Particle(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
     
        public void Move(ref Map map) 
        {
            if (moved == true) return;
            moved = true;
            int angle = FormMain.sluchai.Next(0, 360);
            int dy = (int)Truncate(Map.Displacement * Sin(angle * PI / 180));
            int dx = (int)Truncate(Map.Displacement * Cos(angle * PI / 180));

            while (Abs(dx) + Abs(dy) > 0)
            {

                if (Abs(dx) > 0 || Abs(dy) > 0) 
                {
                    if (Map.Coordinate_Check(x, y, 0, Sign(dy)) == false || Map.Coordinate_Check(x, y, Sign(dx), 0) == false)
                    {
                        To_Delete = true;
                        return;
                    }
                }

                if ((Abs(dx) > 0 && map[x + Sign(dx), y].Is_Cluster == true) || (Abs(dy) > 0 && map[x, y + Sign(dy)].Is_Cluster == true))
                {
                    double P = Map.probability[0];
                    if (map[x + Sign(dx), y].Is_Cluster == true) P *= Map.probability[Probability_Count(x + Sign(dx),y,ref map)];
                    else P *= Map.probability[Probability_Count(x, y + Sign(dy), ref map)];
                    if (P >= FormMain.sluchai.Next(0, 1000001) / 1000000.0)
                    {
                        Cluster.X.Add(x);
                        Cluster.Y.Add(y);
                        map[x, y].Is_Cluster = true;
                        To_Delete = true;
                        return;
                    }

                }

                map[x, y].particle.Remove(this);
                if (Abs(dx) > 0)  
                {
                    if (map[x + Sign(dx), y].Taken == true) dx = -dx;
                    else x += Sign(dx);
                }
                   
                if (Abs(dy) > 0)
                {
                    if (map[x , y + Sign(dy)].Taken == true) dy = -dy;
                    else y += Sign(dy);
                }
                    map[x, y].particle.Add(this);

                 dx = Sign(dx) * (Abs(dx) - 1);
                 dy = Sign(dy) * (Abs(dy) - 1);
            }
        }
         
        byte Probability_Count(int x, int y, ref Map map)
        {
            byte N = 0;
            for (int i = -1; i < 2; i++)
                for (int j = -1; j < 2; j++)
                {
                    if ((i == 0 ^ j == 0 )== false ) continue; // клетки, находящиеся по диагонали, не считаются соседними
                    if (Map.Coordinate_Check(x, y, i, j) == false) continue;
                    if (map[x + i, y + j].Is_Cluster == true) N++;
                }
            return N;
        }

        //public void Move(ref Map map)
        //{

        //    if (agg != null)
        //        if (agg.Moved == true) return;
        //        else agg.Move(ref map);
        //    if (moved == true) return;
        //    moved = true;

        //    Random sluchai = new Random(); // вызывать со стороны?
        //    int angle = sluchai.Next(0, 360);
        //    int dy = (int)Truncate(Displacement * Sin(angle * PI / 180));
        //    int dx = (int)Truncate(Displacement * Cos(angle * PI / 180));
        //    while (Abs(dx) + Abs(dy) > 0)
        //    {
        //        if (Abs(dx) > 0) // Сначала 45, потом либо 0, либо 90. Исправить!
        //        {
        //            if (Map.Coordinate_Check(x, y, Sign(dx), 0) == false)  Bounce(ref dx, ref dy);

        //            if (map[x + Sign(dx), y].Taken == true) 
        //            {
        //                if (Map.probability[bonds] * Map.probability[map[x + Sign(dx), y].particle.bonds] >= sluchai.Next(0, 1000001) / 1000000)
        //                    Fuse(ref map, x + Sign(dx), y);
        //                else { dx = -dx; }
        //                break; 
        //            }
        //            map[x, y].particle = null;
        //            this.x += Sign(dx);
        //            map[x, y].particle = this;
        //            dx = Sign(dx) * (Abs(dx) - 1);

        //        }
        //        if (Abs(dy) > 0)
        //        {
        //            if (Map.Coordinate_Check(x, y, 0, Sign(dy)) == false) Bounce(ref dx, ref dy); 

        //            if (map[x, y+ Sign(dy)].Taken == true) 
        //            {
        //                if (Map.probability[bonds] * Map.probability[map[x, y + Sign(dy)].particle.bonds] >= sluchai.Next(0, 1000001) / 1000000)
        //                    Fuse(ref map, x, y + Sign(dy));
        //                else {dy = -dy;}
        //                break; 
        //            }
        //            map[x, y].particle = null;
        //            this.y += Sign(dy);
        //            map[x, y].particle = this;
        //            dy = Sign(dy) * (Abs(dy) - 1);

        //        }
        //    }



        //}
        //void Fuse(ref Map map, int _x, int _y)
        //{
        //    bonds++;

        //    if (map[_x, _y].particle.in_agg == true)
        //    { 
        //        this.agg = map[_x, _y].particle.agg;
        //        map[_x, _y].particle.agg.agglomerate.Add(this);
        //        return;
        //    }
        //    this.in_agg = true;
        //    agg = new Agglomerate(this, map[_x, _y].particle);


        //}


    }
}
