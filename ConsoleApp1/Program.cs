using ConsoleApp1;
using System.ComponentModel.Design;

Console.WriteLine("yeni employee yaradilir : ");
Console.WriteLine();
Employee employee1 = new Employee("Ali Veli", "developer", 1800, "IT");
Employee employee2 = new Employee("Aysel Hasan", "designer", 1500, "design");
Employee employee3 = new Employee("Leyla Aliyeva", "developer", 2000, "IT");
Console.WriteLine("employee1: ");
employee1.GetInfo();
Console.WriteLine();

Console.WriteLine("employee2: ");
employee2.GetInfo();
Console.WriteLine();

Console.WriteLine("employee3: ");
employee3.GetInfo();
Console.WriteLine();



Department department1 = new Department("IT", 45, 3000);
Department department2 = new Department("Design", 50, 2000);

HumanResourceManager humanResourceManager = new HumanResourceManager();
humanResourceManager.GetDepartment();

Console.WriteLine("Add Departments : ");
Console.WriteLine();
humanResourceManager.AddDepartment(department1);
humanResourceManager.AddDepartment(department2);
humanResourceManager.GetDepartment();

Console.WriteLine("Edit Departments(Design -> design) : ");
Console.WriteLine();
humanResourceManager.EditDepartments("Design", "design");
humanResourceManager.GetDepartment();

Console.WriteLine("Add Employee(employee 1,2,3) : ");
Console.WriteLine();
humanResourceManager.AddEmployee(employee1);
humanResourceManager.AddEmployee(employee2);
humanResourceManager.AddEmployee(employee3);
humanResourceManager.GetDepartment();

Console.WriteLine("Remove Employee : ");
Console.WriteLine();
humanResourceManager.RemoveEmployee(employee1, employee1.DepartmentName);
humanResourceManager.GetDepartment();

Console.WriteLine("Edit Employee : ");
Console.WriteLine();
humanResourceManager.EditEmployee(employee2.No, 1500, "Manager");
humanResourceManager.GetDepartment();

humanResourceManager.Search("IT");



