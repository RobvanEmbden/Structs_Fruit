using System;

namespace retailStructsFruit
{
    class Program
    {
        static void Main(string[] args)
        {
            Coords c1 = new Coords();
            c1.x = 100;
            c1.y = 500;
            Coords c2 = c1; // c2 can be used with effecting interference from c1
            Console.WriteLine(c2.x + c2.y);
        }
        public struct Coords//refernce the object in the main method
        {// many variables can be used, now 'x & y ' but can be as many as possible
            public double x, y;
        }
    }
}
