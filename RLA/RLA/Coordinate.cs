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
            get { if (particle.Count > 0 || Is_Cluster == true) return true; else return false; }// Показывает, есть ли в данной клетке частица или нет
        }
        public List<Particle> particle = new List<Particle>();
        public bool Is_Cluster = false;
        public Coordinate ()
        {
            
        }
        //public System.Drawing.Color Cell_Color
        //{
        //    get 
        //    {
        //        if (Taken == true) 
        //         if (Is_Cluster == true) return System.Drawing.Color.Red;
        //            else return System.Drawing.Color.Black;
        //        else return System.Drawing.Color.White;
        //    }
        //}
    }
}
