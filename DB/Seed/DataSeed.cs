using Entities = DB.Entities;

namespace DB.Seed;

public class DataSeed
{

    public static IEnumerable<Entities.Application> GetApplications()
    {
        yield return new Entities.Application() { Id = 1, ApplicationName = "App1" };
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
        yield return new Entities.Action(1, "Delete", 0, "");
        yield return new Entities.Action(2, "Edit", 1, "" );
        yield return new Entities.Action(3, "Read", 1, "" );
        yield return new Entities.Action(4, "Delete", 2 , "" );
        yield return new Entities.Action(5, "Edit", 2, "" );
        yield return new Entities.Action(6, "Read", 2, "" );
        yield return new Entities.Action(7, "Delete", 3, "" );
        yield return new Entities.Action(8, "Edit", 3, "" );
        yield return new Entities.Action(9, "Read", 3, "" );
        yield return new Entities.Action(10, "Delete", 4 , "" );
        yield return new Entities.Action(11, "Edit", 4 , "" );
        yield return new Entities.Action(12, "Read", 4, "" );
        yield return new Entities.Action(13, "Delete", 5 , "" );
        yield return new Entities.Action(14, "Edit", 5, "" );
        yield return new Entities.Action(15, "Read", 5, "" );
        yield return new Entities.Action(16, "Delete", 6, "" );
        yield return new Entities.Action(17, "Edit", 6, "" );
        yield return new Entities.Action(18, "Read", 6, "" );
    }
    
}