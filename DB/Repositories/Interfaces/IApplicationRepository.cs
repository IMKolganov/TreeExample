using DB.Entities;

namespace DB.Repositories.Interfaces;

public interface IApplicationRepository
{
    Task<Application?> Get(int id);
    Task<Application> Add(Application application);
    Task<Application> Update(Application application);
    Task<List<Application>> GetAll();
    Task<List<Application>> GetByIds(List<int> ids);
}