// Department.cs
using System;
using System.Collections.Generic;

public class Department
{
    public int DepartmentId { get; set; }
    public string Name { get; set; }
    public List<Employee> Employees { get; }

    public Department()
    {
        Employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Department ID: {DepartmentId}");
        Console.WriteLine($"Department Name: {Name}");
        Console.WriteLine("Employees in the Department:");
        foreach (var employee in Employees)
        {
            employee.DisplayInfo();
            Console.WriteLine();
        }
    }
}
