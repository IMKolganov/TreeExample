﻿namespace DB.Entities;

public class EntityBase : IEntityBase
{
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime Updated { get; set; } = DateTime.UtcNow;
}