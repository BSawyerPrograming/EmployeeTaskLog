using EmployeeTaskLog.Models;
using EmployeeTaskLog.Configuration;

using Microsoft.EntityFrameworkCore;

namespace EmployeeTaskLog.Data;

public class EmployeeTaskLogContext : DbContext
{
    public DbSet<Employee> Employees { get; set; } = null!;
    public DbSet<Job> Jobs { get; set; } = null!;
    public DbSet<Tool> Tools { get; set; } = null!;

    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(Config.ConnectionString());
    }
}

