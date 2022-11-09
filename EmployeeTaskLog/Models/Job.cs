using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeTaskLog.Models;

public class Job
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public int? EmployeeId { get; set; }
    public Employee? Employee { get; set; }
}