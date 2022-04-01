using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.Good
{
    /// <summary>
    /// Programmer sadece kendine ait olan işle meşgul. ISP prensibinin çalışma mantığına göre sistemimizi iyileştirdik.
    /// </summary>
    internal class Programmer : IProgrammer
    {
        public void WorkOnTask()
        {
            //working
        }
    }
}
