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
    }
}
