using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeTaskLog.Models;

public class Tool    
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public bool InUse { get; set; }
    public Employee? Employee { get; set; }

}