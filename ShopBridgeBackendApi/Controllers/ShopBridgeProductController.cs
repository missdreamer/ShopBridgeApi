using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopBridgeBackendApi.Model;
using ShopBridgeBackendApi.Services;

namespace ShopBridgeBackendApi.Controllers
{
    [Route("api/ShopBridgeProduct")]
    [ApiController]
    public class ShopBridgeProductController : ControllerBase
    {
        private readonly IProductService _productService;
         ShopBridgeProductController(IProductService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }
       
        [HttpGet]
        [Route("[action]")]
        [Route("api/ShopBridgeProduct/GetProducts")]
        public IEnumerable<Product> GetProducts()
        {
            return _productService.GetProducts();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ShopBridgeProduct/AddProduct")]
        public IActionResult AddProduct([FromBody]Product product)
        {
            _productService.AddProduct(product);
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ShopBridgeProduct/UpdateProduct")]
        public IActionResult UpdateProduct([FromBody]Product product)
        {
            _productService.UpdateProduct(product);
            return Ok();
        }


        [HttpDelete]
        [Route("[action]")]
        [Route("api/ShopBridgeProduct/DeleteProduct")]
        public IActionResult DeleteProduct(int id)
        {
            var existingProduct = _productService.GetProduct(id);
            if (existingProduct != null)
            {
                _productService.DeleteProduct(existingProduct.Id);
                return Ok();
            }
            return NotFound($"Product Not Found with ID : {existingProduct.Id}");
        }
        [HttpGet]
        [Route("GetProduct")]
        public Product GetProduct(int id)
        {
            return _productService.GetProduct(id);
        } 
        
    }
}
