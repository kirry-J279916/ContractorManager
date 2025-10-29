using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractorManager
{
    internal class Job
    {
        // -- Properties
        public string Title { get; set; }
        public decimal Cost { get; set; }
        public DateTime Date { get; set; }
        public bool Completed { get; set; }
        public Contractor ContractorAssigned { get; set; }


        // -- Constructor
        public Job(string title, decimal cost, DateTime date, bool completed = false, Contractor contractorAssigned = null)
        {
            Title = title;
            Cost = cost;
            Date = date;
            Completed = completed;
            ContractorAssigned = contractorAssigned;
        }



        // -- Show as readable text
        public override string ToString()
        {
            return $"[{Title}] \nCost: ${Cost} \nCreated: {Date} \nContractor: {ContractorAssigned}";
        }


    }
}
