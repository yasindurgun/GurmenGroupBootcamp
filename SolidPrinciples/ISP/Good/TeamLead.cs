using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.Good
{
    internal class TeamLead : IProgrammer, ILead
    {
        public void AssignTask()
        {
            //assign tasks.
        }

        public void CreateSubTask()
        {
            //create another sub tasks.
        }

        public void WorkOnTask()
        {
            //working
        }
    }
}
