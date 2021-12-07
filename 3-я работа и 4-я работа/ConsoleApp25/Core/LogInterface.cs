using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp25.Core
{
    interface LogInterface
    {
        LogInterface log(string str);
        LogInterface write();
    }
}
