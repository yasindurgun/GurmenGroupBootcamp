using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP.Good
{
    internal class GoalKeeper : Player, IKeepTheBall
    {
        /// <summary>
        /// Bu şekilde yaptığımız kullanım LSP prensibine uyumlu ve daha sağlıklı oldu. Gerçekten player base sınıfımız 
        /// her iki sınıfında base i oldu ve GoalKeeper sınıfına ekstra bir özelliği, yeteneği ınterface yapısı ile birlikte 
        /// sağlamış olduk.
        /// </summary>
        /// <returns></returns>
        public override string KickTheBall()
        {
            return "GoalKeeper kicked the ball";
        }
        public string Keep()
        {
            return "GoalKeeepr kept the ball";
        }
    }
}
