using Landscaping_WebApplication_API_.Model;
using Landscaping_WebApplication_API_.Model.Landscaping;

namespace Landscaping_WebApplication_API_.Repositories.Interface
{
    public interface IPlantRepository
    {
        Plant Add(Plant plant);
        Plant Update(Plant plant);
        Plant GetById(int id);

        PagedResult<Plant> GetAll(int pageIndex, int pageSize);

        bool Delete(int id);

    }
}
