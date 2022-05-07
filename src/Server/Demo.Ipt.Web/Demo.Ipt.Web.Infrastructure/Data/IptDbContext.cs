namespace Demo.Ipt.Web.Infrastructure.Data;
public class IptDbContext : DbContext
{
    public IptDbContext(DbContextOptions<IptDbContext> options) : base(options)
    {
    }

    public DbSet<Proposal> Proposals { get; set; }
    public DbSet<Facility> Facilities { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<ProposalStatus> ProposalStatuses { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
