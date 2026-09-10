namespace ConsoleApp1
{
    internal class Employee
    {
        public Employee(string fullName, string position, int salary, string departmentName)
        {
            FullName = fullName;
            Position = position;
            Salary = salary;
            DepartmentName = departmentName;
            n++;
            No = DepartmentName.Substring(0, 2) + n.ToString();
        }
        static int n = 1000;
        public string No { get; }
        public string FullName { get; set; }
        public string Position 
        { 
            get; 
            set
            {
                if (value == null || value.Length < 2)
                    throw new ArgumentNullException("Iscinin vezifezi 2 herfden qisa ola bilmez.");
                field = value;
            }
        }
        public int Salary 
        { 
            get; 
            set
            {
                if (value < 250 )
                {
                    throw new ArgumentException("Iscinin maasi 250-den asagi ola bilmez.");
                }
                field = value;
            }
        }
        public string DepartmentName { get; set; }
        public void GetInfo()
        {
            Console.WriteLine($"No : {No}");
            Console.WriteLine($"Full Name : {FullName}");
            Console.WriteLine($"Position : {Position}");
            Console.WriteLine($"Salary : {Salary}");
        }
    }
}
