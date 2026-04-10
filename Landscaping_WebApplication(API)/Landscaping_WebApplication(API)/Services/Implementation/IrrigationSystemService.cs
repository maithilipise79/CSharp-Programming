using Landscaping_WebApplication_API_.Model;
using Landscaping_WebApplication_API_.Model.Landscaping;
using Landscaping_WebApplication_API_.Repositories.Implementation;

namespace Landscaping_WebApplication_API_.Services.Implementation
{
    public class IrrigationSystemService : IIrrigationSystemService
    {
        private readonly IrrigationSystemRepository _repository;

        public IrrigationSystemService(IrrigationSystemRepository repository)
        {
            _repository = repository;
        }

        public IrrigationSystem Add(IrrigationSystem irrigationSystem)
        {
            if(irrigationSystem==null) throw new ArgumentNullException(nameof(irrigationSystem));

            if(string.IsNullOrWhiteSpace(irrigationSystem.Type))
            {
                throw new Exception("Types id requird");
            }
            if(irrigationSystem.WaterCapacity<=0)
            {
                throw new Exception("Invalid waterCapacity");
            }

            _repository.Add(irrigationSystem);
            return irrigationSystem;

        }

        public bool Delete(int id)
        {
            if(id<=0)
            {
                throw new Exception("Invalid id");
            }
            var record = _repository.GetById(id);

            if(record==null)
            {
                throw new Exception($"Record not found");
            }

            return _repository.Delete(id);
        }


        public PagedResult<IrrigationSystem> GetAll(int pageIndex, int pageSize)
        {
            if(pageIndex>=15)
            {
                pageIndex=15;
            }
            return _repository.GetAll(pageIndex, pageSize);
        }



        public IrrigationSystem GetById(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Invalid Id");
            }
            var record= _repository.GetById(id);
                if (record == null)
                {
                    throw new Exception("record not found");
                }
                return record;
        }



        public IrrigationSystem Update(IrrigationSystem irrigationSystem)
        {
            if(irrigationSystem.Id<=0)
            {
                throw new Exception("Invalid Id");
            }

            var  existing = _repository.GetById(irrigationSystem.Id);

            if(existing==null)
            {
                throw new Exception("Record not found");
            }
            return _repository.Update(irrigationSystem);
        }
    }
}
