using EmployeeTaskLog.Data;
using EmployeeTaskLog.Models;

namespace EmployeeTaskLog.Services;

public class AdminService
{
    public void CreateJob(string name)
    {
        EmployeeTaskLogContext ctx = new EmployeeTaskLogContext();
        Job job = new Job()
        {
            Name = name
        };
        ctx.Add(job);
        ctx.SaveChanges();
    }

    public void CreateJob(string name, string description)
    {
        EmployeeTaskLogContext ctx = new EmployeeTaskLogContext();
        Job job = new Job()
        {
            Name = name,
            Description = description
        };
        ctx.Add(job);
        ctx.SaveChanges();
    }
}
}
