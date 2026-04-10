using Landscaping_WebApplication_API_.Model;
using Landscaping_WebApplication_API_.Model.Landscaping;

namespace Landscaping_WebApplication_API_.Repositories.Interface
{
    public interface ICustomerRepository
    {
        Customer Add(Customer customer);
        Customer GetById(int id);
        PagedResult<Customer> GetAll(int pageIndex,int pageSize);
        Customer Update(Customer customer);
        bool Delete(Customer customer);

        
    }
}
