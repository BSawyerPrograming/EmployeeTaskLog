using EmployeeTaskLog.Data;
using EmployeeTaskLog.Models;

namespace EmployeeTaskLog.Services;

public class AdminService
{
    public void CreateJob(string name)
    {
        EmployeeTaskLogContext _ = new EmployeeTaskLogContext();
        Job job = new Job()
        {
            Name = name
        };
        _.Add(job);
        _.SaveChanges();
    }
}
