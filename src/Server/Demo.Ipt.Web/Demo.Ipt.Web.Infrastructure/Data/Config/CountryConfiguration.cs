namespace Demo.Ipt.Web.Infrastructure.Data.Config;
public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.Property(b => b.Name)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(b => b.Currency)
            .IsRequired()
            .HasMaxLength(20);
        builder.Property(b => b.DateCreated)
            .IsRequired();
        builder.Property(b => b.DateModified)
            .IsRequired();
    }
}
