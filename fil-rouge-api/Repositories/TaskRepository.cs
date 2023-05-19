using fil_rouge_api.Data;
using EFHelper.Repositories;
using fil_rouge_api.Models;
using Microsoft.EntityFrameworkCore;

namespace fil_rouge_api.Repositories
{
    public class TaskRepository : GenericRepository<Models.Task>
    {
        public TaskRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
