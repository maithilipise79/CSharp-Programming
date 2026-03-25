using DemoRepositoryPattern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRepositoryPattern.Data.Defination
{
    public interface IRepository<T> where T : BaseEntity
    {
        IList<T> GetAll();
        T GetById(long id);
        void Add(T entity);
        bool Delete(long id);

    }
}
