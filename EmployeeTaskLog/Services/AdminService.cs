using EmployeeTaskLog.Data;
using EmployeeTaskLog.Models;

namespace EmployeeTaskLog.Services;

public class AdminService
{
    public void CreateJob(string name)
    {
        var ctx = new EmployeeTaskLogContext();
        var job = new Job()
        {
            Name = name
        };
        ctx.Add(job);
        ctx.SaveChanges();
    }

    public void CreateJob(string name, string description)
    {
        var ctx = new EmployeeTaskLogContext();
        var job = new Job()
        {
            Name = name,
            Description = description
        };
        ctx.Add(job);
        ctx.SaveChanges();
    }
}

