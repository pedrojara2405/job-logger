using JobLogger.Entities;
using System.Collections.Generic;

namespace JobLogger.Business.Interface
{
    public interface IRecluterUserBusiness
    {
        IEnumerable<RecluterUser> GetAll();
        RecluterUser Get(int recluterUserId);
    }
}
