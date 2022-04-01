using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIP.Good
{
    internal class ExceptionLogger
    {
        private ILogger _logger;
        public ExceptionLogger(ILogger logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Kötü kullanımdaki gibi Db için ayrı file için ayrı bir loglama yapmadık LogException içerisinde. Bunu ExceptionLogger
        /// constructorunda dışarıdan vermiş olduğum logger sayesinde gerçekleyebiliyorum.
        /// </summary>
        /// <param name="ex"></param>
        public void LogException(Exception ex)
        {
            _logger.LogMessage(ex.ToString());
        }
    }
}
