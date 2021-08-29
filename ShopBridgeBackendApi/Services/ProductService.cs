using ShopBridgeBackendApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridgeBackendApi.Model
{
    public class ProductService:IProductService
    {
        //crud operation on db
        private readonly ProductDbContext _context;
        
        public ProductService(ProductDbContext productDbContext)
        {
            _context = productDbContext;
        }

        public void AddProduct( Product product)
        {

            
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
           
            _context.Products.Add(product);
            
        }

        public void DeleteProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                _context.Products.Remove(product);
               
            }
           
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList<Product>();
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
           
        }
        public Product GetProduct(int Id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == Id);
        }
    }
}
