namespace Demo.Ipt.Test;
public class ProposalSeedDataFixture
{
    public IptDbContext IptDbContext { get; private set; } 

    public ProposalSeedDataFixture()
    {
        var options = new DbContextOptionsBuilder<IptDbContext>()
            .UseInMemoryDatabase(databaseName: "IptDemo")
            .Options;

        IptDbContext = new IptDbContext(options);
        IptDbContext.Proposals.AddRange(DataFactory.DefaultDatabaseProposals());
        IptDbContext.SaveChanges();
    }

    public void Dispose()
    {
        IptDbContext.Dispose();
    }
}
