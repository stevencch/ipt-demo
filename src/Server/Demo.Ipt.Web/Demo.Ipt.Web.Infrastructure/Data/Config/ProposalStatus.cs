namespace Demo.Ipt.Web.Infrastructure.Data.Config;
public class ProposalStatusConfiguration : IEntityTypeConfiguration<ProposalStatus>
{
    public void Configure(EntityTypeBuilder<ProposalStatus> builder)
    {
        builder.Property(b => b.Status)
            .IsRequired()
            .HasMaxLength(50);
    }
}
