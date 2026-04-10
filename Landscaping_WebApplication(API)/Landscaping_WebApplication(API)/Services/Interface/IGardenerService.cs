using Landscaping_WebApplication_API_.Model;
using Landscaping_WebApplication_API_.Model.Landscaping;

namespace Landscaping_WebApplication_API_.Services.Implementation
{
    public interface IGardenerService
    {
        Gardener Add(Gardener gardener);
        Gardener GetById(int id);

        PagedResult<Gardener> GetAll(int pageIndex, int pageSize);
        Gardener Update(Gardener gardener);
        bool Delete(int id);
    }
}
