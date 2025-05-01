using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.DTOs;

public class AddEmployeeDTO
{
    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string Email { get; set; } = string.Empty;

    public string? Phone { get; set; } = string.Empty;

    [ForeignKey("Department")]
    public int DepartmentId { get; set; }

    [Required]
    public DateTime joiningDate { get; set; }
}
