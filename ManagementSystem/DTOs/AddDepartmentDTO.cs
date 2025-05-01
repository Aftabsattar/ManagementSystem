using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.DTOs;

public class AddDepartmentDTO
{
    [Required]
    public string Name { get; set; } = string.Empty;

    public string? Location { get; set; } = string.Empty;
}