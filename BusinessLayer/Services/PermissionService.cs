using BusinessLayer.BusinessModels;
using BusinessLayer.Services.Interfaces;
using DB.Repositories.Interfaces;
using Entities = DB.Entities;

namespace BusinessLayer.Services;

public class PermissionService : IPermissionService
{
    private readonly IApplicationRepository _applicationRepository;
    private readonly IActionRepository _actionRepository;
    private readonly ITreeViewRepository _treeViewRepository;

    public PermissionService(
        IApplicationRepository applicationRepository, 
        IActionRepository actionRepository,
        ITreeViewRepository treeViewRepository)
    {
        _applicationRepository = applicationRepository;
        _actionRepository = actionRepository;
        _treeViewRepository = treeViewRepository;
    }

    

    public async Task<Permissions> GetAllApplications()
    {
        var permissions = new Permissions();
        
        var applications = await _applicationRepository.GetAll();
        var actions = await _actionRepository.GetAll();
        var treeViews = await _treeViewRepository.GetAll();

        var applicationPermission = new ApplicationPermission();

        GetApplicationPermissionByApplication(0, treeViews, applications, actions, applicationPermission);

        permissions.ApplicationPermissions = applicationPermission.ChildApplications;

        return permissions;
    }

   
    
    private void GetApplicationPermissionByApplication(
        int parentId, 
        List<Entities.TreeView> treeViews, 
        List<Entities.Application> applications, 
        List<Entities.Action> actions, 
        ApplicationPermission applicationPermission)
    {
        var childrenIds = treeViews.Where(x => x.ParentApplicationId == parentId).Select(x => x.RefApplicationId).ToList();
        var childrenForParentId = applications.Where(a => childrenIds.Contains(a.Id)).ToList();
        
        foreach (var childApp in childrenForParentId)
        {
            var childAppPerm = ConvertApplicationToApplicationPermission(childApp, actions);
            applicationPermission.ChildApplications.Add(childAppPerm);
            GetApplicationPermissionByApplication(childApp.Id, treeViews, applications, actions, childAppPerm);
        }
    }
    
    private ApplicationPermission ConvertApplicationToApplicationPermission(Entities.Application app, List<Entities.Action> actions)
    {
        var appPermission = new ApplicationPermission()
        {
            ApplicationId = app.Id,
            ApplicationName = app.ApplicationName,
            Actions = ConvertActionsToActionPermissions(app, actions)
        };
        return appPermission;
    }
    
    private List<ActionPermission> ConvertActionsToActionPermissions(Entities.Application app, List<Entities.Action> actions)
    {
        var appActions = new List<ActionPermission>();
        
        foreach (var act in actions)
        {
            if (act.RefAppId == app.Id)
            {
                appActions.Add(new ActionPermission()
                {
                    ActionId = act.Id,
                    ActionName = act.Name
                });
            }
        }
        return appActions;
    }
}