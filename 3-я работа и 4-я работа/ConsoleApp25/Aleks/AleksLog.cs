using ConsoleApp25.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp25.Aleks
{
        class AleksLog : LogAbstract, LogInterface
        {
            private List<string> myLogs = new List<string>();

            private static AleksLog instance;

            public static AleksLog I()
            {
                if (instance == null)
                    instance = new AleksLog();
                return instance;
            }

            public LogInterface log(string str)
            {
                myLogs.Add(str);
                return this;
            }

            public LogInterface write()
            {
                writeConsole(myLogs.ToArray());
                return this;
            }
        }
    
}
