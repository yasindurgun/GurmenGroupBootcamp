using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIP.Bad
{
    internal class ExceptionLogger
    {
        public void LogIntoFile(Exception ex)
        {
            //Burada direkt olarak nesnesin kendisine bir bağımlılık var bu DIP Prensibine aykırı bir durumdur.
            //Buradaki bu şekilde yapılan bağlantı kesinlikle TIGHTLY COUPLED bir yapı oluşturur. Bu istenmeyen bir durumdur.
            FileLogger fileLogger = new FileLogger();
            fileLogger.LogMessage(ex.ToString());
        }
        //Buraya iknci bir logger ı bu şekilde eklemiş oldum. Senaryo gereği eğer bir IO hatası olursa dbye loglamak istiyorum.
        public void LogIntoDataBase(Exception ex)
        {
            DbLogger dbLogger = new DbLogger();
            dbLogger.LogMessage(ex.ToString());
        }
    }
}
