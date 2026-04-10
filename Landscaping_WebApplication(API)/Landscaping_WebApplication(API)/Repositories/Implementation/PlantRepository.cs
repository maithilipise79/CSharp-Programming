using Landscaping_WebApplication_API_.Model;
using Landscaping_WebApplication_API_.Model.Landscaping;
using Landscaping_WebApplication_API_.Repositories.Interface;

namespace Landscaping_WebApplication_API_.Repositories.Implementation
{
    public class PlantRepository : IPlantRepository
    {
        private readonly List<Plant> _plants= new List<Plant>();
        public Plant Add(Plant plant)
        {
            _plants.Add(plant);
            return plant;
        }

        public bool Delete(int id)
        {
            
            var result=_plants.FirstOrDefault(p => p.Id == id);
            if(result == null) return false;
            _plants.Remove(result);
            return true;
        }

        public PagedResult<Plant> GetAll(int pageIndex, int pageSize)
        {
            var totalCount = _plants.Count();
            var items=_plants.Skip((pageIndex-1)*pageSize).Take(pageSize).ToList();

            return new PagedResult<Plant>
            { 
                Items = items, 
                TotalCount = totalCount ,
                PageIndex=pageIndex,
                PageSize=pageSize
            };
        }

        public Plant GetById(int id)
        {
            return _plants.FirstOrDefault(x => x.Id == id);
        }

        public Plant Update(Plant plant)
        {
            var existing=_plants.FirstOrDefault(x=>x.Id==plant.Id);
            if (existing == null) return null;
            existing.Name = plant.Name;
            existing.Name= plant.Name;
            return existing;
        }
    }
}
