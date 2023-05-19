using AutoMapper;
using fil_rouge_api.DTOs;
using fil_rouge_api.Models;

namespace fil_rouge_api.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, RegisterRequestDTO>().ReverseMap();
            CreateMap<User, RegisterResponseDTO>().ReverseMap();
            CreateMap<User, LoginRequestDTO>().ReverseMap();
            CreateMap<User, LoginResponseDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Models.Task, TaskDTO>().ReverseMap();
            CreateMap<Project, ProjectDTO>().ReverseMap();
            CreateMap<Comment, CommentDTO>().ReverseMap();
        }
    }
}
