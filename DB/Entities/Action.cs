using System.ComponentModel.DataAnnotations;

namespace DB.Entities;

public class Action : EntityBase
{
    [Required, Key] public int Id { get; set; }
    [Required, MaxLength(255)] public string Name { get; set; }
    [Required] public int RefAppId { get; set; }
    public string? Path { get; set; }
}