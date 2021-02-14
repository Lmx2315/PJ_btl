using System;
using System.Collections.Generic;

namespace pj1
{
    class Weapon:Obj
    {
        public enum TYPE_GUN {GUN1,GUN2,GUN3}; 
        private static int COL;//numbers of weapons
        private int Power {get;set;}//
        private int Energy{get;set;}//unit energy (it is spent on unit and equipment
        private int Range{get;set;}//weapon range
        private int Accuracy{get;set;}//

        public Weapon (TYPE_GUN n)
        {
            COL=COL+1;
            switch (n)
            {
                case TYPE_GUN.GUN1:Console.WriteLine("Created GUN1");
                NAME="GUN1";
                Range=1;
                Accuracy=50;
                Health=100;
                Energy=100;
                Power=30;
                break;
                case TYPE_GUN.GUN2:Console.WriteLine("Created GUN2");
                NAME="GUN2";
                Range=2;
                Accuracy=25;
                Health=100;
                Energy=100;
                Power=20;
                break;
                case TYPE_GUN.GUN3:Console.WriteLine("Created GUN3");
                NAME="GUN1";
                Range=3;
                Accuracy=12;
                Health=100;
                Energy=100;
                Power=30;
                break;
            }
        }

        
    }

}
