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

           while (true)
            {
                Console.WriteLine("Welcome User! Choose from Menu");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("1. Show All Departments");
                Console.WriteLine("2. Add New Department");
                Console.WriteLine("3. Update/Delete Existing Department");
                Console.WriteLine("4. Show All Employees");
                Console.WriteLine("5. Show Employee by Id");
                Console.WriteLine("6. Add Employee");
                Console.WriteLine("7. Update/Delete Employee");
                Console.WriteLine("8. Show Departments by Id with Employees");
           
            }

            //DepartmentRepository departmentRepo = new DepartmentRepository();

            //Console.WriteLine("Getting All Departments:");
            //Console.WriteLine();

            //List<Department> allDepartments = departmentRepo.GetAllDepartments();

            //foreach (Department dept in allDepartments)
            //{
            //    Console.WriteLine($"{dept.Id} {dept.DeptName}");
            //}

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Getting Department with Id 1");

            //Department singleDepartment = departmentRepo.GetDepartmentById(1);

            //Console.WriteLine($"{singleDepartment.Id} {singleDepartment.DeptName}");

            //Department legalDept = new Department
            //{
            //    DeptName = "Legal"
            //};

            //departmentRepo.AddDepartment(legalDept);

            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Added the new Legal Department!");


            //EmployeeRepository employeeRepo = new EmployeeRepository();
      

            //Console.WriteLine("Getting All Employees:");
            //Console.WriteLine();

            //List<Employee> allEmployees = employeeRepo.GetAllEmployees();

            //foreach (Employee emp in allEmployees)
            //{
            //    Console.WriteLine($"{emp.Id} {emp.FirstName}");
            //}



        }
    }
}