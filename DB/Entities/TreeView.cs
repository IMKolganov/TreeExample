using System.ComponentModel.DataAnnotations;

namespace DB.Entities;

public class TreeView : EntityBase
{
    [Required, Key] public int Id { get; set; }
    [Required] public int RefApplicationId { get; set; }
    [Required] public int ParentApplicationId { get; set; }
    [Required] public int ApplicationTypeId { get; set; }
}