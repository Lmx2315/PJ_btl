using System;
using System.Collections.Generic;

namespace pj1
{
     public struct Point 
        {
          public int X;
          public int Y;
        }
    abstract class Obj
    {
        static int Col;
        private int ID{get;set;}//serial number
        private int Hash{get;set;}//unique identifier
        public string NAME {get;set;}
        public double Velocity {get;set;}
        public double Angle {get;set;}//direction angle
        private int Weight{get;set;}//the total weight of a unit
        public int Health{get;set;} //
        public Point o; 
    public  Obj ()
        {
             Col    =Col+1;
              ID    =Col;       
        }

    public void Zzz (int dx,int dy)
        {
            o.X=o.X+dx;
            o.Y=o.Y+dy;
            Console.WriteLine("Y:"+o.Y);
            Console.WriteLine("X:"+o.X);
        }



    }

}
