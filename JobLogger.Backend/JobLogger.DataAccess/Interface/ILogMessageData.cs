using JobLogger.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobLogger.Data.Interface
{
    public interface ILogMessageData
    {
        IEnumerable<LogMessage> GetAll();
        LogMessage Get(int logMessageId);
        void Add(LogMessage logMessage);
    }
}
