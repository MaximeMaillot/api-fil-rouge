using ApiHelper.Controllers;
using AutoMapper;
using EFHelper.Interfaces;
using fil_rouge_api.DTOs;
using fil_rouge_api.Models;
using fil_rouge_api.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace fil_rouge_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class ProjectController : GenericCrudController<Project, ProjectDTO>
    {
        private readonly IRepository<ProjectUser> _projectUserRepository;
        public ProjectController(IRepository<Project> genericRepository, IMapper mapper, IRepository<ProjectUser> projectUserRepository) : base(genericRepository, mapper)
        {
            _projectUserRepository = projectUserRepository;
        }

        [HttpGet]
        [Route("/user/{id}")]
        public IActionResult GetProjectsByUser([FromRoute] int id)
        {
            List<Project> projects =  (_projectUserRepository as ProjectUserRepository).GetProjectByUserId(id)
                .Select(pu =>
                {
                    return new Project()
                    {
                        Id = pu.ProjectId,
                        Name = pu.Project.Name,
                        Tasks = pu.Project.Tasks,
                        Description = pu.Project.Description
                    };
                }).ToList(); ;

            if (projects == null)
            {
                return NotFound();
            }

            List<ProjectDTO> projectsDTO = _mapper.Map<List<Project>, List<ProjectDTO>>(projects);
            
            return Ok(projectsDTO);
        }

        [HttpGet]
        [Route("{userId}/{projectId}")]
        public async Task<IActionResult> GetUserRules([FromRoute] int userId, [FromRoute] int projectId)
        {
            bool isAdmin = await (_projectUserRepository as ProjectUserRepository).IsUserAdmin(userId, projectId);
            return Ok(isAdmin);
        }
    }
}
