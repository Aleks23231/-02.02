
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp25.Aleks
{

    class B
    {
        protected List<float> x;
        public List<float> LinearEquation(float a, float b)
        {
            if (a == 0)
            {
                throw new AleksException("Уравнения не существует");
            }

            AleksLog.I().log("Это линейное уравнение");
            return x = new List<float>() { -b / a };
        }

    }

}
