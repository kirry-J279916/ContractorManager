using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractorManager
{
    internal class Contractor
    {
        // -- Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public decimal HourlyWage { get; set; }


        // -- Constructor
        public Contractor(string firstName, string lastName, DateTime startDate, decimal hourlyWage)
        {
            FirstName = firstName;
            LastName = lastName;
            StartDate = startDate;
            HourlyWage = hourlyWage;
        }


        // -- Show as readable text
        public override string ToString()
        {
            return $"[{FirstName} {LastName}] \nWage p.a: ${HourlyWage} \nHired: {StartDate}";
        }
    }
}
