using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIP.Good
{
    internal interface ILogger
    {
        void LogMessage(string message);
    }
}
