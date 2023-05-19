using DB.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YakimGames.BackOffice.Server.DB.Seed;
using Entities = DB.Entities;

namespace DB.Configuration;

public class ActionConfiguration : IEntityTypeConfiguration<Entities.Action>
{
    public void Configure(EntityTypeBuilder<Entities.Action> builder)
    {
        builder.ToTable("Action");

        builder.HasKey(e => e.Id);

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
        
        builder.HasData(DataSeed.GetActions());
    }
    
    
}