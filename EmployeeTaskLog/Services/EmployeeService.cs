using EmployeeTaskLog.Models;
using EmployeeTaskLog.Data;



namespace EmployeeTaskLog.Services;

public class EmployeeService
{
    public EmployeeTaskLogContext context = new EmployeeTaskLogContext();

    //Adds a Employee to the database
    public void AddEmployee(string firstName, string middleName, string lastName)
    {

        Employee employee = new Employee()
        {
            FirstName = firstName,
            MiddleName = middleName,
            LastName = lastName
        };
        context.Add(employee);
        context.SaveChanges();
        
    }
}