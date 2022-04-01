using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Bad
{
    /// <summary>
    /// Ben burada email gönderme işlemini başka bir servisle örneğin 3.parti bir servisle yapmak istediğimde bu sefer
    /// ISendUsingWebService ınterface yerine yeni bir interface tanımlayıp her iki classımada implemente etmem gerekiyor.
    /// Ben şu anda 2 sınıfa sahibim ama bu sınıfların sayısı artacak ve herbirine implemente etmem gerekecek. Hatta ileride kullanmış
    /// olduğum serviste artacak ve yeni bir interface açıp bu sefer sahip olduğum tüm sınıflara bunu implemente edicem.
    /// Dolayısıyla benim interfacelerim ve classlarım bunlara yapmış olduğum implementasyon sürekli olarak artacak ve bu durum
    /// kontrol edilemez bir hal alacak. İleride sürdürülebilir olması ve yeni featureların eklenebilir olması
    /// çok çok zorlaşacak. Dolayısıyla bu durumun önüne geçmek için bridge design pattern kullanılır.
    /// </summary>
    internal class SendEmail : ISendUsingWebService
    {
        public void Send(string senderMedium)
        {
            Console.WriteLine("Email sent using "+ senderMedium);
        }
    }
}
