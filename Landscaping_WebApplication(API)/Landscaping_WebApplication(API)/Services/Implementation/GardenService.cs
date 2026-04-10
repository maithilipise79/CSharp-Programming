using Landscaping_WebApplication_API_.Model;
using Landscaping_WebApplication_API_.Model.Landscaping;
using Landscaping_WebApplication_API_.Repositories.Interface;

namespace Landscaping_WebApplication_API_.Services.Implementation
{
    public class GardenService : IGardenService
    {
        private readonly IGardenRepository _gardenRepository;

        public GardenService(IGardenRepository gardenRepository)
        {
            _gardenRepository = gardenRepository;
        }


        public Garden Add(Garden garden)
        {
            if(garden==null)
            {
                throw new ArgumentNullException(nameof(garden));
            }
            if(string.IsNullOrWhiteSpace(garden.Name))
            {
                throw new Exception("Garden Name is Required");
            }
            if(string.IsNullOrWhiteSpace(garden.Location))
            {
                throw new Exception("Garden Location Is Required ");
            }
            var allGarden= _gardenRepository.GetAll(0,int.MaxValue).Items;

            if(allGarden.Any(x=>x.Name.ToLower() ==garden.Name.ToLower()))
            {
                throw new Exception("Garden id Allready Exits");
            }

            return _gardenRepository.Add(garden);
        }


        public bool Delete(int id)
        {
            if(id<=0)
            {
                throw new Exception("Invalid Id");
            }
            var garden=_gardenRepository.GetById(id);
            if(garden==null)
            {
                throw new Exception("Garden not Found");
            }

            return _gardenRepository.Delete(id);

        }

        public PagedResult<Garden> GetAll(int pageIndex, int pageSize)
        {
            if(pageSize>15)
            {
                pageSize = 15;
            }
            return _gardenRepository.GetAll(pageIndex, pageSize);
        }


        public Garden GetById(int id)
        {
            if(id<=0)
            {
                throw new Exception("Invalid Id");
            }
            var garden=_gardenRepository.GetById(id);
            if(garden== null)
            {
                throw new Exception("Garden not Found");
            }
            return garden;
        }

        public Garden Update(Garden garden)
        {
            if(garden.Id<=0)
            {
                throw new Exception("Invalid Id");
            }

            var existing=_gardenRepository.GetById(garden.Id);

            if(existing==null)
            {
                throw new Exception("Gardent not found");
            }

            if(string.IsNullOrWhiteSpace(garden.Name))
            {
                throw new Exception("Garden Name Is Requird");
            }
            if(string.IsNullOrWhiteSpace(garden.Location))
            {
                throw new Exception("Garden Name Is Requird");
            }

            return _gardenRepository.Update(garden);

        }
    }
}
