namespace Demo.Ipt.Web.Infrastructure.Data;
public class EfRepository<T> : RepositoryBase<T>, IRepository<T> where T : class, IAggregateRoot
{
    public EfRepository(IptDbContext dbContext) : base(dbContext)
    {
    }
}
