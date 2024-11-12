namespace awasur.Models;

public class Contact
{
    public int ContactId {get; set;}
    public string Celno {get;set;}
    public string Email {get; set;}

    public string WorkTel {get; set;}
    public string HomeTel {get; set;}
    public string Other {get; set;}

    public virtual int CustomerId {get;set;}
}