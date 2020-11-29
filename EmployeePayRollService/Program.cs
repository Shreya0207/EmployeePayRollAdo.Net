using System;

namespace EmployeePayRollService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee pay roll.");
            EmployeeRepo repo = new EmployeeRepo();
            repo.GetAllEmployee();
            //EmployeeModel employee = new EmployeeModel();
            //employee.EmployeeName = "Shreya";
            //employee.Department = "SE";
            //employee.PhoneNumber = "9876543210";
            //employee.Address = "Bhilai";
            //employee.Gender = 'F';
            //employee.BasicPay = 40000.00M;
            //employee.Deductions = 1100.00;
            //employee.StartDate = employee.StartDate = Convert.ToDateTime("2020-11-05");

            //if (repo.AddEmployee(employee))
            //    Console.WriteLine("Records added successfully");
        }
    }
}
