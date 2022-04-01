using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Good
{
    internal class SendEmail : SendData
    {
        public override void Send()
        {
            //Burada mail gönderme işlemini yapcak için bridge den faydalanıyoruz.
            _iBridgeComponents.Send("Email");
        }
    }
}
