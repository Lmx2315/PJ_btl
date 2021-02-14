using System;
using System.Collections.Generic;

namespace pj1
{
    class A
    {
        public int z{get;set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            string Q="";
            Console.WriteLine("---------");
            List<Unit> Units = new List<Unit>();   
//          List<Unit> [,] MAP = new  List<Unit> [20,20];//map of the world        

            Weapon w1=new Weapon(Weapon.TYPE_GUN.GUN1);
            Unit   u1=new Unit  (Unit.TYPE_UNIT.ROBOT1);
            Weapon w2=new Weapon(Weapon.TYPE_GUN.GUN2);
            Unit   u2=new Unit  (Unit.TYPE_UNIT.ROBOT2);

            Units.Add(u1);
            Units.Add(u2);

            Units[0].Pick_up(w1);
            Units[1].Pick_up(w2);

            while (Q!="Q")
            {
                Units[0].STATE_OF_UNIT();//defining new location
                Units[1].STATE_OF_UNIT();   

                foreach (Unit j in Units)
                {
                    foreach (Unit i in Units)
                    {
                        if (j.GetHashCode()!=i.GetHashCode())
                        {
                            if ((j.o.X==i.o.X)&&(j.o.Y==i.o.Y)) 
                            {
                                j.LIVE(false);
                                i.LIVE(false);
                            }
                        }
                    }  
                }
                       
                Q=Console.ReadLine();
            }
        }
    }
}
