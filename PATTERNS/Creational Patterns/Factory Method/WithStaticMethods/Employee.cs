using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WithStaticMethods
{
    public class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Department { get; set; }
        public int Year { get; set; }
        public decimal Salary { get; set; }
        
        public static readonly decimal BASE_SALARY = 5000;

        private Employee(int id, string firstName, string lastName, int year,string department)
        {
            Id = id;
            Firstname = firstName;
            Lastname = lastName;
            Year = year;
            Department = department;
        }

        public static Employee CreateNewEmployee(int id, string firstName, string lastName, string department)
        {
            return new Employee(id, firstName, lastName,0,department);
        }

        public static Employee CreateNewEmployeeWithDepartment(int id, string firstName, string lastName, string department)
        {
            return new Employee(id, firstName, lastName, 0,department);
        }

        public virtual void Work(string firstname, string lastname, string department)
        {
            Firstname = firstname;
            Lastname = lastname;
            Department = department;
            Console.WriteLine($"{Firstname} {Lastname} works at the {Department} department.");
        }

        public virtual decimal TotalSalaryCalculate(decimal salary)
        {
            Salary = salary;
            Console.WriteLine(BASE_SALARY+Salary);
            return BASE_SALARY + Salary;
        }








    }
}