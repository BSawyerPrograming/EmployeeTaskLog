namespace EmployeeTaskLog.Models;

public class Employee
{

    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string? MiddleName { get; set; }
    public string LastName { get; set; } = null!;
    public ICollection<Job> Jobs { get; set; } = null!;
    public ICollection<Tool> Tools { get; set; } = null!;
}
