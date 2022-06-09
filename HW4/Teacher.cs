using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public class Teacher : Job
    {
        public Teacher(string name, string occupation, decimal salary, int tax) : base(name, occupation, salary, tax)
        {
        }
        public string WhoAmI()
        {
            return "I am is a Teacher";
        }

        public override decimal GetTax()
        {
            return (this.Tax * this.Salary) / 100;
        }
    }
}
