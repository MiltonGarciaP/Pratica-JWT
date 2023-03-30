using JWT_API.constante;
using JWT_API.Respuesta;
using Microsoft.AspNetCore.Mvc;

namespace JWT_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {

        [HttpGet]
        public IActionResult get () 
        {
            respuesta or =new respuesta();
            EmpleadoConstante empleado = new EmpleadoConstante();  

            try 
            {
            
                var lst = empleado.empleadoModels.ToList();
                
                or.data= lst;
                or.exito = 0;


                if (lst == null)
                {

                    or.message = "No se ha encontrado los empleados ";
                
                
                
                }



            }catch(Exception ex) 
            {
            
             or.exito = 1;

                or.message = $"Ha ocurrido un error el error es {ex}";
            
            }

            return Ok(or);
        
        }
    }
}
