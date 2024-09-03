using Microsoft.Extensions.Logging;

namespace Adapter;

// This is the class that makes two incompatible interfaces or systems work together.
// The Adapter makes the Adaptee's interface compatible with the Target's interface.
public class EmployeeAdapter : ITarget
{
    ILogger<EmployeeAdapter> _logger;
    //To use Object Adapter Design Pattern, we need to create an object of ThirdPartyBillingSystem
    ThirdPartyBillingSystem thirdPartyBillingSystem = new ThirdPartyBillingSystem();
    public EmployeeAdapter(ILogger<EmployeeAdapter> logger)
    {
        _logger = logger;
    }

    /// <inheritdoc/>>
    public List<Employee> ProcessCompanySalary(string[,] employeesArray)
    {
        string Id = null;
        string Name = null;
        string Designation = null;
        string Salary = null;

        List<Employee> listEmployee = new List<Employee>();

        for (int i = 0; i < employeesArray.GetLength(0); i++)
        {
            for (int j = 0; j < employeesArray.GetLength(1); j++)
            {
                if (j == 0)
                {
                    Id = employeesArray[i, j];
                }
                else if (j == 1)
                {
                    Name = employeesArray[i, j];
                }
                else if (j == 2)
                {
                    Designation = employeesArray[i, j];
                }
                else
                {
                    Salary = employeesArray[i, j];
                }
            }

            listEmployee.Add(new Employee(Convert.ToInt32(Id), Name, Designation, Convert.ToDecimal(Salary)));
        }

        _logger.LogInformation("Adapter converted Array of Employee to List of Employee");
        _logger.LogInformation("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");
        var processedSalary =  thirdPartyBillingSystem.ProcessSalary(listEmployee);

        return processedSalary;
    }
}