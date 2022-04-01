using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP.Bad
{
    ///Nesnelerin yalnızca tek bir sorumluluğu olmalıdır. 
    ///Bunun nedeni geliştirmenin daha modüler olması, değişikliğin daha kolay yapılabilmesi, 
    ///daha yönetilebilir bir kod ortaya çıkarmasıdır.

    /// <summary>
    /// Bu sınıfımızda UserService SendEmail ve ValidateEmail metodlarının yapmış olduğu işleri yapmamalı.
    /// Sadece user ile ilgili olan bu örnek için register durumuna bakmalı. Buradaki email kontrolü ve
    /// mail gönderme işlemi UserService kapsamından çıkmıştır.
    /// İyi bir benzetme olması açısından sınıfımız İSVEÇ ÇAKISI gibi olmamalı.
    /// </summary>
    internal class UserService
    {
        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
            {
                throw new Exception("Email is not an email");
            }
            else
            {
                //create user.
            }

        }

        public virtual bool ValidateEmail(string email)
        {
            //Örnek olması açısından basitçe @ kontrolü yaptım.
            return email.Contains("@");
        }
        public bool SendEmail(MailMessage message)
        {
            //false ya da true dönecek şekilde simüle edelim.
            return false;
        }
    }
}
