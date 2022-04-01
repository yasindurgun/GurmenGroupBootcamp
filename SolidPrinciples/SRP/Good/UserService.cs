using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP.Good
{
    /// <summary>
    /// Doğru kullanımı bu şekildedir. UserService kendi işini EmailService kendi işini yapıyor.
    /// Dolayısıyla single responsibility olabilmesi için bu örnekte farklı bir service içerisinde mail işlemlerini yaptık
    /// Her sınıf böylece kendine has işlemleri yapmış oldu.
    /// </summary>


    internal class UserService
    {
        //Burada efcore paketini yüklemek istemedim.

        EmailService _emailService;
        //DbContext _dbContext;
        public UserService(EmailService aEmailService /*DbContext aDbContext*/)
        {
            _emailService = aEmailService;
            //_dbContext = aDbContext;
        }
        public void Register(string email, string password)
        {
            if (!_emailService.ValidateEmail(email))
                throw new Exception("Email is not an email");
            //create user
            //var user = new User(email, password);

            //db ye kaydediyoruz.
            //_dbContext.Save(user);
            _emailService.SendEmail(new MailMessage("myname@mydomain.com", email));

        }
    }
}
