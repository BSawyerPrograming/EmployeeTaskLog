using EmployeeTaskLog.Models;
using EmployeeTaskLog.Configuration;

using Microsoft.EntityFrameworkCore;

namespace EmployeeTaskLog.Data;

public class EployeeTaskLogContext : DbContext
{
    public DbSet<Employee> Employees { get; set; } = null!;
    public DbSet<Job> Jobs { get; set; } = null!;
    public DbSet<Application> Applications { get; set; } = null!;


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(Config.ConnectionString());
    }
}

