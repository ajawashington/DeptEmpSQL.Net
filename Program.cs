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
                Console.WriteLine("3. Change Existing Department");
                Console.WriteLine("4. Show All Employees");
                Console.WriteLine("5. Show Employee by Id");
                Console.WriteLine("6. Add Employee");
                Console.WriteLine("7. Change Existing Employee");
                Console.WriteLine("8. Show Departments by Id with Employees");

                var choice = Console.ReadLine();
                DepartmentRepository departmentRepo = new DepartmentRepository();
                EmployeeRepository employeeRepo = new EmployeeRepository();

                switch (Int32.Parse(choice))
                {
                    case 1:

                        Console.WriteLine("Getting All Departments:");
                        Console.WriteLine();

                        List<Department> allDepartments = departmentRepo.GetAllDepartments();

                        foreach (Department dept in allDepartments)
                        {
                            Console.WriteLine($"{dept.Id} {dept.DeptName}");
                        }
                        break;
                    case 2:

                        Console.WriteLine("New Department Name");
                        var departmentName = Console.ReadLine();
                        Department newDepartment = new Department
                        {
                            DeptName = departmentName
                        };

                        departmentRepo.AddDepartment(newDepartment);
                        Console.WriteLine($"Added the new {departmentName} Department!");
                        break;

                    //case 3:
                    //    Console.WriteLine("Update or Delete Department");
                    //    var DeptChangeChoice = int.Parse(Console.ReadLine());

                    //    Console.WriteLine("1. Update");
                    //    Console.WriteLine("2. Delete");

                    //    string option = Console.ReadLine();

                    //    if (option == "1")
                    //    {
                    //        Console.WriteLine("Choose a Department By Id");

                    //        List<Department> allDepts = departmentRepo.GetAllDepartments();

                    //        foreach (Department dept in allDepts)
                    //        {
                    //            Console.WriteLine($"{dept.Id} {dept.DeptName}");
                    //        }

                    //        Department singleDepartment = departmentRepo.GetDepartmentById(DeptChangeChoice);
                    //        Console.WriteLine($"{singleDepartment.Id} {singleDepartment.DeptName}");
                    //        break;


                    //    }
                    //    else if (option == "2")
                    //    {
                            //Console.WriteLine("Choose a Department By Id");

                            //List<Department> allDepts = departmentRepo.GetAllDepartments();

                            //foreach (Department dept in allDepts)
                            //{
                            //    Console.WriteLine($"{dept.Id} {dept.DeptName}");
                            //}

                            //Department singleDepartment = departmentRepo.DeleteDepartment(DeptChangeChoice);
                            //Console.WriteLine($"We have Deleted {singleDepartment.Id} {singleDepartment.DeptName}");
                        //}






                }
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