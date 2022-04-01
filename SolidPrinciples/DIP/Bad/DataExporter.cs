using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIP.Bad
{
    internal class DataExporter
    {
        public void ExportDataFromFile()
        {
            try
            {
                //code for exporting data.
            }
            //senaryo gereği eğer bir IO hatası olursa dbye loglamak istiyorum.
            catch (IOException ex)
            {
                new ExceptionLogger().LogIntoDataBase(ex);
            }
            catch (Exception ex)
            {
                new ExceptionLogger().LogIntoFile(ex);
            }
            
        }
    }
}
