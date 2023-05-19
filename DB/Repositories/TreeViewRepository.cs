using Microsoft.EntityFrameworkCore;
using DB.Entities;
using DB.Repositories.Interfaces;

namespace DB.Repositories;

public class ExampleRepository : IExampleRepository
{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<Example> _dbSet;

    public ExampleRepository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = context.Set<Example>();
    }

    public async Task<Example?> Get(int id)
    {
        var result = await _dbSet.FindAsync(id);
        return result;
    }
    
    public async Task<Example?> GetByIdParent(int idParent)
    {
        var result = _dbSet.FirstOrDefault(x => x.Id == idParent)!;
        return result;
    }
    
    public async Task<Example> Add(Example example)
    {
        await _dbSet.AddAsync(example);
        await _context.SaveChangesAsync();
        return example;
    }
    
    public async Task<Example> Update(Example example)
    {
        _dbSet.Update(example);
        await _context.SaveChangesAsync();
        return example;
    }

    public async Task<List<Example>> GetAll()
    {
        return await _dbSet.ToListAsync();
    }
}