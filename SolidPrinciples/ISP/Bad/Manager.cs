using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.Bad
{
    //Senaryomuz gereği manager taskleri atar ve taskleri küçük parçalara böler.
    internal class Manager : ILead
    {
        public void AssignTask()
        {
            throw new NotImplementedException();
        }

        public void CreateSubTask()
        {
            throw new NotImplementedException();
        }

        //Bu method manager için gereksiz bir method ISP prensibine aykırı bir durum
        public void WorkOnTask()
        {
            throw new Exception("Manager cant work");
        }
    }
}
