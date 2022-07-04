using System;

namespace Salary_Slip
{
    class employees
    {
        protected double baseSalary = 1500;
        protected double fuelAll;
        protected double medicalAll;
        public double Total()
        {
            double total = baseSalary + fuelAll + medicalAll;
            return total;
        }
    }

    class allEmployees : employees
    {
        public allEmployees(double FuelAll, double MedicalAll)
        {
            fuelAll = FuelAll;
            medicalAll = MedicalAll;
        }
    }

    class salarySlip
    {
        public void calculateSalary()
        {
            Console.Write("Enter youe designation: ");
            string designation = Console.ReadLine().ToLower();

            if (designation == "engineer")
            {
                employees eng = new allEmployees(100, 500);
                Console.WriteLine("Your gross salary is ${0}" ,eng.Total());
            }
            else if (designation == "manager")
            {
                employees mng = new allEmployees(250, 1000);
                Console.WriteLine("Your gross salary is ${0}", mng.Total());
            }

            else if (designation == "analyst")
            {
                employees ana = new allEmployees(150, 800);
                Console.WriteLine("Your gross salary is ${0}", ana.Total());
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            salarySlip slip = new salarySlip();
            slip.calculateSalary();
        }
    }
}
