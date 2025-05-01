using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagementSystem.Entities;

public class Employee
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string Email { get; set; } = string.Empty;

    public string? Phone { get; set; } = string.Empty;

    [ForeignKey("Department")]
    public  int  DepartmentId { get; set; }

    [Required]
    public DateTime joiningDate { get; set; }
}