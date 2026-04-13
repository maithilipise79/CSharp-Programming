using Landscaping_WebApplication_API_.Model;
using Landscaping_WebApplication_API_.Model.Landscaping;
using Landscaping_WebApplication_API_.Repositories.Interface;

namespace Landscaping_WebApplication_API_.Services.Implementation
{
    public class GardenerService : IGardenerService
    {
        private readonly IGardenerRepository _gardenerRepository; 

        public GardenerService(IGardenerRepository repository)
        {
            _gardenerRepository = repository;
        }


        public Gardener Add(Gardener gardener)
        {
            if(gardener==null)
            {
                throw new ArgumentNullException(nameof(gardener));
            }
            if(string.IsNullOrWhiteSpace(gardener.Name))
            {
                throw new Exception("Gardener Name is Required");
            }
            if(string.IsNullOrWhiteSpace(gardener.Phonre))
            {
                throw new Exception("Gardener Contect Number is Required");
            }
            if(gardener.Salary<=0)
            {
                throw new Exception("Invalid Salary");
            }

            return  _gardenerRepository.Add(gardener);

        }


        public bool Delete(int id)
        {
            if(id<=0)
            {
                throw new Exception("Invalid Id");
            }
            var gardener=_gardenerRepository.GetById(id);
            if(gardener==null)
            {
                throw new Exception("Gardener Not Found");
            }

            return _gardenerRepository.Delete(id);
        }

        public PagedResult<Gardener> GetAll(int pageIndex, int pageSize)
        {
            if(pageSize>15)
            {
                pageSize=15;
            }

            return _gardenerRepository.GetAll(pageIndex, pageSize);
        }


        public Gardener GetById(int id)
        {
            if(id<=0)
            {
                throw new ArgumentNullException("Invalid Gardener Id");
            }
            var gardener = _gardenerRepository.GetById(id);
            if(gardener==null)
            {
                throw new Exception("Gardener not found");
            }
            return gardener;
        }


        public Gardener Update(Gardener gardener)
        {
            if(gardener==null)
            {
                throw new ArgumentNullException(nameof(gardener));  
            }

            if(string.IsNullOrWhiteSpace(gardener.Name))
            {
                throw new Exception("Gardener name is requird");
            }

            if(string.IsNullOrWhiteSpace(gardener.Phonre))
            {
                throw new Exception("Gardner Contact Numberer is requird ");
            }

            return _gardenerRepository.Update(gardener);
        }
    }
}
