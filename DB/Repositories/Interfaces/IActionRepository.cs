using Entities = DB.Entities.Action;

namespace DB.Repositories.Interfaces;
public interface IActionRepository
{
    Task<Entities.Action?> Get(int id);
    Task<Entities.Action> Add(Entities.Action action);
    Task<Entities.Action> Update(Entities.Action action);
    Task<List<Entities.Action>> GetAll();
    Task<List<Entities.Action>> GetByIds(List<int> ids);
}