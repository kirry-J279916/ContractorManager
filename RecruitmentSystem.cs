using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractorManager
{
    internal class RecruitmentSystem
    {
        // -- Properties
        public List<Contractor> ContractorsList { get; set; }
        public List<Job> JobsList { get; set; }


        // -- Constructor
        public RecruitmentSystem()
        {
            // Set new lists for contractors and jobs.
            ContractorsList = new List<Contractor>();
            JobsList = new List<Job>();
        }



        // -- Method to add a Contractor to the Contractors list.
        public void AddContractor(Contractor contractor)
        {
            ContractorsList.Add(contractor);
        }

        // -- Method to remove a Contractor from the Contractors list.
        public void RemoveContractor(Contractor contractor)
        {
            ContractorsList.Remove(contractor);
        }



        // -- Method to add a Job to the Job list.
        public void AddJob(Job job)
        {
            JobsList.Add(job);
        }



        // -- Method to assign Contractor to Job.
        public void AssignJob(Contractor contractor, Job job)
        {
            job.ContractorAssigned = contractor;
        }



        // -- Method to mark Job as completed.




        // -- Method to get all Contractors.
        public List<Contractor> GetContractors()
        {
            return ContractorsList;
        }



        // -- Method to get all Jobs.




        // -- Method to get only available Contractors.




        // -- Method to filter and get only unassigned Jobs.




        // -- Method to filter and get Jobs by cost.



    }
}
