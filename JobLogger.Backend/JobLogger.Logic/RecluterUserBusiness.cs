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
    public class RecluterUserBusiness : IRecluterUserBusiness
    {
        private RecluterUserData _recluterUserData;

        public RecluterUserBusiness()
        {
            JobLoggerDbContext dbContext = new JobLoggerDbContext();
            _recluterUserData = new RecluterUserData(dbContext);
        }
        public RecluterUser Get(int recluterUserId)
        {
            return _recluterUserData.Get(recluterUserId);
        }

        public IEnumerable<RecluterUser> GetAll()
        {
            return _recluterUserData.GetAll();
        }
    }
}
