// Program.cs
class Program
{
    static void Main()
    {
        Employee employee1 = new Employee { EmployeeId = 1, Name = "John Doe", Salary = 50000.0m, DepartmentId = 101 };
        Employee employee2 = new Employee { EmployeeId = 2, Name = "Jane Smith", Salary = 60000.0m, DepartmentId = 102 };

        Department department1 = new Department { DepartmentId = 101, Name = "Engineering" };
        Department department2 = new Department { DepartmentId = 102, Name = "Marketing" };

        department1.AddEmployee(employee1);
        department2.AddEmployee(employee2);

        EmployeeManagement employeeManagement = new EmployeeManagement();
        employeeManagement.AddDepartment(department1);
        employeeManagement.AddDepartment(department2);

        Console.WriteLine("Employee Management System Information:");
        employeeManagement.DisplayDepartments();
    }
}
