

namespace awasur.Models;
public class InsuranceType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; } 
    
    // Navigation property
   // public ICollection<Policy> Policies { get; set; }
}
