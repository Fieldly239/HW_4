using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public abstract class Job
    {
        //property
        public string Name { get; set; }
        public string Occupation { get; set; }
        public decimal Salary { get; set; }
        public int Tax { get; set; }
        //constructor
        public Job(string name, string occupation, decimal salary, int tax)
        {
            Name = name;
            Occupation = occupation;
            Salary = salary;
            Tax = tax;
        }

        

        //method
        public string WhoAmI()
        {
            return "I love my job!";
        }

        public abstract decimal GetTax();
        


    }
}
