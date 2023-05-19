using Entities = DB.Entities;

namespace DB.Seed;

public class DataSeed
{

    public static IEnumerable<Entities.Application> GetApplications()
    {
        yield return new Entities.Application { Id = 1, ApplicationName = "App1" };
        yield return new Entities.Application { Id = 2, ApplicationName = "App2" };
        yield return new Entities.Application { Id = 3, ApplicationName = "App3" };
        yield return new Entities.Application { Id = 4, ApplicationName = "App4" };
        yield return new Entities.Application { Id = 5, ApplicationName = "App5" };
        yield return new Entities.Application { Id = 6, ApplicationName = "App6" };
    }
    
    public static IEnumerable<Entities.TreeView> GetTreeViews()
    {
        yield return new Entities.TreeView { Id = 1, RefApplicationId = 1, ParentApplicationId = 0, ApplicationTypeId = 1 };
        yield return new Entities.TreeView { Id = 2, RefApplicationId = 2, ParentApplicationId = 0, ApplicationTypeId = 1 };
        yield return new Entities.TreeView { Id = 3, RefApplicationId = 3, ParentApplicationId = 1, ApplicationTypeId = 1 };
        yield return new Entities.TreeView { Id = 4, RefApplicationId = 4, ParentApplicationId = 2, ApplicationTypeId = 1 };
        yield return new Entities.TreeView { Id = 5, RefApplicationId = 5, ParentApplicationId = 3, ApplicationTypeId = 1 };
        yield return new Entities.TreeView { Id = 6, RefApplicationId = 6, ParentApplicationId = 5, ApplicationTypeId = 1 };
    }
    
    public static IEnumerable<Entities.Action> GetActions()
    {
        yield return new Entities.Action { Id = 1, Name = "Delete", RefAppId = 1 };
        yield return new Entities.Action { Id = 2, Name = "Edit", RefAppId = 1 };
        yield return new Entities.Action { Id = 3, Name = "Read", RefAppId = 1 };
        yield return new Entities.Action { Id = 4, Name = "Delete", RefAppId = 2 };
        yield return new Entities.Action { Id = 5, Name = "Edit", RefAppId = 2 };
        yield return new Entities.Action { Id = 6, Name = "Read", RefAppId = 2 };
        yield return new Entities.Action { Id = 7, Name = "Delete", RefAppId = 3 };
        yield return new Entities.Action { Id = 8, Name = "Edit", RefAppId = 3 };
        yield return new Entities.Action { Id = 9, Name = "Read", RefAppId = 3 };
        yield return new Entities.Action { Id = 10, Name = "Delete", RefAppId = 4 };
        yield return new Entities.Action { Id = 11, Name = "Edit", RefAppId = 4 };
        yield return new Entities.Action { Id = 12, Name = "Read", RefAppId = 4 };
        yield return new Entities.Action { Id = 13, Name = "Delete", RefAppId = 5 };
        yield return new Entities.Action { Id = 14, Name = "Edit", RefAppId = 5 };
        yield return new Entities.Action { Id = 15, Name = "Read", RefAppId = 5 };
        yield return new Entities.Action { Id = 16, Name = "Delete", RefAppId = 6 };
        yield return new Entities.Action { Id = 17, Name = "Edit", RefAppId = 6 };
        yield return new Entities.Action { Id = 18, Name = "Read", RefAppId = 6 };
    }
    
}