﻿using fil_rouge_api.Helpers;
using fil_rouge_api.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Runtime;
using System.Security.Claims;
using System.Text;

namespace fil_rouge_api.Services
{
    public static class JwtService
    {
        public static string GetJWTToken(User user, AppSettings settings)
        {
            List<Claim> claims = new List<Claim>()
            {
                new Claim("UserId", user.Id.ToString()) // on peut ajouter l'Id de l'utilisateur en Claim
            };

            SigningCredentials signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.ASCII.GetBytes(settings.SecretKey!)),
                SecurityAlgorithms.HmacSha256);

            JwtSecurityToken jwt = new JwtSecurityToken(
                issuer: settings.ValidIssuer,
                audience: settings.ValidAudience,
                claims: claims,
                signingCredentials: signingCredentials,
                expires: DateTime.Now.AddDays(7)
                );

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }

        public static int? GetJwtTokenUserId(HttpContext context)
        {
            try
            {
                return Convert.ToInt32(context.User.Claims.FirstOrDefault(x => x.Type == "UserId").Value);
            } catch (NullReferenceException e)
            {
                return null;
            } catch (FormatException e)
            {
                return null;
            }
        }
    }
}
