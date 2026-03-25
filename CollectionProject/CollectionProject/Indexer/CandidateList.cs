using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Indexer
{
    public class CandidateList
    {
        public IList<Candidates> candidatesList= new List<Candidates>();

        public Candidates this[int index]
        { 
            get { return candidatesList[index]; }
            set { candidatesList[index] = value; }
        }

        //public void Add(Candidates candidate)
        //{
        //    candidatesList.candidatesListAdd(candidate);
        //}

    }
}
