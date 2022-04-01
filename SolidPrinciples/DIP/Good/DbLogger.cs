using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIP.Good
{
    internal class DbLogger : ILogger
    {
        public void LogMessage(string message)
        {
            //code for writing message to db
        }
    }
}
