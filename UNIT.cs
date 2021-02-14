using System;
using System.Collections.Generic;

namespace pj1
{
    class Unit:Obj
    {
        public enum STATE {FIND,GUARD,ATTACK}//unit states
        public enum TYPE_UNIT {ROBOT1,ROBOT2,ROBOT3};//unit type
        private enum TYPE_GOAL {ENEMY,OBJ};//what we are looking for
        private int Experience{get;set;}
        private int Energy {get;set;}//unit energy (it is spent on unit and equipment)
        private int Shield {get;set;}//the unit's defensive field if any 
        private int intellect{get;set;}//
        private int Radius{get;set;}//visual distance
        private object Weapon{get;set;}//Current weapons
        private bool LIFE {get;set;}//

        List<Obj> Storage = new List<Obj>(128);

    public bool LIVE (bool a)
    {
        if ((a==false)&&(LIFE==true)) Console.WriteLine("Unit is die!");
        LIFE=a;
        return LIFE;
    }

    public bool LIVE ()
    {
        return LIFE;
    }

    public  Unit (TYPE_UNIT n)
        {

            LIFE=true;
          
            switch (n)
            {
              case TYPE_UNIT.ROBOT1:
                   Console.WriteLine("ROBOT1");
                   NAME="ROBOT1";
                   Experience=0;
                   intellect=1;
                   Shield=0;
                   Health=100;
                   Energy=100;
                   Radius=5;
                   Angle=0;
                   Velocity=1;
                   break;
              case TYPE_UNIT.ROBOT2:
                   Console.WriteLine("ROBOT2");
                   NAME="ROBOT1";
                   Experience=0;
                   intellect=2;
                   Shield=0;
                   Health=100;
                   Energy=100;
                   Radius=5;
                   Angle=0;
                   Velocity=2;
                   break;
              case TYPE_UNIT.ROBOT3:
                   Console.WriteLine("ROBOT3");
                   NAME="ROBOT1";
                   Experience=0;
                   intellect=3;
                   Shield=0;
                   Health=100;
                   Energy=100;
                   Radius=5;
                   Angle=50;
                   Velocity=1;
                   break;
            }
            
        }

        public void Pick_up (Obj o)
        {
            Storage.Add(o);
            Console.WriteLine("We pick up object:"+o.NAME);            
        }

        public void STATE_OF_UNIT ()
        {
            Random rnd = new Random();
            int d_x,d_y;
            d_x=Convert.ToInt32(Math.Sin(base.Angle/360*2*Math.PI)*Velocity);
            d_y=Convert.ToInt32(Math.Cos(base.Angle/360*2*Math.PI)*Velocity);
            //Console.WriteLine("d_x:"+d_x);
            //Console.WriteLine("d_y:"+d_y);
            Angle=Angle+rnd.Next(0,90);
            base.Zzz(d_x,d_y);            
        }

        public void SEARCH ()
        {
            
        }


    }

}
