using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Entities;

public class Application : EntityBase
{
    public Application(int id = default, string? applicationName = null, string? description = null)
    {
        Id = id;
        ApplicationName = applicationName ?? throw new ArgumentNullException(nameof(applicationName));
        Description = description;
    }

    [Required, Key] public int Id { get; set; }
    [Required, MaxLength(255)] public string ApplicationName { get; set; }
    [MaxLength(1024)] public string? Description { get; set; }
}