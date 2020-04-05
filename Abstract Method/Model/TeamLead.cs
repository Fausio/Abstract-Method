using Abstract_Method.Model.abstract_class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Method.Model
{
    class TeamLead : Employee
    {
        public int Size { get; set; }
        public override void Details()
        {
            base.Details();
            Console.WriteLine("Size :" + Size);
        }

        public override void CalculateSalary(int NoOfWorkingHours)
        {
            //HRA 30.5%
            double BS = (SalPerHour * NoOfWorkingHours);
            double HRA = BS * 30.5 / 100;
            double GS = BS + HRA;
            Console.WriteLine("Gross Salary Of TeamLead is :" + GS);
        }

        public override void CalculateLeaves()
        {
            Console.WriteLine("This is calculating Leaves of TL");
        }
    }
}
