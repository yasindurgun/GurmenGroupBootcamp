
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP.Bad
{
    /// <summary>
    /// Not:
    /// AreaCalculator sınıfının yapacağı işi Rectangle sınıfında yapsaydık SRP a uymamış oldurduk.
    /// </summary>
    internal class AreaCalculator
    {
        //circle için Recrangle[] değil object[] yaptık. *Kodu değiştirdik.
        //public double TotalArea(Rectangle[] arrRectangles)
            public double TotalArea(Object[] arrObjects)
        {
            double area=0;

            //eski hali aşağıdaki gibi ve bunu değiştirmek zorunda kaldık.
            //foreach (var objRectangle in arrRectangles)
            //{
            //    area += objRectangle.Height * objRectangle.Width;
            //}

            //Birçok değişiklik yaptık. Görüldüğü üzere kodumuzda DEĞİŞİKLİKLER oldu ve bu durum OCP'ye aykırıdır.
            Rectangle objRectangle;
            Circle objCircle;
            foreach (var obj in arrObjects)
            {
                if (obj is Rectangle)
                {
                    objRectangle = (Rectangle)obj;
                    area += objRectangle.Height * objRectangle.Width;
                }
                else
                {
                    objCircle = (Circle)obj;
                    area += objCircle.Radius * objCircle.Radius * Math.PI;
                }
            }
            return area;
        }
    }
}
