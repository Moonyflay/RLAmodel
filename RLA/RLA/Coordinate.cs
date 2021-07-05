using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLA
{
    public class Coordinate
    {
        
        public bool Taken
        {
            get { if (particle != null) return true; else return false; }// Показывает, есть ли в данной клетке частица или нет
        }
        public Particle particle = null;
        public Coordinate ()
        {
            
        }
        public System.Drawing.Color Cell_Color
        {
            get 
            {
                if (Taken == true) 
                    if (particle.agg != null) return System.Drawing.Color.Blue;
                else return System.Drawing.Color.Black;
                else return System.Drawing.Color.White;
            }
        }
    }
}
