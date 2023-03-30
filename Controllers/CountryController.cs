using JWT_API.constante;
using JWT_API.Respuesta;
using Microsoft.AspNetCore.Mvc;

namespace JWT_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {

        respuesta or = new respuesta();

        [HttpGet]

        public IActionResult get() 
        {
            CountryConstant paises = new CountryConstant();

            try 
            {
             var list =  paises.countrymodels.ToList();
                 
              
                or.data = list;

            
            
            }catch(Exception ex) 
            {

                or.message = $"Ha ocurrido un error {ex}";
            
            
            }


            return Ok(or);
        
        }

    }
}
