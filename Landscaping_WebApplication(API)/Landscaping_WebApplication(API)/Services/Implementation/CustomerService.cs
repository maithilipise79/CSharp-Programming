using Landscaping_WebApplication_API_.Model;
using Landscaping_WebApplication_API_.Model.Landscaping;
using Landscaping_WebApplication_API_.Repositories.Interface;

namespace Landscaping_WebApplication_API_.Services.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository= repository;
        }


        public Customer Add(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }
            if (string.IsNullOrWhiteSpace(customer.Name))
            {
                throw new Exception("Customer name is required ");
            }
            
            return _repository.Add(customer);
        }



        public bool Delete(int id)
        {
            if(id <= 0)
            {
                throw new Exception("Inavlid Id");
            }
            var customer=_repository.GetById(id);
            if(customer == null)
            {
                throw new Exception("Customer not found");
            }
            return _repository.Delete(customer);
        }




        public PagedResult<Customer> GetAll(int pageIndex, int pageSize)
        {
            if(pageSize>10)
            {
                pageSize=10;
            }
            return _repository.GetAll(pageIndex, pageSize);
        }



        public Customer GetById(int id)
        {
            if (id <= 0)
            {                                                          
                throw new ArgumentNullException("Invalid customer Service");

            }
            var record = _repository.GetById(id);

            if(record == null)
            {
                throw new Exception("Customer not found");
            }
            return record;
        }



        public Customer Update(Customer customer)
        {
            if(customer.Id<=0)
            {
                throw new Exception("Invalid Id");
            }

            var existing =_repository.GetById(customer.Id);
            if(existing == null)
            {
                throw new Exception("Customer not found");
            }
            if(string.IsNullOrWhiteSpace(customer.Name))
            {
                throw new Exception("Name Required");
            }
            return _repository.Update(customer);
        }
    }
}
