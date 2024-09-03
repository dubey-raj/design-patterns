namespace Adapter;

// The ITarget defines the domain-specific interface used by the client code.
// This interface needs to be implemented by the Adapter.
// The client can only see this interface i.e. the class which implements the ITarget interface.
public interface ITarget
{
    /// <summary>
    ///The following will accept the employees in the form of string array
    //Then convert the employee string array to List of Employees
    //After conversation, it will call the Adaptee's Method to Process the Salaries
    /// </summary>
    /// <param name="employeesArray"></param>
    List<Employee> ProcessCompanySalary(string[,] employeesArray);
}