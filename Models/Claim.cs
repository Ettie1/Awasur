
namespace awasur.Models;

public class Claim
{
    public int Id { get; set; }
    public int PolicyId { get; set; }
    public DateTime ClaimDate { get; set; }
    public decimal ClaimAmount { get; set; }
    public string Status { get; set; } // e.g., Pending, Approved, Rejected
    public string Description { get; set; }

    // Navigation property
    //public Policy Policy { get; set; }
}
