using ManagementSystem.DTOs;
using ManagementSystem.IGenericRepository;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        public readonly IDepartmentRepository _departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var departments = await _departmentRepository.GetAllDepartments();
            return Ok(departments);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var department = await _departmentRepository.GetByIdDepartment(id);
            return Ok(department);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDepartment(AddDepartmentDTO addDepartmentDTO)
        {
            var result = await _departmentRepository.AddDepartment(addDepartmentDTO);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            var result = await _departmentRepository.DeleteDepartment(id);
            return Ok(result);       
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDepartment(int id, AddDepartmentDTO addDepartmentDTO)
        {
            var result = await _departmentRepository.UpdateDepartment(id, addDepartmentDTO);
            return Ok(result);
        }
    }
}