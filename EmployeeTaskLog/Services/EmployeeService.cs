using EmployeeTaskLog.Models;
using EmployeeTaskLog.Data;



namespace EmployeeTaskLog.Services;

public class EmployeeService
{
     

    //Adds a Employee to the database
    public void AddEmployee(string firstName, string middleName, string lastName)
    {
        EmployeeTaskLogContext ctx = new EmployeeTaskLogContext();
        Employee employee = new Employee()
        {
            FirstName = firstName,
            MiddleName = middleName,
            LastName = lastName
        };
        ctx.Add(employee);
        ctx.SaveChanges();
        
    }
}