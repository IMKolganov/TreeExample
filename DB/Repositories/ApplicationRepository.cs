// using Microsoft.EntityFrameworkCore;
// using DB.Entities;
// using DB.Repositories.Interfaces;
//
// namespace DB.Repositories;
//
// public class ApplicationRepository : IApplicationRepository
// {
//     private readonly ApplicationDbContext _context;
//     private readonly DbSet<Application> _dbSet;
//
//     public ApplicationRepository(ApplicationDbContext context)
//     {
//         _context = context;
//         _dbSet = context.Set<Application>();
//     }
//     
//     public async Task<Application?> Get(int id)
//     {
//         var result = await _dbSet.FindAsync(id);
//         return result;
//     }
//     
//     public async Task<Application> Add(Application application)
//     {
//         await _dbSet.AddAsync(application);
//         await _context.SaveChangesAsync();
//         return application;
//     }
//     
//     public async Task<Application> Update(Application application)
//     {
//         _dbSet.Update(application);
//         await _context.SaveChangesAsync();
//         return application;
//     }
//
//     public async Task<List<Application>> GetAll()
//     {
//         return await _dbSet.ToListAsync();
//     }
//
//     public async Task<List<Application>> GetByIds(List<int> ids)
//     {
//         var result = await _dbSet
//             .Where(a => ids.Contains(a.Id))
//             .ToListAsync();
//         return result;
//     }
// }