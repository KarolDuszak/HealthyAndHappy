using HealthyAndHappy.Models;
using HealthyAndHappy.Models.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Services.Interfaces
{
    public interface ILarderService
    {
        LarderDTO Get(string userId);
        ProductsDTO GetProductsForCategory(Category category);
        ResponseDTO ChangeAmount(ProductDTO product, int amount);
        ResponseDTO AddProduct(ProductDTO product);
        

    }
}
