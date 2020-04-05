using Abstract_Method.Model.abstract_class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Method.Model
{
    class SoftwareEng : Employee
    {
        public string Technology { get; set; }

        public override void Details()
        {
            base.Details();
            Console.WriteLine("Technology :" + Technology);
        }

        public override void CalculateSalary(int NoOfWorkingHours)
        {
            //HRA 15%
            double BS = (SalPerHour * NoOfWorkingHours);
            double HRA = BS * 15 / 100;
            double GS = BS + HRA;
            Console.WriteLine("Gross Salary Of SE is :" + GS);
        }
        public override void CalculateLeaves()
        {
            Console.WriteLine("This is calculating Leaves of SE");
        }
    }
}
