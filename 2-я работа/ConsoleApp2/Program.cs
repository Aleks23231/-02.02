using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        class A
        {

            public float x { get; set; }
            public float X1(float a, float b)
            {
                if (a == 0 && b!= 0)
                {
                    throw new ArgumentException();
                }
                x = -b / a;
                    return x;
            }

        }

        class B : A
        {
            public float x1 { get; set; }
            public float x2 { get; set; }
            protected static float Dis(float a, float b, float c)
            {
                return (float)(Math.Pow(b, 2) - 4 * a * c);
            }
            public Tuple<float,float> X(float a, float b, float c)
            {
                double d = Dis(a, b, c);
                if (d < 0)
                {
                    throw new ArgumentException();
                }
                if (d == 0)
                {
                   x1 = -b / 2 * a;
                }
                else
                {
                    x1 = (float) (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (float) (-b - Math.Sqrt(d)) / (2 * a);
                }
                return new Tuple<float, float>(x1, x2);
            }
        }
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine("X= {0}",a.X1(1, 10));
            B b = new B();
            Console.WriteLine( b.X(1, 10, -30));
            Console.ReadLine();
        }

    }
}