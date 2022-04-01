using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP.Bad
{
    internal class GoalKeeper : Player
    {
        public override string KeepTheBall()
        {
            return "Goalkeeper kept the ball";
        }
        public override string KickTheBall()
        {
            return "Goalkeeper kicked the ball";
        }
    }
}
