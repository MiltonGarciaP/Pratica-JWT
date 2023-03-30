using JWT_API.Models;

namespace JWT_API.constante
{
    public class EmpleadoConstante
    {

        public List<EmpleadoModel> empleadoModels = new List<EmpleadoModel>()
        {
         new EmpleadoModel (){FirstName = "Francisco", LastName = "Concepcion", Email = "francisco@gmail.com" },
         new EmpleadoModel (){FirstName = "Pedro", LastName = "Ramirez" , Email = "pedro@gmail.com" },
         new EmpleadoModel (){FirstName = "Shoei", LastName = "Ohtani" , Email = "shoei@gmail.com"},
         new EmpleadoModel (){FirstName = "Francisco", LastName = "Lindor", Email = "franciscoc@gmail.com" },
         new EmpleadoModel (){FirstName = "Daniel", LastName = "Perez",Email = "Daniel@gmail.com" },
         new EmpleadoModel (){FirstName = "Rafael", LastName = "Melo" , Email = "rafael@gmail.com"},
         new EmpleadoModel (){FirstName = "Sebastian", LastName = "Espinal", Email = "sebastian@gmail.com" }
        };



    }
}
