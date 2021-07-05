using System;
using System.Collections.Generic;
using static System.Math;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLA
{
    public class Agglomerate
    {
        static double alpha = -1.2; // displacement = basic_displacement * particle_num^alpha
        bool moved = false; // Показывает, двигался ли кластер за этот ход
        public bool Moved
        {
            get { return moved;  }
            set 
            {
                if (agglomerate == null) return;
                for (int i = 0; i < agglomerate.Count; i++)
                    agglomerate[i].moved = value;
                moved = value;
            } 
        
        }

        int Displacement
        {
            get { return (int) Truncate(Particle.Displacement * Pow(Particle_number, alpha)); }
        }

        int Particle_number 
        {
            get 
            {
                if (agglomerate == null) return 0;
                return agglomerate.Count;
            }
        }
       
        public List<Particle> agglomerate = new List<Particle>();
        public Agglomerate(Particle p1, Particle p2)
        {
            agglomerate.Add(p1);
            agglomerate.Add(p2);
            for (int i = 0; i < agglomerate.Count; i++)
            {
                agglomerate[i].agg = this;
            }
        }
        Agglomerate(Agglomerate p1, Agglomerate p2)
        {
            agglomerate.AddRange(p1.agglomerate);
            agglomerate.AddRange(p2.agglomerate);
            for (int i = 0; i < agglomerate.Count; i++)
            {
                agglomerate[i].agg = this;
            }
            p1 = null; // ?????????????????
            p2 = null;
        }

        public void Move(ref Map map)
        {
            Random sluchai = new Random(); // вызывать со стороны?
            int angle = sluchai.Next(0, 360);
            int dy = (int)Truncate(Displacement * Sin(angle * PI / 180));
            int dx = (int)Truncate(Displacement * Cos(angle * PI / 180));
            Moved = true;
            while (Abs(dx) + Abs(dy) > 0)
            {
                bool hor = false;
                bool ver = false;
                for (int i = 0; i < agglomerate.Count; i++)
                {
                    if (hor == true && ver == true) 
                        break;
                    if (Abs(dx) > 0 && hor == false)
                    {
                        if (Map.Coordinate_Check(agglomerate[i].x, agglomerate[i].y, Sign(dx), 0) == false) 
                            Bounce(ref dx, ref dy, i, ref hor, ref ver);

                    }
                    if (Abs(dy) > 0 && ver == false)
                    {
                        if (Map.Coordinate_Check(agglomerate[i].x, agglomerate[i].y, 0, Sign(dy)) == false) 
                            Bounce(ref dx, ref dy, i, ref hor, ref ver);
                    }
                }

                for (int i = 0; i < agglomerate.Count; i++)
                {
                    if (Abs(dx) > 0)
                    {
                        if (map[agglomerate[i].x + Sign(dx), agglomerate[i].y].particle != null && map[agglomerate[i].x + Sign(dx), agglomerate[i].y].particle.agg != null && map[agglomerate[i].x + Sign(dx), agglomerate[i].y].particle?.agg != this  )
                        {
                            if 
                                (Map.probability[map[agglomerate[i].x, agglomerate[i].y].particle.bonds] * Map.probability[map[agglomerate[i].x + Sign(dx), agglomerate[i].y].particle.bonds] 
                                >= sluchai.Next(0, 1000001) / 1000000)
                            Fuse(map[agglomerate[i].x + Sign(dx), agglomerate[i].y].particle.agg);
                            return;
                        }
                        if (map[agglomerate[i].x, agglomerate[i].y + Sign(dy)].particle != null && map[agglomerate[i].x, agglomerate[i].y + Sign(dy)].particle.agg != null && map[agglomerate[i].x, agglomerate[i].y + Sign(dy)].particle?.agg != this)
                        {
                            if
                                (Map.probability[map[agglomerate[i].x, agglomerate[i].y].particle.bonds] * Map.probability[map[agglomerate[i].x, agglomerate[i].y + Sign(dy)].particle.bonds]
                                >= sluchai.Next(0, 1000001) / 1000000)
                                Fuse(map[agglomerate[i].x, agglomerate[i].y + Sign(dy)].particle.agg);
                            return;
                        }
                    }

                }
                for (int i = 0; i < agglomerate.Count; i++)
                {
                    map[agglomerate[i].x, agglomerate[i].y].particle = null;
                    if (Abs(dx) > 0) 
                    {
                        if (Map.Coordinate_Check(agglomerate[i].x, agglomerate[i].y, Sign(dx), 0) == false) dx = 0; // ???
                            agglomerate[i].x += Sign(dx);
                    }
                    if (Abs(dy) > 0)
                    {
                        if (Map.Coordinate_Check(agglomerate[i].x, agglomerate[i].y,0, Sign(dy)) == false) dy = 0;  // ???
                        agglomerate[i].y += Sign(dy);
                    }
                    map[agglomerate[i].x, agglomerate[i].y].particle = agglomerate[i];
                }
                
                dx = Sign(dx) * (Abs(dx) - 1);
                dy = Sign(dy) * (Abs(dy) - 1);

            }
        
        }
        void Bounce(ref int dx, ref int dy, int i, ref bool hor, ref bool ver)
        {
            if (Map.Coordinate_Check(agglomerate[i].x, agglomerate[i].y, 0, Sign(dy)) == false) { dy = -dy; ver = true; }
            if (Map.Coordinate_Check(agglomerate[i].x, agglomerate[i].y, Sign(dx), 0) == false) { dx = -dx; hor = true; }
        }
        public void Fuse(Agglomerate a2) 
        {
            Agglomerate biggerag = new Agglomerate(this, a2); // добавлять в коллекцию map
        }
         
    }
}
