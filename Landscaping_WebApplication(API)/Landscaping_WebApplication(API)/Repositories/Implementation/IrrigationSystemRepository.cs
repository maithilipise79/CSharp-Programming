using Landscaping_WebApplication_API_.Model;
using Landscaping_WebApplication_API_.Model.Landscaping;
using Landscaping_WebApplication_API_.Repositories.Interface;

namespace Landscaping_WebApplication_API_.Repositories.Implementation
{
    public class IrrigationSystemRepository :IIrrigationSystemRepository
    {
        private readonly List<IrrigationSystem> _irrigationRepository=new List<IrrigationSystem>();

        public IrrigationSystem Add(IrrigationSystem irrigation)
        {
            _irrigationRepository.Add(irrigation);
            return irrigation;
        }

        public bool Delete(int id)
        {
            var result=_irrigationRepository.FirstOrDefault(i => i.Id == id);
            if (result == null) return false;
            _irrigationRepository.Remove(result);
            return true;
        }

        public PagedResult<IrrigationSystem> GetAll(int pageIndex, int pageSize)
        {
            var totalCount = _irrigationRepository.Count();

            var items = _irrigationRepository.Skip((pageIndex-1)*pageSize).Take(pageSize).ToList();
                
                
            return new PagedResult<IrrigationSystem>
            { 
                TotalCount=totalCount,
                Items=items,
                PageIndex=pageIndex,
                PageSize=pageSize

            };

        }

        public IrrigationSystem GetById(int id)
        {
            return _irrigationRepository.FirstOrDefault(x => x.Id == id);
        }

        public IrrigationSystem Update(IrrigationSystem irrigationSystem)
        {
            var existing = _irrigationRepository.FirstOrDefault(x => x.Id == irrigationSystem.Id);
            if (existing == null) return null;
            existing.Type = irrigationSystem.Type;
            existing.WaterCapacity = irrigationSystem.WaterCapacity;

            return existing;
        }
    }
}
