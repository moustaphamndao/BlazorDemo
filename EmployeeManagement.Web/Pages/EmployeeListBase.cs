using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
            
        }

        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Jean",
                LastName = "Thomas",
                Email = "Jean@ndawene.com",
                DateOfBrith = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DepartmentId =  1, 
                PhotoPath = "images/jean.png"
            };

            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Nicolas",
                LastName = "Tremblay",
                Email = "Nicolas@ndawene.com",
                DateOfBrith = new DateTime(1981, 12, 22),
                Gender = Gender.Male,
                DepartmentId =  2, 
                PhotoPath = "images/nicolas.jpg"
            };

            Employee e3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Sophie",
                LastName = "Daniel",
                Email = "sophie@ndawene.com",
                DateOfBrith = new DateTime(1979, 11, 11),
                Gender = Gender.Female,
                DepartmentId = 1,
                PhotoPath = "images/sophie.jpeg"
            };

            Employee e4 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Sara",
                LastName = "Portu",
                Email = "sara@ndawene.com",
                DateOfBrith = new DateTime(1982, 9, 23),
                Gender = Gender.Female,
                DepartmentId = 3,
                PhotoPath = "images/sophie.jpeg"
            };

            Employees = new List<Employee> { e1, e2, e3, e4 };
        }
    }
}
