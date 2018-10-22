using JobLogger.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobLogger.Business.Interface
{
    public interface ICandidateBusiness
    {
        IEnumerable<Candidate> GetAll();
        Candidate Get(int candidateId);
        void Add(Candidate candidate);
        void Remove(Candidate candidate);
    }
}
