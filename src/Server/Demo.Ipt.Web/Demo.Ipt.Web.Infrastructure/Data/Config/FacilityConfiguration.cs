namespace Demo.Ipt.Web.Infrastructure.Data.Config;
public class FacilityConfiguration : IEntityTypeConfiguration<Facility>
{
    public void Configure(EntityTypeBuilder<Facility> builder)
    {
        builder.Property(b => b.FacilityName)
            .IsRequired()
            .HasMaxLength(200);
        builder.Property(b => b.StartDate)
            .IsRequired();
        builder.Property(b => b.MaturityDate)
            .IsRequired();
        builder.Property(b => b.Limit)
            .IsRequired();
        builder.Property(b => b.DateCreated)
            .IsRequired();
        builder.Property(b => b.DateModified)
            .IsRequired();
        builder.Property(b => b.DateCreated)
            .IsRequired();
        builder.Property(b => b.DateModified)
            .IsRequired();
    }
}
