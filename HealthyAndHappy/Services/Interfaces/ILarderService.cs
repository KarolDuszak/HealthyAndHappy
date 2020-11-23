using HealthyAndHappy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Services.Interfaces
{
    public interface ILarderService
    {
        Larder Get(string userId);
        List<Product> GetProductsForCategory(Product p);
        bool ChangeAmount(Product p, int amount);
        bool AddProduct(Product p);
    }
}
