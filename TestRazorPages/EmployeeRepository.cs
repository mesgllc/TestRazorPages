using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace TestRazorPages
{
    public class Employee
    {
        //[DisplayName("First Name:")]
        //[Required(ErrorMessage = "Please enter the employee's first name")]
        public string FirstName { get; set; }

        //[DisplayName("Last Name:")]
        //[Required(ErrorMessage = "Please enter the employee's last name")]
        public string LastName { get; set; }

        //[DisplayName("Date of Birth:")]
        //[DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        //[DisplayName("ID:")]
        //[Required(ErrorMessage = "Please enter the employee's ID")]
        public int ID { get; set; }

        public string Gender { get; set; }
    }

    public interface IEmployeeRepository
    {
        Employee GetByID(int id);
        List<Employee> GetAll();
        //Employee Add();
    }

    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(GetByID(1));
            employees.Add(GetByID(2));
            employees.Add(GetByID(3));
            return employees;
        }

        public Employee GetByID(int id)
        {
            if (id == 1)
            {
                return new Employee()
                {
                    FirstName = "Spencer",
                    LastName = "Strasmore",
                    DateOfBirth = new DateTime(1978, 11, 16),
                    Gender = "Male",
                    ID = 1
                };
            }
            if (id == 2)
            {
                return new Employee()
                {
                    FirstName = "Liz",
                    LastName = "Jerret",
                    DateOfBirth = new DateTime(1989, 3, 30),
                    Gender = "Female",
                    ID = 2
                };
            }
            if (id == 3)
            {
                return new Employee()
                {
                    FirstName = "Vernon",
                    LastName = "Littlefield",
                    DateOfBirth = new DateTime(1992, 7, 3),
                    Gender = "Male",
                    ID = 3
                };
            }

            return null;
        }
        /*
                public Employee Add(string fname, string lname, int dob, int id)
                {
                    return new Employee()
                    {
                        FirstName = fname,
                        LastName = lname,
                        DateOfBirth = new DateTime(dob),
                        ID = id
                    };

                }*/
    }
}
