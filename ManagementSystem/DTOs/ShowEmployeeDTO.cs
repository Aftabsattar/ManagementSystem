namespace ManagementSystem.DTOs;

public class ShowEmployeeDTO
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public int DepartmentId { get; set; }
    public DateTime joiningDate { get; set; }
}