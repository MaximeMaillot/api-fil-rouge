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
    [Authorize]
    public class UserController : GenericCrudController<User, UserDTO>
    {
        private readonly IRepository<ProjectUser> _projectUserRepository;

        public UserController(IRepository<User> genericRepository, IMapper mapper, IRepository<ProjectUser> projectUserRepository) : base(genericRepository, mapper)
        {
            _projectUserRepository = projectUserRepository;
        }

        [Route("project/{projectId}")]
        [HttpGet]
        public async Task<IActionResult> GetUsersByProjectId([FromRoute] int projectId)
        {
            List<ProjectUser> projectUsers = await ((ProjectUserRepository)_projectUserRepository).GetProjectUserByProjectId(projectId);
            List<User> users = projectUsers.Select(x => x.User).ToList();
            List<UserDTO> userDTOs = _mapper.Map<List<User>, List<UserDTO>>(users);
            return Ok(userDTOs);
        }
    }
}
