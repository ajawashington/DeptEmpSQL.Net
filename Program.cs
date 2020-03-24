using DepartmentsEmployeesConsole.Data;
using DepartmentsEmployeesConsole.Models;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;

namespace DepartmentsEmployeesConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            DepartmentRepository departmentRepo = new DepartmentRepository();

            Console.WriteLine("Getting All Departments:");
            Console.WriteLine();

            List<Department> allDepartments = departmentRepo.GetAllDepartments();

            foreach (Department dept in allDepartments)
            {
                Console.WriteLine($"{dept.Id} {dept.DeptName}");
            }


            EmployeeRepository employeeRepo = new EmployeeRepository();
      

            Console.WriteLine("Getting All Employees:");
            Console.WriteLine();

            List<Employee> allEmployees = employeeRepo.GetAllEmployees();

            foreach (Employee emp in allEmployees)
            {
                Console.WriteLine($"{emp.Id} {emp.FirstName}");
            }



        }
    }
}