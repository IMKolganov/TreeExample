using System.ComponentModel.DataAnnotations;

namespace DB.Entities;

public class Example : EntityBase
{
    public Example(int id, int idParent, string name, int refAppId, string? path)
    {
        Id = id;
        IdParent = idParent;
        Name = name;
        RefAppId = refAppId;
        Path = path;
    }
    [Required, Key] public int Id { get; set; }
    [Required, Key] public int IdParent { get; set; }
    [Required, MaxLength(255)] public string Name { get; set; }
    [Required] public int RefAppId { get; set; }
    public string? Path { get; set; }
}