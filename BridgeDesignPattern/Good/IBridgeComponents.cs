using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Good
{
    internal interface IBridgeComponents
    {
        void Send(string messageType);
    }
}
