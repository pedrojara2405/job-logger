using System;
using System.IO;
using System.Text;

namespace LoggerService
{
    /*
     *  Sealed ensures the class being inherited and
     *  object instantiation is restricted in the derived class
     */
    public sealed class Log : ILoggger
    {
        /*
        * Private constructor ensures that object is not
        * instantiated other than with in the class itself
        */
        private Log()
        {
        }

        /*
         * Private property initilized with null
         * ensures that only one instance of the object is created
         * based on the null condition
       */
        private static readonly Lazy<Log> _instance = new Lazy<Log>(() => new Log());
        //private static Log instance = null;

        /*
         * public property is used to return only one instance of the class
         * leveraging on the private property
         */
        public static Log GetInstance => _instance.Value;

        public void LogException(string message)
        {
            string fileName = string.Format("{0}-{1}.log", "Exception" + DateTime.UtcNow.ToString(("MM-dd-yyyy")));
            string logFilePath = string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory, fileName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------------------------------------------------------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(message);
            using (StreamWriter writer = new StreamWriter(logFilePath))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }
    }
}
