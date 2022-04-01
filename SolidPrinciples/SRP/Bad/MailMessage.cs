using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP.Bad
{
    internal class MailMessage
    {
        public MailMessage(string from, string to)
        {
            From = from;
            To = to;
        }
        public string From { get; set; }
        public string To { get; set; }

    }
}
