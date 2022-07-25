using System;

namespace method_overloading
{
    class demo
    {
        public void Show(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        public void Show(string x, string y)
        {
            Console.WriteLine(x+y);
        }

        public void Show(float x, float y)
        {
            Console.WriteLine(x+y);
        }

        public void Show(double x, double y)
        {
            Console.WriteLine(x+y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            demo d = new demo();
            d.Show(1, 2);
            d.Show("sonu", "karan");
            d.Show(12.5F, 13.5F);
            d.Show(1.5D, 2.5D);
            Console.ReadLine();
        }
    }
}
