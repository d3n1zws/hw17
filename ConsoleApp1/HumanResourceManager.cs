using System.ComponentModel;

namespace ConsoleApp1
{
    internal class HumanResourceManager : IHumanResourceManager
    {
        Department[] departments = new Department[0];
        public void AddDepartment(Department department)
        {
            Array.Resize(ref departments, departments.Length + 1);
            departments[departments.Length - 1] = department;
        }
        public void GetDepartment()
        {
            if (departments.Length == 0)
            {
                Console.WriteLine("department yoxdur.");
                Console.WriteLine();
                return;
            }
            for (int i = 0; i < departments.Length; i++)
            {
                Console.WriteLine($"Department {i + 1}: ");
                departments[i].GetInfo();
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void EditDepartments(string name1, string name2)
        {
            for (int i = 0; i < departments.Length; i++)
            {
                if (departments[i].Name == name1)
                {
                    departments[i].Name = name2;
                    for (int j = 0; j < departments[i].Employees.Length; j++)
                    {
                        departments[i].Employees[j].DepartmentName = name2;
                    }
                }
            }
        }
        public void AddEmployee(Employee employee)
        {
            for (int i = 0; i < departments.Length; i++)
            {
                if (employee.DepartmentName == departments[i].Name)
                {
                    Array.Resize(ref departments[i].Employees, departments[i].Employees.Length + 1);
                    departments[i].Employees[departments[i].Employees.Length - 1] = employee;
                }
            }
        }
        public void RemoveEmployee(Employee employee, string departmentName)
        {
            for (int i = 0; i < departments.Length; i++)
            {
                if (departments[i].Name == departmentName)
                {
                    bool check = false;
                    for (int j = 0; j < departments[i].Employees.Length; j++)
                    {
                        if (departments[i].Employees[j] == employee)
                        {
                            check = true;
                            continue;
                        }
                        if (check)
                        {
                            departments[i].Employees[j - 1] = departments[i].Employees[j];
                        }
                    }
                    Array.Resize(ref departments[i].Employees, departments[i].Employees.Length - 1);
                    break;
                }
            }
        }
        public void EditEmployee(string no, int salary, string position)
        {
            for (int i = 0; i < departments.Length; i++)
            {
                for (int j = 0; j < departments[i].Employees.Length; j++)
                {
                    if (departments[i].Employees[j].No == no)
                    {
                        departments[i].Employees[j].Salary = salary;
                        departments[i].Employees[j].Position = position;
                        break;
                    }
                }
            }
        }
        public void Search(string s)
        {
            for (int i = 0; i < departments.Length; i++)
            {
                for (int j = 0; j < departments[i].Employees.Length; j++)
                {
                    if (departments[i].Employees[j].DepartmentName.Contains(s))
                    {
                        departments[i].Employees[j].GetInfo();
                    }
                    else if (departments[i].Employees[j].FullName.Contains(s))
                    {
                        departments[i].Employees[j].GetInfo();
                    }
                    else if (departments[i].Employees[j].Position.Contains(s))
                    {
                        departments[i].Employees[j].GetInfo();
                    }
                }
            }
        }
    }
}
