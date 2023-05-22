using fil_rouge_api.Data;
using EFHelper.Repositories;
using fil_rouge_api.Models;
using Microsoft.EntityFrameworkCore;
using EFHelper.Interfaces;
using System.Collections.Immutable;

namespace fil_rouge_api.Repositories
{
    public class ProjectRepository : GenericRepository<Project>
    {
        public ProjectRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public List<Project> GetProjectsByUserId(int userId)
        {
            List<Project> projects = _dbContext.Set<ProjectUser>().Include(e => e.Project).ThenInclude(e => e.Tasks).Where(e => e.UserId == userId).ToList()
                .Select(pu =>
                {
                    return new Project()
                    {
                        Id = pu.ProjectId,
                        Name = pu.Project.Name,
                        Tasks = pu.Project.Tasks,
                        Description = pu.Project.Description
                    };
                }).ToList();

            return projects;
         }
    }
}
