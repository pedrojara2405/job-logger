using JobLogger.Entities;
using JobLogger.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobLogger.Data
{
    public class RecluterUserData : IRecluterUserData
    {
        private JobLoggerDbContext _dbContext;
        public RecluterUserData(JobLoggerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public RecluterUser Get(int recluterUserId)
        {
            return _dbContext.RecluterUser.SingleOrDefault(c => c.RecluterUserId == recluterUserId);
        }

        public IEnumerable<RecluterUser> GetAll()
        {
            return _dbContext.RecluterUser.OrderByDescending(c => c.RecluterUserId).ToList();
        }
    }
}
