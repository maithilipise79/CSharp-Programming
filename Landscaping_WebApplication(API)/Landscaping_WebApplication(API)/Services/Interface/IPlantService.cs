using Landscaping_WebApplication_API_.Model;
using Landscaping_WebApplication_API_.Model.Landscaping;

namespace Landscaping_WebApplication_API_.Services.Implementation
{
    public interface IPlantService
    {
        Plant Add(Plant plant);
        Plant GetById(int id);

        PagedResult<Plant> GetAll(int pageIndex, int pageSize);
        Plant Update(Plant plant);
        bool Delete(int id);
    }
}
