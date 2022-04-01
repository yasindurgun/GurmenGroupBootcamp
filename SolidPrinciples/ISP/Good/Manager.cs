using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.Good
{
    /// <summary>
    /// Manager sadece kendine ait olan işle meşgul. Fazlalık bir durum yok. Bu durumu ISP sayesinde yaptık.
    /// </summary>
    internal class Manager : ILead
    {
        public void AssignTask()
        {
            //assign tasks.
        }

        public void CreateSubTask()
        {
            //create another sub tasks.
        }
    }
}
