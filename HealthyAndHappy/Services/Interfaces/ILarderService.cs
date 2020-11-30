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
        ProductsDTO GetProductsForCategory(Product product);
        ResponseDTO ChangeAmount(Product product, int amount);
        ResponseDTO AddProduct(Product product);
        

    }
}
