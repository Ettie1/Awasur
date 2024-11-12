namespace awasur.Models;

public class Address
{
    public int AddressId {get; set;}
    public string Addr1 {get; set;}
    public string Addr2 {get; set;}

    public string Addr3 {get; set;}
    public string Addr4 {get; set;}
    public virtual int CustomerId {get; set;}
}