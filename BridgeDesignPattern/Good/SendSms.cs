using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Good
{
    internal class SendSms : SendData
    {
        public override void Send()
        {
            _iBridgeComponents.Send("Sms");
        }
    }
}
