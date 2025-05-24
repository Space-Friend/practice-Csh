using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "1";
            int points1 = 2;
            string name2 = "two";
            int points2 = 3;

            DancerPoints dancer1 = new DancerPoints(name1, points1);
            DancerPoints dancer2 = new DancerPoints(name2, points2);

            DancerPoints total = dancer1 + dancer2;
            Console.WriteLine(total.name);
            Console.WriteLine(total.points);
            Ahno a = new Ahno();
            a.Sayit();
        }
    }
    class DancerPoints
    {
        public string name;
        public int points;
        public DancerPoints(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public static DancerPoints operator +(DancerPoints a, DancerPoints b)
        {
            DancerPoints res = new DancerPoints(a.name + " & " + b.name, a.points + b.points);
            return res;
        }
    }
    class Ahyes
    {
        protected string Ah = "Ah";
    }
    class Ahno : Ahyes
    {
        public void Sayit()
        {
            Console.WriteLine(Ah);
        }
    }
}