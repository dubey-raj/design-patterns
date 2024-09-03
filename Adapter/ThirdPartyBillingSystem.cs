namespace Adapter;

// The Adaptee contains some functionality that is required by the client.
// But this interface is not compatible with the client code.
public class ThirdPartyBillingSystem
{
    //ThirdPartyBillingSystem accepts employee's information as a List to process each employee's salary
    public List<Employee> ProcessSalary(List<Employee> listEmployee)
    {
        return listEmployee;
    }
}