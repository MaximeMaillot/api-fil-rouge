using EFHelper.Repositories;
using fil_rouge_api.Data;
using fil_rouge_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fil_rouge_api.Repositories
{
    public class ProjectUserRepository : GenericRepository<ProjectUser>
    {
        public ProjectUserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> IsUserAdmin(int userId, int projectId)
        {
            var result = await base.GetAsync(e => e.UserId == userId && e.ProjectId == projectId);
            if (result == null)
            {
                return false;
            }
            return result.IsAdmin;
        }

        public async Task<List<ProjectUser>> GetProjectUserByUserId(int userId)
        {
            return await GetDbSet()
                .Include(e => e.Project)
                .Where(e => e.UserId == userId && e.Project!.DateDeleted == null)
                .ToListAsync();
        }

        public async Task<List<ProjectUser>> GetProjectUserByProjectId(int projectId)
        {
            return await GetDbSet()
                .Include(e => e.User)
                .Where(e => e.ProjectId == projectId && e.User!.DateDeleted == null)
                .ToListAsync();
        }
    }
}
