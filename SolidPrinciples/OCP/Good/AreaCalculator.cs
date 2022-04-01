using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP.Good
{
    /// <summary>
    /// OCP: Genişlemeye açık değişime kapalı. Bu prensibi anlamak kod örnekleri ile daha mümkün.
    /// Örneğimizde de bu durum açıkça ele alınmış ve somutlaştırılmıştır.
    /// </summary>
    internal class AreaCalculator
    {
        //Burada Shape[] dizisi tutuyoruz. Circle ve Rectangle bu Shape ten inheritasyon aldıklarından dolayı
        //Her iki tip içinde shape referans tutucu görevi görüyor ve rahatlıkla bu şekilde tutabiliyoruz.
        public double TotalArea(Shape[] arrShapes)
        {
            double area = 0;
            foreach (var objShape in arrShapes)
            {
                //Burada objShape circle da olabilir rectangle da Shape[] tutabildiğimiz için her iki şeklimizde bunu kalıtım
                //olarak alıyordu. Dolayısıyla problem yok. Bir diğer açı ise her şekilin kendi içinde Area() fonksiyonu
                //o şeklin dinamiklerine göre ilgili hesaplamayı yapıyor. Böylece buraya kod yazmamıza gerek kalmıyor.
                //Ben başka bir shape eklesem ve o Shape class ından kalıtım alsa bu kısımda herhangi bir değişiklik yapmadan
                //yeni eklediğim shape içinde burası çalışıyor olacak.
                area += objShape.Area();
            }
            return area;
        }
    }
}
