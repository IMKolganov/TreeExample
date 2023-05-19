// using Microsoft.EntityFrameworkCore;
// using DB.Entities;
// using DB.Repositories.Interfaces;
//
// namespace DB.Repositories;
//
// public class TreeViewRepository : ITreeViewRepository
// {
//     private readonly ApplicationDbContext _context;
//     private readonly DbSet<TreeView> _dbSet;
//
//     public TreeViewRepository(ApplicationDbContext context)
//     {
//         _context = context;
//         _dbSet = context.Set<TreeView>();
//     }
//
//     public async Task<TreeView?> Get(int id)
//     {
//         var result = await _dbSet.FindAsync(id);
//         return result;
//     }
//     
//     public async Task<TreeView> Add(TreeView treeView)
//     {
//         await _dbSet.AddAsync(treeView);
//         await _context.SaveChangesAsync();
//         return treeView;
//     }
//     
//     public async Task<TreeView> Update(TreeView treeView)
//     {
//         _dbSet.Update(treeView);
//         await _context.SaveChangesAsync();
//         return treeView;
//     }
//
//     public async Task<List<TreeView>> GetAll()
//     {
//         return await _dbSet.ToListAsync();
//     }
// }