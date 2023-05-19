using DB.Entities;

namespace DB.Repositories.Interfaces;

public interface ITreeViewRepository
{
    Task<TreeView?> Get(int id);
    Task<TreeView> Add(TreeView treeView);
    Task<TreeView> Update(TreeView treeView);
    Task<List<TreeView>> GetAll();
}