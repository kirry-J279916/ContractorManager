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
        public DateTime Date { get; set; }
        public decimal Cost { get; set; }
        public bool Completed { get; set; }
        public Contractor ContractorAssigned { get; set; }


        // -- Constructor
        public Job(string title, DateTime date, decimal cost)
        {
            Title = title;
            Date = date;
            Cost = cost;
            Completed = false;
            ContractorAssigned = null;
        }
    }
}
