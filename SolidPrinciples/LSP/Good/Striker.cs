using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP.Good
{
    internal class Striker : Player
    {
        public override string KickTheBall()
        {
            return "Striker kicked the ball";
        }
    }
}
