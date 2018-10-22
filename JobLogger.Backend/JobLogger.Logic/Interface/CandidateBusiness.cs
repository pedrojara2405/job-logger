using JobLogger.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobLogger.Logic.Interface
{
    public interface CandidateBusiness
    {
        IEnumerable<Candidate> GetAll();
        Candidate Get(int id);
        void Add(Candidate candidate);
        void Remove(Candidate candidate);
    }
}
