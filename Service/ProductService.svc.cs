using Service.Models;
using System.Collections.Generic;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductService.svc or ProductService.svc.cs at the Solution Explorer and start debugging.
    public class ProductService : IProductService
    {
        public List<Product> GetAll()
        {
            return new List<Product> {
                new Product()
                {
                    Id = 1,
                    Name = "Test",
                    Price = 1000
                },
                new Product()
                {
                    Id = 2,
                    Name = "Test 2",
                    Price = 2000
                }
            };
        }

        public Product GetById(string id)
        {
            return new Product()
            {
                Id = 1,
                Name = "Test",
                Price = 1000
            };
        }

        public Product Post(Product request)
        {
            return request;
        }
    }
}
