using DB.Entities;
using DB.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DB.Configuration;

public class TreeViewConfiguration : IEntityTypeConfiguration<TreeView>
{
    public void Configure(EntityTypeBuilder<TreeView> builder)
    {
        builder.ToTable("TreeView");

        builder.HasKey(e => e.Id);

        builder
            .Property(e => e.RefApplicationId)
            .IsRequired();
        
        builder
            .Property(e => e.ParentApplicationId)
            .IsRequired();
        
        builder
            .Property(e => e.ApplicationTypeId)
            .IsRequired();

        builder.UseBaseProperties();
        
        builder.HasData(DataSeed.GetTreeViews());
    }
}