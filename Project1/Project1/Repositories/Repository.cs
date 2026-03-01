using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private static List<T> _data = new List<T>();
        private static long _nextId = 1;

        public void Add(T entity)
        {
            if (entity == null)
            {
                Console.WriteLine("Record is required ");
                return;
            }
            else
            {
                _data.Add(entity);
                entity.Id = _nextId++;
            }
        }
        public bool Delete(long id)
        {
            var remove=_data.RemoveAll(x => x.Id == id);
            return remove > 0;
        }
        public T GetById(long id)
        {
            var ob = _data.FirstOrDefault(x => x.Id == id);
            if(ob == null)
            {
                Console.WriteLine($"Could not find id {id}");
            }
            return ob;
        }

        public IList<T> GetAll()
        {
            return _data.ToList();
        }

        
    }
}
