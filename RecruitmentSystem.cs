using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractorManager
{
    internal class RecruitmentSystem
    {
        // -- Properties
        public List<Contractor> Contractors { get; set; }
        public List<Job> Jobs { get; set; }


        // -- Constructor
        public RecruitmentSystem()
        {
            // Set new lists for contractors and jobs.
            Contractors = new List<Contractor>();
            Jobs = new List<Job>();
        }


        // -- Methods
        public List<Contractor> AddContractor(Contractor contractor)
        {
            Contractors.Add(contractor);
            return Contractors;
        }
    }
}
