using Microsoft.EntityFrameworkCore;
using Restaurant_Management_System.Data;
using Restaurant_Management_System.Entity;
using Restaurant_Management_System.Repository.Definition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System.Repository.Implementation
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }


        public async Task<T> CreateAsync(T entity)
        {
            var createEntity = await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return createEntity.Entity;
        }



        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null)
            {
                return false;
            }
            else
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }

        }


        public async Task<IList<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await _dbSet.FirstOrDefaultAsync(e => e.Id == id);
            return entity;
        }


        public async Task<T> UpdateAsync(int id, T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            var existingEntity = await _dbSet.FirstOrDefaultAsync(e => e.Id == id);
            if (existingEntity == null)
            {
                return null;
            }
            entity.Id = id;

            _context.Entry(existingEntity).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();
            return existingEntity;

        }


    }
}
