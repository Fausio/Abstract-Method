using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Method.Model.abstract_class
{
    abstract class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public double SalPerHour { get; set; }

        public virtual void Details()
        {
            Console.WriteLine("EmpId :" + EmpId);
            Console.WriteLine("Emp Name :" + Name);
            Console.WriteLine("Salary Per Hour :" + SalPerHour);
        }

        public abstract void CalculateSalary(int NoOfWorkingHours);
        public abstract void CalculateLeaves();
    }
}
