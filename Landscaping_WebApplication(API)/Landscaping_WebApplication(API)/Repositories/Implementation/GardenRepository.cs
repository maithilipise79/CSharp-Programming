using Landscaping_WebApplication_API_.Model;
using Landscaping_WebApplication_API_.Model.Landscaping;
using Landscaping_WebApplication_API_.Repositories.Interface;

namespace Landscaping_WebApplication_API_.Repositories.Implementation
{
    public class GardenRepository : IGardenRepository
    {
        private readonly List<Garden> _garden=new List<Garden>();
        public Garden Add(Garden garden)
        {
            _garden.Add(garden);
            return garden;

        }

        public bool Delete(int id)
        {
            var record = _garden.FirstOrDefault(x => x.Id == id);
            if(record == null) return false;
            _garden.Remove(record);
            return true;
        }

        public PagedResult<Garden> GetAll(int pageIndex, int pageSize)
        {
            var totalCount=_garden.Count;
            var items=_garden.Skip((pageIndex-1)*pageSize).Take(pageSize).ToList();
            return new PagedResult<Garden>
            { 
                PageIndex=pageIndex,
                TotalCount=totalCount,
                Items=items,
                PageSize=pageSize
            };

        }

        public Garden GetById(int id)
        {
            return _garden.FirstOrDefault(x => x.Id == id);
        }

        public Garden Update(Garden garden)
        {
            var existing=_garden.FirstOrDefault(x=>x.Id == garden.Id);
            if (existing == null) return existing;
            existing.Location = garden.Location;
            existing.Name = garden.Name;

            return existing;
        }
    }
}
