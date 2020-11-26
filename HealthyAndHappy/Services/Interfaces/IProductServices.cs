using HealthyAndHappy.Models.ModelsDTO;

namespace HealthyAndHappy.Services.Interfaces
{
    public interface IProductServices
    {
        ResponseDTO AddProduct(ProductDTO product);
        ResponseDTO DeleteProduct(ProductDTO product);
        ResponseDTO EditProduct(ProductDTO product);
        ProductDTO GetAllByCategory(CategoryDTO category);
    }
}
