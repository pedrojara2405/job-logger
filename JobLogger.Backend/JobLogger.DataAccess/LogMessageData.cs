using JobLogger.Data.Interface;
using JobLogger.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JobLogger.Data
{
    public class LogMessageData : ILogMessageData
    {
        private JobLoggerDbContext _dbContext;

        public LogMessageData(JobLoggerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(LogMessage logMessage)
        {
            _dbContext.LogMessage.Add(logMessage);
        }

        public LogMessage Get(int logMessageId)
        {
            return _dbContext.LogMessage.SingleOrDefault(c => c.LogMessageId == logMessageId);
        }

        public IEnumerable<LogMessage> GetAll()
        {
            return _dbContext.LogMessage.OrderByDescending(c => c.LogMessageId).ToList();
        }
    }
}
