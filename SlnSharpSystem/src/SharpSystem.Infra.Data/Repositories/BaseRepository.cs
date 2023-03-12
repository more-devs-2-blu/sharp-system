using SharpSystem.Domain.IServices;
using SharpSystem.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSystem.Infra.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly SQLServerContext _context;
        public BaseRepository(SQLServerContext context)
        {
            _context = context;
        }

        public Task<int> Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            return _context.SaveChangesAsync();
        }

        public IQueryable<T> FindAll()
        {
            return _context.Set<T>();
        }

        public Task<T> FindById(int id)
        {
            _context.Set<T>().FindAsync();
        }

        public async Task<int> Save(T entity)
        {
            _context.Set<T>().Add(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(T entity)
        {
            try
            {
                _context.Set<T>().Update(entity);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return await _context.SaveChangesAsync();
            }
        }
    }
}
