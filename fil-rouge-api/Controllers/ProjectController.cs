using ApiHelper.Controllers;
using AutoMapper;
using EFHelper.Interfaces;
using fil_rouge_api.DTOs;
using fil_rouge_api.Models;
using fil_rouge_api.Repositories;
using fil_rouge_api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace fil_rouge_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ProjectController : GenericCrudController<Project, ProjectDTO>
    {
        private readonly IRepository<ProjectUser> _projectUserRepository;
        public ProjectController(IRepository<Project> genericRepository, IMapper mapper, IRepository<ProjectUser> projectUserRepository) : base(genericRepository, mapper)
        {
            _projectUserRepository = projectUserRepository;
        }

        public override async Task<IActionResult> GetAll()
        {
            int? userId = JwtService.GetJwtTokenUserId(HttpContext);
            if (userId == null)
            {
                return Unauthorized();
            }
            List<ProjectUser> projectsUser = await ((ProjectUserRepository)_projectUserRepository).GetProjectUserByUserId((int)userId);
            List<Project> projects = projectsUser.Select(x => x.Project!).ToList();

            if (projects == null)
            {
                return NoContent();
            }

            List<ProjectDTO> projectsDTO = _mapper.Map<List<Project>, List<ProjectDTO>>(projects);

            return Ok(projectsDTO);
        }

        [HttpGet]
        [Route("authenticate/{projectId}")]
        public async Task<IActionResult> GetUserProjectAuthority([FromRoute] int projectId)
        {
            int? userId = JwtService.GetJwtTokenUserId(HttpContext);
            if (userId == null)
            {
                return Unauthorized();
            }
            bool isAdmin = await ((ProjectUserRepository)_projectUserRepository).IsUserAdmin((int)userId, projectId);
            return Ok(isAdmin);
        }
    }
}
