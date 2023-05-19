using DB.Entities;
using DB.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DB.Configuration;

public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
{
    public void Configure(EntityTypeBuilder<Application> builder)
    {
        builder.ToTable("Application");

        builder.HasKey(e => e.Id);

        builder
            .Property(e => e.ApplicationName)
            .IsRequired()
            .HasMaxLength(255);
        
        builder
            .Property(e => e.Description)
            .HasMaxLength(1024);;

        builder.UseBaseProperties();
        
        builder.HasData(DataSeed.GetApplications());
    }
}