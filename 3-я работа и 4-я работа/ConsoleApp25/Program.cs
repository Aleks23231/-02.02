using System;
using ConsoleApp25.Aleks;
using System.Collections.Generic;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
                AleksLog logger = AleksLog.I();

                Console.WriteLine("Введите 3 параметра a, b и с");

                List<float> arg = new List<float>(3);

                for (int i = 0; i < 3; i++)
                {
                    arg.Add(float.Parse(Console.ReadLine()));
                }

                logger.log($"Уравнение: {arg[0]}x^2 + {arg[1]}x + {arg[2]}");

                A b = new A();

                try
                {
                    logger.log("Корни уравнения: " + string.Join(", ", b.solve(arg[0], arg[1], arg[2]).ToArray()));
                }
                catch (AleksException e)
                {
                    logger.log(e.Message);
                }

                logger.write();
                Console.ReadKey();
            
        }
    }
}
