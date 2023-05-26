using ApiHelper.Controllers;
using AutoMapper;
using EFHelper.Interfaces;
using fil_rouge_api.DTOs;
using fil_rouge_api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace fil_rouge_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class TaskController : GenericCrudController<Models.Task, TaskDTO>
    {
        public TaskController(IRepository<Models.Task> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }

        [Route("project/{projectId}")]
        [HttpGet]
        public async Task<IActionResult> GetTasksByProjectId([FromRoute] int projectId)
        {
            List<Models.Task> tasks = await _genericRepository.GetAllAsync(e => e.ProjectId == projectId);
            List<TaskDTO> taskDTOs = _mapper.Map<List<Models.Task>, List<TaskDTO>>(tasks);
            return Ok(taskDTOs);
        }
    }
}
