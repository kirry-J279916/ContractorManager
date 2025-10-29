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



        // -- Method to add a Contractor to the Contractors list.
        public void AddContractor(Contractor contractor)
        {
            Contractors.Add(contractor);
        }

        // -- Method to remove a Contractor from the Contractors list.
        public void RemoveContractor(Contractor contractor)
        {
            Contractors.Remove(contractor);
        }



        // -- Method to add a Job to the Job list.
        public void AddJob(Job job)
        {
            Jobs.Add(job);
        }



        // -- Method to assign Contractor to Job.
        public void AssignJob(Contractor contractor, Job job)
        {
            job.ContractorAssigned = contractor;
        }



    }
}
