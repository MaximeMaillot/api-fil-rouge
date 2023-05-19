using fil_rouge_api.Data;
using EFHelper.Repositories;
using fil_rouge_api.Models;
using Microsoft.EntityFrameworkCore;

namespace fil_rouge_api.Repositories
{
    public class ProjectRepository : GenericRepository<Project>
    {
        public ProjectRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
