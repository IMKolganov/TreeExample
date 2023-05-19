namespace DB.Seed;

public static class EnumFunctions
{
    public static IEnumerable<TModel> GetModelsFromEnum<TModel, TEnum>() where TModel : IEnumModel<TModel, TEnum>, new()
    {
        var enums = new List<TModel>();
        foreach (var enumVar in (TEnum[])Enum.GetValues(typeof(TEnum)))
        {
            if (enumVar != null)
                enums.Add(new TModel
                {
                    Id = enumVar,
                    Name = (enumVar.ToString()) ?? string.Empty,
                });
        }

        return enums;
    }
}
