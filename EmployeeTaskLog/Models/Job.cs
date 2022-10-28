using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeTaskLog.Models;

public class Job
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int EmployeeId { get; set; }

    public int ApplicationId { get; set; }

    public Employee Employee { get; set; } = null!;

    public ICollection<Application> Applications { get; set; } = null!;


}