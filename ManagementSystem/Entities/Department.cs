using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.Entities;

public class Department
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public string? Location { get; set; } = string.Empty;
}