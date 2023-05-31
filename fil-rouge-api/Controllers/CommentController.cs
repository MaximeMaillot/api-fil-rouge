﻿using ApiHelper.Controllers;
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
    public class CommentController : GenericCrudController<Comment, CommentDTO>
    {
        public CommentController(IRepository<Comment> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }

        [Route("task/{taskId}")]
        [HttpGet]
        public async Task<IActionResult> GetCommentByTaskId([FromRoute] int taskId)
        {
            List<Comment> comments = await _genericRepository.GetAllAsync(e => e.TaskId == taskId, e => e.User);
            List<CommentDTO> commentDTOs = _mapper.Map<List<Comment>, List<CommentDTO>>(comments);
            return Ok(commentDTOs);
        }
    }
}
