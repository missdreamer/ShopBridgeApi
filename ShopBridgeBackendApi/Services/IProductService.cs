using ShopBridgeBackendApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridgeBackendApi.Services
{
    interface IProductService
    {
        void AddProduct( Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
    }
}
