// using Microsoft.EntityFrameworkCore;
// using DB.Entities;
// using DB.Repositories.Interfaces;
// using Entities = DB.Entities.Action;
//
// namespace DB.Repositories;
//
// public class ActionRepository : IActionRepository
// {
//     private readonly ApplicationDbContext _context;
//     private readonly DbSet<Entities.Action> _dbSet;
//
//     public ActionRepository(ApplicationDbContext context)
//     {
//         _context = context;
//         _dbSet = context.Set<Entities.Action>();
//     }
//
//     public async Task<Entities.Action?> Get(int id)
//     {
//         var result = await _dbSet.FindAsync(id);
//         return result;
//     }
//     
//     public async Task<Entities.Action> Add(Entities.Action action)
//     {
//         await _dbSet.AddAsync(action);
//         await _context.SaveChangesAsync();
//         return action;
//     }
//     
//     public async Task<Entities.Action> Update(Entities.Action action)
//     {
//         _dbSet.Update(action);
//         await _context.SaveChangesAsync();
//         return action;
//     }
//
//     public async Task<List<Entities.Action>> GetAll()
//     {
//         return await _dbSet.ToListAsync();
//     }
//     
//     public async Task<List<Entities.Action>> GetByIds(List<int> ids)
//     {
//         var result = await _dbSet
//             .Where(a => ids.Contains(a.Id))
//             .ToListAsync();
//         return result;
//     }
// }