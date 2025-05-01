using ManagementSystem.DTOs;

namespace ManagementSystem.IGenericRepository;

public interface IDepartmentRepository
{
    public Task<List<ShowDepartmentDTO>> GetAllDepartments();
    public Task<bool> AddDepartment(AddDepartmentDTO addDepartmentDTO);
    public Task<bool> UpdateDepartment(int id, AddDepartmentDTO addDepartmentDTO);
    public Task<bool> DeleteDepartment(int id);
    public Task<ShowDepartmentDTO> GetByIdDepartment(int id);
}