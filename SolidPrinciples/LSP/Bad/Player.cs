using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP.Bad
{
    /// <summary>
    /// LSP: Alt sınıflarımız türetildikleri sınıfların nesneleriyle yer değiştirildikleri zaman
    /// hiç bir fark olmamalı ve aynı davranışı sergilemeli.
    /// Bu prensibe göre base classlarda ortak olarak kullanılmayacak özellikler barındırılmamalı.
    /// </summary>
    internal abstract class Player
    {
        public virtual string KickTheBall()
        {
            return "Kick the ball";
        }
        /// <summary>
        /// Aslında burada kastedilen KeepTheBall metodu sadece kaleciye özel bir durum yani tamemen player absract classı
        /// içerisinde yazılabilecek bir method değildir. Bu durum LSP'ye aykırı bir durumdur.
        /// </summary>
        /// <returns></returns>
        public virtual string KeepTheBall()
        {
            return "Keep the ball";
        }
    }
}
