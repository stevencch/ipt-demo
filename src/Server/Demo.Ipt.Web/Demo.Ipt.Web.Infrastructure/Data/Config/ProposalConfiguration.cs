namespace Demo.Ipt.Web.Infrastructure.Data.Config;
public class ProposalConfiguration : IEntityTypeConfiguration<Proposal>
{
    public void Configure(EntityTypeBuilder<Proposal> builder)
    {
        builder.Property(b => b.ProposalName)
            .IsRequired()
            .HasMaxLength(200);
        builder.Property(b => b.CustomerGrpName)
            .IsRequired()
            .HasMaxLength(200);
        builder.Property(b => b.Date)
            .IsRequired();
        builder.Property(b => b.Description)
            .IsRequired()
            .HasMaxLength(2000);
        builder.Property(b => b.DateCreated)
            .IsRequired();
        builder.Property(b => b.DateModified)
            .IsRequired();
    }
}
