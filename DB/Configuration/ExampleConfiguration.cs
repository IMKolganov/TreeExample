using DB.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DB.Configuration;

public class ExampleConfiguration : IEntityTypeConfiguration<Entities.Example>
{
    public void Configure(EntityTypeBuilder<Entities.Example> builder)
    {
        builder.ToTable("Example");

        builder.HasKey(e => e.Id);
        
        builder
            .Property(e => e.IdParent)
            .IsRequired();

        builder
            .Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(255);
        
        builder
            .Property(e => e.RefAppId)
            .IsRequired();
        
        builder
            .Property(e => e.Path);

        builder.UseBaseProperties();
        
        builder.HasData(DataSeed.GetExamples());
    }
    
    
}