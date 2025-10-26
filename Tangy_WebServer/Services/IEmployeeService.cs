using EmployeeManagementModels;

namespace Tangy_WebServer.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
    }
}
