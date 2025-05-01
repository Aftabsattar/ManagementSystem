using AutoMapper;
using ManagementSystem.DTOs;
using ManagementSystem.Entities;

namespace ManagementSystem.Mapper;

public class AutoMappingFile: Profile
{
    public AutoMappingFile()
    {
        CreateMap<AddDepartmentDTO, Department>();
        CreateMap<Department, ShowDepartmentDTO>();
        CreateMap<AddEmployeeDTO, Employee>();
        CreateMap<Employee, ShowEmployeeDTO>();
    }
}