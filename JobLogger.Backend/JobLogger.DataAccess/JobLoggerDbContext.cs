using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobLogger.Entities;

namespace JobLogger.DataAccess
{
    public class JobLoggerDbContext: DbContext
    {
        public JobLoggerDbContext()
            : base("name=ConnJobLoggerDb")
        {
        }

        public virtual DbSet<RecluterUser> RecluterUser { get; set; }
        public virtual DbSet<Candidate> Candidate { get; set; }
        public virtual DbSet<LogMessage> LogMessage { get; set; }
    }
}
