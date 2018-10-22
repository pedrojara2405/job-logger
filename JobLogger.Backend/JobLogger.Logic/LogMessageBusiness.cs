using JobLogger.Entities;
using JobLogger.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobLogger.Data;

namespace JobLogger.Business

{
    public class LogMessageBusiness : ILogMessageBusiness
    {
        private LogMessageData _logMessageData;

        public LogMessageBusiness()
        {
            JobLoggerDbContext dbContext = new JobLoggerDbContext();
            _logMessageData = new LogMessageData(dbContext);
        }

        public void Add(LogMessage logMessage)
        {
            _logMessageData.Add(logMessage);
        }

        public LogMessage Get(int logMessageId)
        {
            return _logMessageData.Get(logMessageId);
        }

        public IEnumerable<LogMessage> GetAll()
        {
            return _logMessageData.GetAll();
        }
    }
}
