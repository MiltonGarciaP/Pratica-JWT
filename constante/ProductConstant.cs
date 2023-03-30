using JWT_API.Models;

namespace JWT_API.constante
{
    public class ProductConstant
    {

        public List<ProductModel> producto = new List<ProductModel>()
        {
            new ProductModel () {Id = 1, Name = "Cerveza"},
            new ProductModel () {Id = 2, Name = "Refresco"},
            new ProductModel () {Id = 3, Name = "Manzana"},
            new ProductModel () {Id = 4, Name = "Cereza"},
            new ProductModel () {Id = 5, Name = "Jugo"},
            new ProductModel () {Id = 6, Name = "Pan"},
            new ProductModel () {Id = 7, Name = "Bizcocho"},
            new ProductModel () {Id = 8, Name = "Agua"},
            new ProductModel () {Id = 9, Name = "Jamon"},
            new ProductModel () {Id = 10, Name = "Queso"}

        };
    }
}
