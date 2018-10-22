using JobLogger.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobLogger.Data.Interface
{
    public interface ICandidateData
    {
        IEnumerable<Candidate> GetAll();
        Candidate Get(int candidateId);
        void Add(Candidate candidate);
        void Remove(Candidate candidate);
    }
}
