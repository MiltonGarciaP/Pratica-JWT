using JWT_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JWT_API.Respuesta;
using JWT_API.constante;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

namespace JWT_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInCon : ControllerBase
    {

        private readonly IConfiguration _Config;

        public LogInCon(IConfiguration config) 
        {
            _Config = config;
        
        }
        respuesta RES = new respuesta();
        UserConstant UserConstant = new UserConstant();

        [HttpPost]

        public IActionResult Get(LoginUser login) 
        {
            try 
            {
                var user = Authencation(login);

                if (user != null) 
                {
                    // creacion del token

                    var token = Generate(user);
                    return Ok(token); 
                
                }

                return Ok(RES.message = "Usuario no encontrado");


            }
            catch (Exception ex) 
            {
                return Ok(RES.message = "Usuario no encontrado");


                RES.exito = 0;
                RES.message = $"Ha ocurrido un error y es {ex} ";
                
            
            }




            return Ok(RES);
        
        }

        private UserModels Authencation(LoginUser login)
        {
            var currentUser = UserConstant.Users.FirstOrDefault(user => user.UserName.ToLower() == login.UserName.ToLower()
            && user.Password == login.Password);

            if (currentUser != null) 
            {
                return currentUser;
            }

            return null;
        }

        private string Generate(UserModels user) 
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_Config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey , SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
           new Claim (ClaimTypes.NameIdentifier, user.UserName),
           new Claim(ClaimTypes.Email, user.Email),
           new Claim(ClaimTypes.GivenName , user.UserName),
           new Claim(ClaimTypes.Surname, user.LastName),
           new Claim(ClaimTypes.Role , user.Rol)

         };

            var token = new JwtSecurityToken
                (
                _Config["Jwt:Issuer"],
                _Config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMonths(1),
                signingCredentials: credentials
                );


            return new JwtSecurityTokenHandler().WriteToken(token);
        
        }
    }
}
