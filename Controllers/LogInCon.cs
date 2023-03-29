using JWT_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JWT_API.Respuesta;

namespace JWT_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInCon : ControllerBase
    {

        respuesta RES = new respuesta();

        [HttpPost]

        public IActionResult Get(LoginUser login) 
        {
            try 
            {
            

            
            }catch(Exception ex) 
            {
                RES.exito = 0;
                RES.message = $"Ha ocurrido un error y es {ex} ";
                
            
            }




            return Ok(RES);
        
        }
    }
}
