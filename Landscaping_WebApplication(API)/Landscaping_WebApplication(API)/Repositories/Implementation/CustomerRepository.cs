using Landscaping_WebApplication_API_.Model;
using Landscaping_WebApplication_API_.Model.Landscaping;
using Landscaping_WebApplication_API_.Repositories.Interface;

namespace Landscaping_WebApplication_API_.Repositories.Implementation
{
    public class CustomerRepository : ICustomerRepository
    {
        private static List<Customer> _customer=new List<Customer>();
        public Customer Add(Customer customer)
        {
            _customer.Add(customer);
            return customer;
        }

        public bool Delete(Customer customer)
        {
            var record=_customer.FirstOrDefault(x=>x.Id==customer.Id);
            if (record == null) return false;
            _customer.Remove(record);
            return true;
        }

        public PagedResult<Customer> GetAll(int pageIndex, int pageSize)
        {
            var totalCount = _customer.Count();

            var items=_customer.Skip((pageIndex-1)*pageSize).Take(pageSize).ToList();

            return new PagedResult<Customer>
            { 
                Items= items,
                TotalCount=totalCount,
                PageIndex=pageIndex,
                PageSize=pageSize
            };

        }

        public Customer GetById(int id)
        {
            return _customer.FirstOrDefault(x => x.Id == id);
        }

        public Customer Update(Customer customer)
        {
            var existing=_customer.FirstOrDefault(x=>x.Id== customer.Id);
            if (existing == null) return null;
            existing.Name = customer.Name;
            existing.Address = customer.Address;
            existing.Phone = customer.Phone;
            
            return existing;
        }
    }
}
