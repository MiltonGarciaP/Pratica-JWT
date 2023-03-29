using JWT_API.Models;

namespace JWT_API.constante
{
    public class UserConstant
    {

        public List<UserModels> Users = new List<UserModels>() {


           new  UserModels() {UserName= "Milton", Password = "123456", Rol = "Administrador", Email = "miltongp26@gmail.com", FirstName = "Milton", LastName = "Garcia"  },
           new  UserModels() {UserName= "Elena", Password = "123456", Rol = "Vendedor", Email = "Elena12@gmail.com", FirstName = "Elena", LastName = "Payero"  },
        };
    
    }
}
