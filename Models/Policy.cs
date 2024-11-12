

namespace awasur.Models;
public class Policy
{
    public int Id { get; set; }
    public string PolicyNumber { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal PremiumAmount { get; set; }
    public string CoverageDetails { get; set; }
    public int CustomerId { get; set; }
    
    // Navigation property
    //public Customer Customer { get; set; }
}
