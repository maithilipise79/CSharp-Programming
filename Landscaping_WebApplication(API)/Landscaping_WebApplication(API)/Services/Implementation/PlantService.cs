using Landscaping_WebApplication_API_.Model;
using Landscaping_WebApplication_API_.Model.Landscaping;
using Landscaping_WebApplication_API_.Repositories.Interface;

namespace Landscaping_WebApplication_API_.Services.Implementation
{
    public class PlantService:IPlantService
    {
        private readonly IPlantRepository _plantRepository;

        public PlantService(IPlantRepository repository)
        {
            _plantRepository = repository;
        }


        public Plant Add(Plant plant)
        {
            if (plant == null)
            {
                throw new ArgumentNullException(nameof(plant));
            }
            if (string.IsNullOrWhiteSpace(plant.Name))
            {
                throw new Exception("plant Name is Required");
            }
            if (string.IsNullOrWhiteSpace(plant.Type))
            {
                throw new Exception("plant type is Required");
            }
            

            return _plantRepository.Add(plant);

        }


        public bool Delete(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Invalid Id");
            }
            var gardener = _plantRepository.GetById(id);
            if (gardener == null)
            {
                throw new Exception("plant Not Found");
            }

            return _plantRepository.Delete(id);
        }

        public PagedResult<Plant> GetAll(int pageIndex, int pageSize)
        {
            if (pageSize > 15)
            {
                pageSize = 15;
            }

            return _plantRepository.GetAll(pageIndex, pageSize);
        }


        public Plant GetById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentNullException("Plant Gardener Id");
            }
            var plant = _plantRepository.GetById(id);
            if (plant == null)
            {
                throw new Exception("Plant not found");
            }
            return plant;
        }


        public Plant Update(Plant plant)
        {
            if (plant == null)
            {
                throw new ArgumentNullException(nameof(plant));
            }

            if (string.IsNullOrWhiteSpace(plant.Name))
            {
                throw new Exception("plant name is requird");
            }

            if (string.IsNullOrWhiteSpace(plant.Type))
            {
                throw new Exception("type Numberer is requird ");
            }

            return _plantRepository.Update(plant);
        }
    }
}
