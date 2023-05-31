using fil_rouge_api.Data;
using EFHelper.Repositories;
using fil_rouge_api.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace fil_rouge_api.Repositories
{
    public class TaskRepository : GenericRepository<Models.Task>
    {
        public TaskRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<List<Models.Task>> GetAllAsync(Expression<Func<Models.Task, bool>> predicate)
        {
            return await _dbContext.Set<Models.Task>().Include(e => e.Comments).ThenInclude(e => e.User).Where(predicate).ToListAsync();
        }
    }
}
