using EmployeeManagementModels;

namespace EmployeeManagement.APi.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _context;
        public DepartmentRepository(AppDbContext context)
        {

            _context = context;

        }
        Department IDepartmentRepository.GetDepartment(int departmentId)
        {
            return _context.Departments.FirstOrDefault(d => d.DepartmentId == departmentId);
        }

        IEnumerable<Department> IDepartmentRepository.GetDepartments()
        {
            return _context.Departments;

        }
    }
}
