using JobLogger.Entities;
using JobLogger.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobLogger.Data
{
    public class CandidateData : ICandidateData
    {
        private JobLoggerDbContext _dbContext;

        public CandidateData(JobLoggerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Candidate candidate)
        {
            _dbContext.Candidate.Add(candidate);
        }

        public Candidate Get(int candidateId)
        {
            return _dbContext.Candidate.SingleOrDefault(c => c.CandidateId == candidateId);
        }

        public IEnumerable<Candidate> GetAll()
        {
            return _dbContext.Candidate.OrderByDescending(c => c.CandidateId).ToList();
        }

        public void Remove(Candidate candidate)
        {
            _dbContext.Candidate.Remove(candidate);
        }
    }
}
