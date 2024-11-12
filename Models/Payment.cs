

namespace awasur.Models;
public class Payment
{
    public int Id { get; set; }
    public int PolicyId { get; set; }
    public DateTime PaymentDate { get; set; }
    public decimal Amount { get; set; }
    public string PaymentMethod { get; set; } // e.g., Credit Card, Bank Transfer, Cash

    // Navigation property
    //public Policy Policy { get; set; }
}
