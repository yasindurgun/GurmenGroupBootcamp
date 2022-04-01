using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP.Good
{
    internal abstract class Player
    {
        public virtual string KickTheBall()
        {
            return "Kick the ball";
        }
    }
}
