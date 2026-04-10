using Landscaping_WebApplication_API_.Model;
using Landscaping_WebApplication_API_.Model.Landscaping;

namespace Landscaping_WebApplication_API_.Repositories.Interface
{
    public interface IIrrigationSystemRepository
    {
        IrrigationSystem Add(IrrigationSystem irrigationSystem);
        IrrigationSystem GetById(int id);
        PagedResult<IrrigationSystem> GetAll(int pageIndex, int pageSize);
        IrrigationSystem Update(IrrigationSystem irrigationSystem);

        bool Delete(int id);

    }
}
