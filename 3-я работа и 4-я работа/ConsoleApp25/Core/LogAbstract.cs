using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp25.Core
{
    abstract public class LogAbstract
    {
        protected string formatLog(string[] strings)
        {
            return string.Join(";\n\r", strings);
        }
        protected void writeConsole(string s)
        {
            Console.WriteLine(s);
        }
        protected void writeConsole(string[] s)
        {
            Console.WriteLine(formatLog(s));
        }
    }
}
