using BusinessLayer.BusinessModels;

namespace BusinessLayer.Services.Interfaces;

public interface IPermissionService
{
    Task<Permissions> GetAllApplications();
}