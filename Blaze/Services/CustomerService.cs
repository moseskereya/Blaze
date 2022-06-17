using Blaze.Data;
using Blaze.Model;

namespace Blaze.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly  BlazeContext _context;
        public CustomerService(BlazeContext context)
        {
            _context = context;
        }

        public void DeleteCustomer(int id)
        {
            var customer = _context.customers.FirstOrDefault(x => x.Id == id);
            if (customer != null)
            {
                _context.customers.Remove(customer);
                _context.SaveChanges();
            }
        }

        public Customer GetCustomerById(int id)
        {
            var customer = _context.customers.SingleOrDefault(p => p.Id == id);
            return customer;
        }

        public List<Customer> GetCustomers()
        {
            return _context.customers.ToList();
        }

        public void SaveCustomer(Customer customer)
        {
            if (customer.Id == 0) _context.customers.Add(customer);
            else _context.customers.Update(customer);
            _context.SaveChanges();
            
        }
    }
}
