using Abstract_Method.Model;
using Abstract_Method.Model.abstract_class;
using System;

namespace Abstract_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //A   a = new B();
            //    a.Show();
            //    a.Display();
  
            Employee E;
            Console.WriteLine("1.SE 2.TL 3.HR");
            int type = int.Parse(Console.ReadLine());

            switch (type)
            {
                case 1:
                    E = new SoftwareEng() { EmpId = 100, Name = "Peter", SalPerHour = 45, Technology = ".Net Core" };
                    break;
                case 2:
                    E = new TeamLead() { EmpId = 200, Name = "Jack", SalPerHour = 46, Size = 12 };
                    break;
                default:
                    E = new SoftwareEng() { EmpId = 100, Name = "Peter", SalPerHour = 45, Technology = ".Net Core" };
                    break;
            }

            E.Details();
            E.CalculateSalary(36);
            E.CalculateLeaves();
            Console.ReadLine();



        }
    }
}
