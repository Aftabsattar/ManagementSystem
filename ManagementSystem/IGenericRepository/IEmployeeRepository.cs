using ManagementSystem.DTOs;

namespace ManagementSystem.IGenericRepository;

public interface IEmployeeRepository
{
    public Task<List<ShowEmployeeDTO>> GetAllEmployees();
    public Task<bool> AddEmployee(AddEmployeeDTO employee);
    public Task<bool> UpdateEmployee(int id, AddEmployeeDTO employee);
    public Task<bool> DeleteEmployee(int id);
    public Task<ShowEmployeeDTO> GetByIdEmployee(int id);
    public Task<List<ShowEmployeeDTO>> GetEmployeeListByDepartmentId(int departmentId);

}