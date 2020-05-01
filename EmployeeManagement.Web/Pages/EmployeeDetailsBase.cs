using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeDetailsBase : ComponentBase
    {
        public Employee employee { get; set; } = new Employee();

        [Inject]
        public IEmployeeService employeeService { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Id = Id ?? "1"; // In the case the value of Id is not in the URL, Use the empployee with Id 1.
            employee = await employeeService.GetEmployee(int.Parse(Id));
        }
    }
}
