// Employee.cs
using System;

public class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public int DepartmentId { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Employee ID: {EmployeeId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Salary: {Salary:C}");
        Console.WriteLine($"Department ID: {DepartmentId}");
    }
}
