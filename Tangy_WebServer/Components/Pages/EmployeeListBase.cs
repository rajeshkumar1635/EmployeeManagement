using EmployeeManagementModels;
using Microsoft.AspNetCore.Components;
using Tangy_WebServer.Services;

namespace Tangy_WebServer.Components.Pages
{
    public class EmployeeListBase : ComponentBase

    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
          Employees=(await EmployeeService.GetEmployees()).ToList();
        }

        

    }
}
