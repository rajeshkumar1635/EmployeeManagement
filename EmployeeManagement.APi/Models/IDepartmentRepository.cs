using EmployeeManagementModels;

namespace EmployeeManagement.APi.Models
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartment(int departmentId);
    }
}
