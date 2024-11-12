using Microsoft.EntityFrameworkCore;

namespace awasur.Models;

public class AwasurContext : DbContext
{
    public AwasurContext(DbContextOptions<AwasurContext> options) : base(options) { }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Policy> Policies { get; set; }
    public DbSet<Claim> Claims { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<InsuranceType> InsuranceTypes { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Address> Addresses { get; set; }
}
