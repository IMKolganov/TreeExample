namespace DB.Entities;

public interface IEntityBase
{
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
}