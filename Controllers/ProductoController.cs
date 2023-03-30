using JWT_API.constante;
using JWT_API.Respuesta;
using Microsoft.AspNetCore.Mvc;

namespace JWT_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : Controller
    {

        ProductConstant producto = new ProductConstant();

        respuesta or = new respuesta(); 

        [HttpGet]
        public IActionResult get()
        {
            try 
            {
            var lst = producto.producto.ToList();

                if (lst == null) 
                {

                    or.message = "No hay productos";
                
                }

                or.data = 0;
                or.data = lst;

            }catch(Exception ex) 
            {
                or.exito = 0;
                or.message = $"Ha habido un error {ex}";

            }

            return Ok(or);

        }
    }
}
