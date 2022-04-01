using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Good
{
    internal abstract class SendData
    {
        public IBridgeComponents _iBridgeComponents;
        public abstract void Send();
    }
}
