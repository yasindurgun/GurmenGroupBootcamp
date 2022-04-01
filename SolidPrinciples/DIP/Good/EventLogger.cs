using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIP.Good
{
    /// <summary>
    /// Sistemimize yeni bir loglama sistemi isteği geldiğinde çok kolay bir şekilde imlemente edebiliriz.
    /// Çünkü bağımlılıklarımızı DIP Prensibiyle birlikte azalttık ve LOOSELY COUPLED bir sistem oluşturduk.
    /// </summary>
    internal class EventLogger : ILogger
    {
        public void LogMessage(string message)
        {
            //code for writing message.
        }
    }
}
