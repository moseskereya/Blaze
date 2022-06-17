using Blaze.Model;

namespace Blaze.Services
{
    public interface Iproductservice
    {
        List<Product> GetProducts();
        Product GetProductById(int id);
       void Saveproduct(Product product);
       void Deleteproduct(int id);

    }
}
