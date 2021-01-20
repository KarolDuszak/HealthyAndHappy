using AutoMapper;
using HealthyAndHappy.Data;
using HealthyAndHappy.Models;
using HealthyAndHappy.Models.ModelsDTO;
using HealthyAndHappy.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Services
{
    public class LarderService : ILarderService
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public LarderService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public ResponseDTO AddProduct(ProductDTO productDTO)
        {
            var product = _mapper.Map<ProductForLarder>(productDTO);
            try
            {
                _context.ProductsForLarder.Add(product);
                return ResponseDTO.Successful();
            }
            catch (Exception)
            {

                return ResponseDTO.Unsuccessful();
            }
        }

        public ResponseDTO ChangeAmount(ProductDTO productDTO, int amount)
        {
            var product = _context.ProductsForLarder.Single(p => p.Id == productDTO.Id);
            try
            {
                product.Amount = amount;
                _context.ProductsForLarder.Update(product);
                return ResponseDTO.Successful();
            }
            catch (Exception)
            {

                return ResponseDTO.Unsuccessful();
            }
        }

        public LarderDTO Get(string userId) => _mapper.Map<LarderDTO>(_context.Larder.Single(l => l.UserId == userId));
        

        public ProductsDTO GetProductsForCategory(Category category) => _mapper.Map<ProductsDTO>(_context.ProductsForLarder.Where(p=>p.Category == category));
       
    }
}
