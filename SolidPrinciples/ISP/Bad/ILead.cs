using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.Bad
{
    /// <summary>
    /// ISP: Nesnelerin ihtiyaç duymadığı interfacelerden dolayısıyla interfacelerin zorunlu implementasyonalrından 
    /// mümkün olduğunca ayrıştırılmasıdır diyebiliriz. Örnek üzerinden daha anlaşılır olacaktır.
    /// </summary>
    /// 
    
    //Senaryomuz gereği Lead Task atar, taskleri küçük parçalara böler ve taskler üzerinde çalışır.
    internal interface ILead
    {
        void CreateSubTask();
        void AssignTask();
        void WorkOnTask();
    }
}
