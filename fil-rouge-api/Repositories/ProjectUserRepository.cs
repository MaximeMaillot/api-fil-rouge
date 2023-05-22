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
            var result = base.GetAsync(e => e.UserId == userId && e.ProjectId == projectId).Result;
            if (result == null)
            {
                return false;
            }
            return result.IsAdmin;
        }

        public List<ProjectUser> GetProjectByUserId(int userId)
        {
            return GetDbSet().Include(e => e.Project).ThenInclude(e => e.Tasks).Where(e => e.UserId == userId).ToList();
        }
    }
}
