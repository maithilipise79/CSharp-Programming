using Landscaping_WebApplication_API_.Model.Landscaping;
using Landscaping_WebApplication_API_.Repositories.Interface;

using Landscaping_WebApplication_API_.Model;

namespace Landscaping_WebApplication_API_.Repositories.Implementation
{
    public class GardenerRepository : IGardenerRepository
    {

        private static List<Gardener> _gardener = new List<Gardener>();
        public Gardener Add(Gardener gardener)
        {
             _gardener.Add(gardener);
              return gardener;
        }

        public bool Delete(int id)
        {
            var gardener=_gardener.FirstOrDefault(g => g.Id == id);
            if (gardener != null)
            {
                return false;
            }
            else
            {
               _gardener.Remove(gardener);
                return true;
            }
                
        }

        public PagedResult<Gardener> GetAll(int pageIndex, int pageSize)
        {
            var totalCount=_gardener.Count;
            var item=_gardener.Skip((pageIndex-1)*pageSize).Take(pageSize).ToList();

            return new PagedResult<Gardener>
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                TotalCount = totalCount,
                Items = item
            };

        }

        public Gardener GetById(int id)
        {
            return _gardener.FirstOrDefault(x => x.Id == id);
        }

        public Gardener Update(Gardener gardener)
        {
            var existing= _gardener.FirstOrDefault(x=>x.Id == gardener.Id);
            if (existing != null) return null;
            existing.Name = gardener.Name;
            existing.Salary = gardener.Salary;
            existing.Phonre= gardener.Phonre;
            
            return existing;
        }

        
    }
}
