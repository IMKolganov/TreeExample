using DB.Entities;

namespace DB.Repositories.Interfaces;

public interface IExampleRepository
{
    Task<Example?> Get(int id);
    Task<Example?> GetByIdParent(int idParent);
    Task<Example> Add(Example treeView);
    Task<Example> Update(Example treeView);
    Task<List<Example>> GetAll();
}