namespace awasur.Models;

public class CustomerViewModel
{
    public Customer Customer {get; set;}
    public Contact Contact {get; set;}
    public Address Address {get; set;}
    public InsuranceType InsuranceType {get; set;}

    public IEnumerable<InsuranceType> InsuranceTypes {get; set;}
    public Policy Policy {get; set;}
}