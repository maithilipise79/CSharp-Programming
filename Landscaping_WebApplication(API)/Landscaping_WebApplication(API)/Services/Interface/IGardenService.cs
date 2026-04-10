using Landscaping_WebApplication_API_.Model;
using Landscaping_WebApplication_API_.Model.Landscaping;

namespace Landscaping_WebApplication_API_.Services.Implementation
{
    public interface IGardenService
    {
        Garden Add(Garden garden);
        Garden GetById(int id);

        PagedResult<Garden> GetAll(int pageIndex, int pageSize);
        Garden Update(Garden garden);
        bool Delete(int id);
    }
}
