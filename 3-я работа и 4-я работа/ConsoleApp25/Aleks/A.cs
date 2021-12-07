using System;
using ConsoleApp25.Core;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp25.Aleks
{

    class A : B, EquationInterface
    {
        public List<float> solve(float a, float b, float c)
        {
            if (a == 0)
            {
                return LinearEquation(b, c);
            }

            AleksLog.I().log("Это квадратное уравнение");

            double D = Discriminant(a, b, c);

            if (D < 0)
                throw new AleksException("Дискриминант меньше нуля");

            if (D == 0)
                return x = new List<float>() { -b / (2 * a) };

            D = Math.Sqrt(D);
            return x = new List<float>() { (float)(-b + D) / (2 * a), (float)(-b - D) / (2 * a) };
        }

        private float Discriminant(float a, float b, float c)
        {
            return (b * b) - (4 * a * c);
        }
    }
}
