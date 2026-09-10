using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Department
    {
        public string Name { get; set; }
        public int WorkerLimit 
        { 
            get;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Isci sayi minimum 1 ola biler");
                }
                field = value;
            }
        }
        public int SalaryLimit
        {
            get;
            set
            {
                if (value < 250)
                {
                    throw new ArgumentException("Minimum mebleg 250 olamalidir");
                }
                field = value;
            }
        }
        public Employee[] Employees = new Employee[0];

        public Department(string name, int workerLimit, int salaryLimit)
        {
            Name = name;
            WorkerLimit = workerLimit;
            SalaryLimit = salaryLimit;
        }

        public double CalcSalaryAverage()
        {
            double sum = 0;
            for (int i = 0; i < Employees.Length; i++)
            {
                sum += Employees[i].Salary;
            }
            return sum / Employees.Length;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Department Name: {Name}");
            Console.WriteLine($"Worker Limit: {WorkerLimit}");
            Console.WriteLine($"Salary Limit: {SalaryLimit}");
            for (int i = 0; i < Employees.Length; i++)
            {
                Console.WriteLine($"Employe {i+1}: ");
                Employees[i].GetInfo();
            }
        }
    }
}
