using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EditEmployeeBase : ComponentBase
    {
        [Inject]
        public IEmployeeService employeeService { get; set; }
        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IDepartmentService departmentService { get; set; }
        public List<Department> Departmnents { get; set; } = new List<Department>();

        [Parameter]
        public string Id { get; set; }

        protected async override  Task OnInitializedAsync()
        {
            Employee = await employeeService.GetEmployee(int.Parse(Id));
            Departmnents = (await departmentService.GetDepartments()).ToList();

        }
    }
}
