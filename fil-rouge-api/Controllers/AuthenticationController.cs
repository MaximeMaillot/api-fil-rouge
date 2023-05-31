using AutoMapper;
using fil_rouge_api.Data;
using fil_rouge_api.DTOs;
using fil_rouge_api.Helpers;
using fil_rouge_api.Models;
using EFHelper.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Win32;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using fil_rouge_api.Services;
using Microsoft.Extensions.Primitives;

namespace fil_rouge_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IRepository<User> _userRepository;
        private readonly AppSettings _settings;
        private readonly IMapper _mapper;

        public AuthenticationController(IOptions<AppSettings> appSettings, IMapper mapper, IRepository<User> userRepository)
        {
            _userRepository = userRepository;
            _settings = appSettings.Value;
            _mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDTO register)
        {
            if (_userRepository.Get(u => u.Email == register.Email) != null) // on a un utilisateur existant avec cet email
                return BadRequest("Email is already taken");

            //chiffrage du mdp
            register.Password = PasswordService.EncryptPassword(register.Password, _settings.SecretKey);

            var user = _mapper.Map<RegisterRequestDTO, User>(register);

            int id = await _userRepository.AddAsync(user);
            user.Id = id;
            var token = JwtService.GetJWTToken(user, _settings);

            var registerResponseDTO = _mapper.Map<User, RegisterResponseDTO>(user);
            if (id > 0)
            {
                return Ok(new
                {
                    Token = token,
                    Message = "User registered",
                    User = registerResponseDTO
                });
            }
            return BadRequest("Something went wrong...");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO login)
        {
            login.Password = PasswordService.EncryptPassword(login.Password, _settings.SecretKey);

            var user = await _userRepository.GetAsync(u => u.Email == login.Email && u.Password == login.Password);

            if (user == null) return BadRequest("Invalid Authentication !");

            var loginResponseDTO = _mapper.Map<User, LoginResponseDTO>(user);

            var token = JwtService.GetJWTToken(user, _settings);

            return Ok(new
            {
                Token = token,
                Message = "Authentication successfull !!!!!!!",
                User = loginResponseDTO
            });
        }

        [HttpGet]
        public async Task<IActionResult> GetTokenUser()
        {
            var token = JwtService.GetTokenData(Request.HttpContext);
            if (token == null) return BadRequest("Invalid JWT Token !");
            var payload = token.Payload.Claims.ToList();
            var userId = payload.First(d =>
            {
                return d.Type == "UserId";
            }).Value;
            var user = await _userRepository.GetAsync(u => u.Id == Convert.ToInt32(userId));
            var userDTO = _mapper.Map<User, UserDTO>(user);
            return Ok(userDTO);
        }
    }
}
