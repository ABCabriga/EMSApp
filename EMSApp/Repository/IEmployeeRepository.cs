using EMSApp.Models;

namespace EMSApp.Repository
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int Id);
        Employee AddEmployee(Employee newEmployee);
        Employee UpdateEmployee(int EmployeeId, Employee newEmployee);
        Employee DeleteEmployee(int EmployeeId);
    }
}