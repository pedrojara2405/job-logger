using JobLogger.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobLogger.Data.Interface
{
    public interface IRecluterUserData
    {
        IEnumerable<RecluterUser> GetAll();
        RecluterUser Get(int recluterUserId);
    }
}
