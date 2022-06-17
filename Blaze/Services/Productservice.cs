using Blaze.Data;
using Blaze.Model;

namespace Blaze.Services
{
    public class Productservice : Iproductservice
    {
        private readonly BlazeContext? _context;

        public Productservice(BlazeContext? context)
        {
            _context = context;
        }

        public void Deleteproduct(int id)
        {
            var product = _context.products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _context.Remove(product);
                _context.SaveChanges();
            }
        }

        public Product GetProductById(int id)
        {
            var product = _context.products.SingleOrDefault(p => p.Id == id);
            return product;
        }

        public List<Product> GetProducts()
        {
           return  _context.products.ToList();
        }

        public void Saveproduct(Product product)
        {
            if (product.Id == 0) _context.products.Add(product);
            else _context.products.Update(product);
            _context.SaveChanges();
        }
    }
}
