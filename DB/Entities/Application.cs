using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Entities;

public class Application : EntityBase
{
    [Required, Key] public int Id { get; set; }
    [Required, MaxLength(255)] public string ApplicationName { get; set; }
    [MaxLength(1024)] public string? Description { get; set; }
}