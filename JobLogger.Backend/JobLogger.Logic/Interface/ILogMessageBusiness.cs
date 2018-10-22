using JobLogger.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobLogger.Business.Interface
{
    public interface ILogMessageBusiness
    {
        IEnumerable<LogMessage> GetAll();
        LogMessage Get(int logMessageId);
        void Add(LogMessage logMessage);
    }
}
