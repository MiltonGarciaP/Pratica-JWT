using JWT_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JWT_API.Respuesta;
using JWT_API.constante;

namespace JWT_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInCon : ControllerBase
    {

        respuesta RES = new respuesta();
        UserConstant UserConstant = new UserConstant();

        [HttpPost]

        public IActionResult Get(LoginUser login) 
        {
            try 
            {
                var use = Authencation(login);

                if (User != null) 
                {
                 // creacion del token

                    return Ok(RES.message ="Usuario logeado"); 
                
                }

                return Ok(RES.message = "Usuario no encontrado");


            }
            catch (Exception ex) 
            {
                return Ok(RES.message = "Usuario logeado");


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
    }
}
