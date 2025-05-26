using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw pencil = new Draw();
            Draw brush = new Brush();
            Draw spray = new Spray();

            pencil.StartDraw();
            brush.StartDraw();
            spray.StartDraw();

            Something something;
            something.x = 1;
            something.y = 2;
            something.shape = "Squeaky line";
            Console.WriteLine("{0}, {1}, {2}", something.x, something.y, something.shape);
            something = new Something();
            something.x = 02;
            Console.WriteLine("{0}, {1}, {2}", something.x, something.y, something.shape);
        }
    }

    struct Something
    {
        public int x;
        public int y;
        public string shape;
    }

    public interface IDraw
    {
        void StartDraw();
    }

    class Draw : IDraw
    {
        public virtual void StartDraw()
        {
            Console.WriteLine("Using pencil");
        }
    }

    //inherit this class from the class Draw
    class Brush : Draw
    {
        public override void StartDraw()
        {
            Console.WriteLine("Using brush");
        }
    }

    //inherit this class from the class Draw
    class Spray : Draw
    {
        public override void StartDraw()
        {
            Console.WriteLine("Using spray");
        }
    }
}