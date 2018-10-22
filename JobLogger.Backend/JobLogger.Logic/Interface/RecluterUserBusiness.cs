using JobLogger.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobLogger.Logic.Interface
{
    public interface RecluterUserBusiness
    {
        IEnumerable<RecluterUser> GetAll();
        RecluterUser Get(int id);
    }
}
