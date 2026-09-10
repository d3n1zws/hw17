namespace ConsoleApp1
{
    internal interface IHumanResourceManager
    {
        void AddDepartment(Department department);
        void AddEmployee(Employee employee);
        void EditDepartments(string name1, string name2);
        void EditEmployee(string no, int salary, string position);
        void GetDepartment();
        void RemoveEmployee(Employee employee, string departmentName);
        void Search(string s);
    }
}