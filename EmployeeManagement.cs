// EmployeeManagement.cs
using System;
using System.Collections.Generic;

public class EmployeeManagement
{
    public List<Department> Departments { get; }

    public EmployeeManagement()
    {
        Departments = new List<Department>();
    }

    public void AddDepartment(Department department)
    {
        Departments.Add(department);
    }

    public void DisplayDepartments()
    {
        Console.WriteLine("Departments in the Employee Management System:");
        foreach (var department in Departments)
        {
            department.DisplayInfo();
            Console.WriteLine();
        }
    }
}
