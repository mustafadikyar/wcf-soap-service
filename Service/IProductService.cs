using Service.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductService" in both code and config file together.
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        Product GetById(string id);

        [OperationContract]
        List<Product> GetAll();

        [OperationContract]
        Product Post(Product request);
    }
}
