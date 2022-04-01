using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP.Bad
{
    internal class Striker : Player
    {
        /// <summary>
        /// Player Kick ve Keep metodlarına sahip bir base class fakat Striker ın Keep özelliği bulunmamakta
        /// Dolayısı ile bu metodu override etmiyoruz ama doğru kullanım ve prensibe uyum olabilmesi aısından 
        /// bizim base classımız zaten Keep metodunu içerisinde barındırmamalıdır.
        /// </summary>
        /// <returns></returns>
        public override string KickTheBall()
        {
            return "Striker kicked the ball";
        }
        //KeepTheBall metodunu normalde burada override edip exception fırlatmak gerekir bu prensibe uyulmamasından dolayı
        //bu da fazla efor, kod kalabalığı ve kod yönetimi açısından olumsuzluklar yaratacaktır.
    }
}
