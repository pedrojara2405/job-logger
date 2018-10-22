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
    public class CandidateBusiness : ICandidateBusiness
    {
        private CandidateData _candidateData;

        public CandidateBusiness()
        {
            JobLoggerDbContext dbContext = new JobLoggerDbContext();
            _candidateData = new CandidateData(dbContext);
        }

        public void Add(Candidate candidate)
        {
            _candidateData.Add(candidate);
        }

        public Candidate Get(int candidateId)
        {
            return _candidateData.Get(candidateId);
        }

        public IEnumerable<Candidate> GetAll()
        {
            return _candidateData.GetAll();
        }

        public void Remove(Candidate candidate)
        {
            _candidateData.Remove(candidate);
        }
    }
}
